using System.Data;

namespace PBLDatabaseFrontend
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        SQLController controller = new SQLController();

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string query = 
                    "SELECT fname " +
                    "FROM author";

            DataTable queryResults = controller.executeSQL(query);

            
        }
    }
}