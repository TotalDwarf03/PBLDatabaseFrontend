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

        private void BookLoanSearch_Load(object sender, EventArgs e)
        {
            cbTables.Items.Add("Book");
            cbTables.Items.Add("Loan");

            cbTables.SelectedIndex = 0;
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
        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilters();
            cbSearchItem.Enabled = false;
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
            }
        }
    }
}
