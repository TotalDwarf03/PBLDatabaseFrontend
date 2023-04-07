using System.Configuration.Internal;
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

        /// <summary>
        /// Populates a given listview using a given data table
        /// </summary>
        /// <param name="listView">The listview to be populated</param>
        /// <param name="dt">The data to be put into the listview</param>
        private void GenerateListview(ListView listView, DataTable dt)
        {
            listView.Clear();

            foreach (DataColumn col in dt.Columns)
            {
                listView.Columns.Add(col.ColumnName);
            }

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = row[0].ToString();

                for (int i = 1; i < listView.Columns.Count; i++)
                {
                    listItem.SubItems.Add(row[i].ToString());
                }
                listView.Items.Add(listItem);
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void PopulateScreenData()
        {
            // Most Popular Books
            string getMostPopularBooks = @" SELECT
                                            COUNT(l.loanid) AS Loans,
                                            b.title AS Title
                                        FROM loan AS l
                                        JOIN book AS b
                                            ON l.bookid = b.bookid
                                        GROUP BY b.title
                                        ORDER BY COUNT(l.loanid) DESC
                                        LIMIT 5";

            DataTable dtMostPopularBooks = controller.RunQuery(getMostPopularBooks);
            GenerateListview(lvMostPopularBooks, dtMostPopularBooks);

            // Most Popular Authors
            string getMostPopularAuthor = @"SELECT
                                            COUNT(l.loanid) AS Loans,
                                            a.fname || ' ' || a.sname AS Author
                                        FROM loan AS l
                                        JOIN book AS b
                                            ON l.bookid = b.bookid
                                        JOIN author AS a
                                            ON b.authorid = a.authorid
                                        GROUP BY a.fname || ' ' || a.sname
                                        ORDER BY COUNT(l.loanid) DESC
                                        LIMIT 5";

            DataTable dtMostPopularAuthor = controller.RunQuery(getMostPopularAuthor);
            GenerateListview(lvMostPopularAuthors, dtMostPopularAuthor);

            // Books Due for Return (in next 3 days)
            string getBooksDueForReturn = @"SELECT
                                            l.datedue AS DueDate,
                                            b.title AS Title,
                                            m.memberid AS MemberID,
                                            m.fname || ' ' || m.sname AS MemberName
                                        FROM loan l
                                        JOIN book b
                                            ON l.bookid = b.bookid
                                        JOIN member m
                                            ON l.memberid = m.memberid
                                        WHERE 
                                            IFNULL(l.datereturned, 1) = 1
                                            AND l.datedue BETWEEN DATE() AND DATE() + 3
                                        ORDER BY l.datedue";

            DataTable dtBooksDueForReturn = controller.RunQuery(getBooksDueForReturn);
            GenerateListview(lvBooksDueForReturn, dtBooksDueForReturn);

            lblBooksDueForReturn.Text = ($"Books Due for Return: {dtBooksDueForReturn.Rows.Count}");

            // Overdue Books
            string getOverdueBooks = @"SELECT
                                            l.datedue AS DueDate,
                                            b.title AS Title,
                                            m.memberid AS MemberID,
                                            m.fname || ' ' || m.sname AS MemberName
                                        FROM loan l
                                        JOIN book b
                                            ON l.bookid = b.bookid
                                        JOIN member m
                                            ON l.memberid = m.memberid
                                        WHERE 
                                            IFNULL(l.datereturned, 1) = 1
                                            AND l.datedue < DATE()
                                        ORDER BY l.datedue";

            DataTable dtOverdueBooks = controller.RunQuery(getOverdueBooks);
            GenerateListview(lvOverdueBooks, dtOverdueBooks);

            lblOverdueBooks.Text = ($"Overdue Books: {dtOverdueBooks.Rows.Count}");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Populate Dashboard Listboxes
            PopulateScreenData();
        }

        private void Dashboard_VisibleChanged(object sender, EventArgs e)
        {
            // Refresh Dashboard Data
            PopulateScreenData();
        }

        private void btnInsNewRecord_Click(object sender, EventArgs e)
        {
            InsertRecord frm = new InsertRecord();
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void btnVMTables_Click(object sender, EventArgs e)
        {
            ViewEditRecords frm = new ViewEditRecords();
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BookLoanSearch frm = new BookLoanSearch();
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }
    }
}