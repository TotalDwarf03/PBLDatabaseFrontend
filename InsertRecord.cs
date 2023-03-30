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
    public partial class InsertRecord : Form
    {
        public InsertRecord()
        {
            InitializeComponent();
        }

        private void InsertRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();

            Form[] OwnedForms = this.Owner.OwnedForms;

            foreach (Form form in OwnedForms)
            {
                form.Dispose();
            }
        }

        // List of Tables
        // {<Tablename>, <x position>}
        string[,] CurrentTableList = { { "Author", "0" }, { "Member", "219" }, { "Loan", "438" }, { "Book", "657" }, { "Catagory", "876" }, };
        int CurrentTablePointer = 2;

        private void btnLeft_Click(object sender, EventArgs e)
        {
            Panel oldPanel = (Panel)this.Controls.Find("pn" + CurrentTableList[CurrentTablePointer, 0].ToString(), true).SingleOrDefault();
            oldPanel.Enabled = false;

            if (CurrentTablePointer != 0)
            {
                CurrentTablePointer--;
            }
            else
            {
                CurrentTablePointer = 4;
            }

            pnTableSelect.Location = new Point(Convert.ToInt16(CurrentTableList[CurrentTablePointer, 1]), 9);
            lblTableName.Text = CurrentTableList[CurrentTablePointer, 0].ToString();

            Panel newPanel = (Panel)this.Controls.Find("pn" + CurrentTableList[CurrentTablePointer, 0].ToString(), true).SingleOrDefault();
            newPanel.Enabled = true;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Panel oldPanel = (Panel)this.Controls.Find("pn" + CurrentTableList[CurrentTablePointer, 0].ToString(), true).SingleOrDefault();
            oldPanel.Enabled = false;

            if (CurrentTablePointer != 4)
            {
                CurrentTablePointer++;
            }
            else
            {
                CurrentTablePointer = 0;
            }

            pnTableSelect.Location = new Point(Convert.ToInt16(CurrentTableList[CurrentTablePointer, 1]), 9);
            lblTableName.Text = CurrentTableList[CurrentTablePointer, 0].ToString();

            Panel newPanel = (Panel)this.Controls.Find("pn" + CurrentTableList[CurrentTablePointer, 0].ToString(), true).SingleOrDefault();
            newPanel.Enabled = true;
        }
    }
}
