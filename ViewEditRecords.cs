using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBLDatabaseFrontend
{
    public partial class ViewEditRecords : Form
    {
        public ViewEditRecords()
        {
            InitializeComponent();
        }

        SQLController controller = new SQLController();

        DataTable dt;

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

        private void BookLoanSearch_Load(object sender, EventArgs e)
        {
            cbTables.Items.Add("Author");
            cbTables.Items.Add("Book");
            cbTables.Items.Add("Category");
            cbTables.Items.Add("Loan");
            cbTables.Items.Add("Member");

            cbTables.SelectedIndex = 0;

            cbMode.Items.Add("View");
            cbMode.Items.Add("Edit");

            cbMode.SelectedIndex = 0;
        }

        private void ViewEditRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit? Unsaved changes will be lost.", "Are you sure?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ReturntoDashboard();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReturntoDashboard();
        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGrid.DataSource = null;

            // Get data for the DataGrid
            string GetData = @$"    SELECT *
                                    FROM {cbTables.SelectedItem.ToString().ToLower()}";

            dt = controller.RunQuery(GetData);
            DataGrid.DataSource = dt;
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMode.SelectedItem.ToString() == "View")
            {
                DataGrid.ReadOnly = true;
                DataGrid.AllowUserToDeleteRows = false;
            }
            else
            {
                DataGrid.ReadOnly = false;
                DataGrid.AllowUserToDeleteRows = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to make these changes?", "Confirm Changes", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                controller.CopyDTtoDB(dt);
                MessageBox.Show("Changes Saved!");
                ReturntoDashboard();
            }
        }
    }
}
