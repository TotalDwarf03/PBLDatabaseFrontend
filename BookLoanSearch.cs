using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        // { <Field Display Name>, <Database ID Field>, <Database Descriptor Field>, <Database Table Alias> }
        string[,] BookFilters = { { "Author", "authorid AS ID", "fname || ' ' || sname AS DESC", "a." }, { "Category", "categoryid AS ID", "type AS DESC", "c." } };
        string[,] LoanFilters = { { "Member", "memberid AS ID", "fname || ' ' || sname AS DESC", "m." } };

        /// <summary>
        /// Populates cbSearchFilter with correct filters for table
        /// </summary>
        private void UpdateFilters()
        {
            // Empty Current dropdown options
            cbSearchFilter.Items.Clear();

            if (cbTables.SelectedItem == "Book")
            {
                // Add each filter to the dropdown
                for (int i = 0; i < BookFilters.Length / 3; i++)
                {
                    cbSearchFilter.Items.Add(BookFilters[i, 0]);
                }

                btnLoanReturn.Enabled = false;
            }
            else if (cbTables.SelectedItem == "Loan")
            {
                // Add each filter to the dropdown
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

            // Calculate which columns are to be selected based on inputs
            // Example of SelectStatement: authorid AS ID, fname || ' ' || sname AS DESC
            // Needs to be dynamic as we do not know which column they are filtering on
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

            // Gets which table the filter data is in
            // i.e if filtering on authors, need to look in author table
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
            if (cbSearchItem.SelectedIndex != -1)
            {
                int FilterIndex = cbSearchFilter.SelectedIndex;
                string sqlQuery = "";

                string SearchItem = cbSearchItem.SelectedValue.ToString();

                if (cbTables.SelectedItem == "Book")
                {
                    // Where clause example: a.authorid = 2
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
                                    WHERE {BookFilters[FilterIndex, 3] + BookFilters[FilterIndex, 1].Replace(" AS ID", "")} = {SearchItem}";

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
                                    WHERE {LoanFilters[FilterIndex, 3] + LoanFilters[FilterIndex, 1].Replace(" AS ID", "")} = {SearchItem}";

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

            // for each column in the datatable, add it to the listview
            foreach (DataColumn col in dt.Columns)
            {
                ListView.Columns.Add(col.ColumnName);
            }

            // for each row in the datatable, add it to the listview
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

            // resize columns based on column content
            ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            // Resize book title column manually as content too wide (always 2nd column)
            ListView.Columns[1].Width = 200;    
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
            cbSearchItemPopulated = false;

            PopulateListview();
        }

        // Variable to show if cbSearchItem is Populated (cbSearchItem called when setting up combobox)
        bool cbSearchItemPopulated = false;

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
                cbSearchItem.SelectedIndex = -1;

                cbSearchItem.Enabled = true;
                cbSearchItemPopulated = true;
            }
        }

        private void cbSearchItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearchItemPopulated)
            {
                PopulateListview();
            }
        }

        private void btnLoanReturn_Click(object sender, EventArgs e)
        {
            if (ListView.SelectedIndices.Count > 0)
            {
                // Gets the selected row's LoanID
                int SelectedRow = ListView.SelectedIndices[0];
                string SelectedLoanID = ListView.Items[SelectedRow].Text;

                string currentDate = DateTime.Today.ToString("yyyy-MM-dd");

                string UpdateSQL = $@"  UPDATE loan
                                    SET datereturned = '{currentDate}'
                                    WHERE loanid = {SelectedLoanID}
                                        AND IFNULL(datereturned, 1) = 1";

                int changed = controller.RunNonQuery(UpdateSQL);

                if (changed > 0)
                {
                    MessageBox.Show("Book marked as returned.");
                    PopulateListview();
                }
                else
                {
                    MessageBox.Show("Book already returned.");
                }
            }
            else
            {
                MessageBox.Show("Please select a loan to return.");
            }
            
        }
    }
}
