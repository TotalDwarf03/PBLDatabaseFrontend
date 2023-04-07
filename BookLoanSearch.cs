using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBLDatabaseFrontend
{
    public partial class BookLoanSearch : Form
    {
        public BookLoanSearch()
        {
            InitializeComponent();
        }

        SQLController controller = new SQLController();

        /// <summary>
        /// Shows the Dashboard Screen and Closes any other open screens
        /// </summary>
        private void ReturntoDashboard()
        {
            this.Owner.Show();

            Form[] OwnedForms = this.Owner.OwnedForms;

            foreach (Form form in OwnedForms)
            {
                form.Dispose();
            }
        }

        // { <Field Display Name>, <Database ID Field>, <Database Descriptor Field> }
        string[,] BookFilters = { { "Author", "authorid AS ID", "fname || ' ' || sname AS DESC" }, { "Category", "categoryid AS ID", "type AS DESC" } };
        string[,] LoanFilters = { { "Member", "memberid AS ID", "fname || ' ' || sname AS DESC" } };

        /// <summary>
        /// Populates cbSearchFilter with correct filters for table
        /// </summary>
        private void UpdateFilters()
        {
            cbSearchFilter.Items.Clear();

            if (cbTables.SelectedItem == "Book")
            {
                for (int i = 0; i < BookFilters.Length / 3; i++)
                {
                    cbSearchFilter.Items.Add(BookFilters[i, 0]);
                }

                btnLoanReturn.Enabled = false;
            }
            else if (cbTables.SelectedItem == "Loan")
            {
                for (int i = 0; i < LoanFilters.Length / 3; i++)
                {
                    cbSearchFilter.Items.Add(LoanFilters[i, 0]);
                }

                btnLoanReturn.Enabled = true;
            }

            cbSearchFilter.SelectedIndex = -1;
        }

        /// <summary>
        /// Creates the Select SQL Statement to populate cbSearchItem
        /// </summary>
        /// <returns>SQL Select Statement String</returns>
        private string GetSelectClause()
        {
            string SelectStatement = "";

            int index = cbSearchFilter.SelectedIndex;
            string selectedTable = cbTables.SelectedItem.ToString();

            if (selectedTable == "Book")
            {
                SelectStatement = $"{BookFilters[index, 1]}, {BookFilters[index, 2]}";
            }
            else if (selectedTable == "Loan")
            {
                SelectStatement = $"{LoanFilters[index, 1]}, {LoanFilters[index, 2]}";
            }

            return SelectStatement;
        }

        /// <summary>
        /// Gets the table needed to populate cbSearchItem
        /// </summary>
        /// <returns>The name of the table to query</returns>
        private string GetTableName()
        {
            string QueryTable = "";

            int index = cbSearchFilter.SelectedIndex;
            string selectedTable = cbTables.SelectedItem.ToString();

            if (selectedTable == "Book")
            {
                QueryTable = $"{BookFilters[index, 0].ToLower()}";
            }
            else if (selectedTable == "Loan")
            {
                QueryTable = $"{LoanFilters[index, 0].ToLower()}";
            }

            return QueryTable;
        }

        /// <summary>
        /// Gets the data for the listview based on the filters
        /// </summary>
        private void PopulateListview()
        {
            DataTable dt = new DataTable();

            // If Has a Filter
            if (cbSearchFilter.SelectedIndex != -1)
            {
                int FilterIndex = cbSearchFilter.SelectedIndex;
                string sqlQuery = "";

                if (cbTables.SelectedItem == "Book")
                {
                    sqlQuery = $@"  SELECT 
                                        b.bookid AS BookID,
                                        b.title AS Title,
                                        a.fname || ' ' || a.sname AS Author,
                                        c.type AS Category
                                    FROM book AS b
                                    JOIN author AS a
                                        ON b.authorid = a.authorid
                                    JOIN category AS c
                                        ON b.categoryid = c.categoryid
                                    WHERE {BookFilters[FilterIndex, 1].Replace(" AS ID", "")} = {cbSearchItem.SelectedValue.ToString()}";

                    dt = controller.RunQuery(sqlQuery);
                }
                else if (cbTables.SelectedItem == "Loan")
                {
                    sqlQuery = $@"  SELECT 
                                        l.loanid AS LoanID,
                                        b.title AS Book,
                                        m.fname || ' ' || m.sname AS Member,
                                        l.dateout AS DateOut,
                                        l.datedue AS DateDue,
                                        l.datereturned AS DateReturned
                                    FROM loan AS l
                                    JOIN book AS b
                                        ON l.bookid = b.bookid
                                    JOIN member AS m
                                        ON l.memberid = m.memberid
                                    WHERE {LoanFilters[FilterIndex, 1].Replace(" AS ID", "")} = {cbSearchItem.SelectedValue.ToString()}";

                    dt = controller.RunQuery(sqlQuery);
                }
            }
            // If Doesn't have a Filter
            else
            {
                if (cbTables.SelectedItem == "Book")
                {
                    string sqlQuery = $@"   SELECT 
                                                b.bookid AS BookID,
                                                b.title AS Title,
                                                a.fname || ' ' || a.sname AS Author,
                                                c.type AS Category
                                            FROM book AS b
                                            JOIN author AS a
                                                ON b.authorid = a.authorid
                                            JOIN category AS c
                                                ON b.categoryid = c.categoryid";

                    dt = controller.RunQuery(sqlQuery);
                }
                else if (cbTables.SelectedItem == "Loan")
                {
                    string sqlQuery = $@"   SELECT 
                                                l.loanid AS LoanID,
                                                b.title AS Book,
                                                m.fname || ' ' || m.sname AS Member,
                                                l.dateout AS DateOut,
                                                l.datedue AS DateDue,
                                                l.datereturned AS DateReturned
                                            FROM loan AS l
                                            JOIN book AS b
                                                ON l.bookid = b.bookid
                                            JOIN member AS m
                                                ON l.memberid = m.memberid";

                    dt = controller.RunQuery(sqlQuery);
                }
            }

            ListView.Clear();

            foreach (DataColumn col in dt.Columns)
            {
                ListView.Columns.Add(col.ColumnName);
            }

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = row[0].ToString();

                for (int i = 1; i < ListView.Columns.Count; i++)
                {
                    listItem.SubItems.Add(row[i].ToString());
                }
                ListView.Items.Add(listItem);
            }

            ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            ListView.Columns[1].Width = 200;    // Resize book title column as too wide (always 2nd column)
        }

        private void BookLoanSearch_Load(object sender, EventArgs e)
        {
            cbTables.Items.Add("Book");
            cbTables.Items.Add("Loan");

            cbTables.SelectedIndex = 0;
        }

        private void BookLoanSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturntoDashboard();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReturntoDashboard();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            cbSearchFilter.SelectedIndex = -1;
            cbSearchItem.SelectedIndex = -1;
            cbSearchItem.Enabled = false;

            PopulateListview();
        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilters();
            cbSearchItem.SelectedIndex = -1;
            cbSearchItem.Enabled = false;

            PopulateListview();
        }

        private void cbSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearchFilter.SelectedIndex != -1)
            {
                int SelectedIndex = cbSearchFilter.SelectedIndex;

                // Populate Search Item Drop Down
                string SearchItemSQL = $@"  SELECT
                                            {GetSelectClause()}
                                        FROM {GetTableName()}";

                DataTable dt = controller.RunQuery(SearchItemSQL);

                cbSearchItem.DataSource = dt;
                cbSearchItem.ValueMember = "ID";
                cbSearchItem.DisplayMember = "DESC";
                //cbSearchItem.SelectedIndex = -1;

                cbSearchItem.Enabled = true;
            }
        }

        private void cbSearchItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearchItem.SelectedIndex != -1)
            {
                PopulateListview();
            }
        }
    }
}
