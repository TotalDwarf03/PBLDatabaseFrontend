using PBLDatabaseFrontend.Properties;
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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        int TickCount = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TickCount < 5)
            {
                TickCount++;
                LoadingBar.PerformStep();
            }
            else
            {
                this.Close();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SQLController controller = new SQLController();
            controller.InitialiseDatabase();
        }
    }
}
