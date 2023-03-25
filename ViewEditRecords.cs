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
        string TableName;

        public ViewEditRecords(string passedTable)
        {
            InitializeComponent();
            TableName = passedTable;
        }
    }
}
