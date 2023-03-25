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
        string TableName;

        public InsertRecord(string passedTable)
        {
            InitializeComponent();

            TableName = passedTable;
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
    }
}
