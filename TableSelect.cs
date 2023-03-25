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
    public partial class TableSelect : Form
    {
        // Used to determine which form to show after this
        string dbFunction;

        public TableSelect(string passedFunction)
        {
            InitializeComponent();

            dbFunction = passedFunction;
        }

        private void OpenNextForm(string tablename)
        {
            if (dbFunction == "ins")
            {
                InsertRecord frm = new InsertRecord(tablename);
                frm.Owner = this.Owner;

                frm.Show();
                this.Hide();
            }
            else if (dbFunction == "mod")
            {
                ViewEditRecords frm = new ViewEditRecords(tablename);
                frm.Owner = this.Owner;

                frm.Show();
                this.Hide();
            }
        }

        private void TableSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            OpenNextForm("author");
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            OpenNextForm("book");
        }

        private void btnCatagory_Click(object sender, EventArgs e)
        {
            OpenNextForm("catagory");
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            OpenNextForm("loan");
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            OpenNextForm("member");
        }
    }
}
