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

        SQLController controller = new SQLController();

        // List of Tables
        // {<Tablename>, <pnTableSelect x position>, <pnTableControls x position>}
        string[,] CurrentTableList = { { "Author", "0", "34" }, { "Member", "219", "253" }, { "Loan", "438", "472" }, { "Book", "657", "691" }, { "Category", "876", "910" }, };
        int CurrentTablePointer = 2;


        /// <summary>
        /// Clears all entered values for the current selected table
        /// </summary>
        private void ClearSelection()
        {
            switch (CurrentTablePointer)
            {
                // Author Panel Selected
                case 0:
                    tbAuthorFname.Clear();
                    tbAuthorSname.Clear();
                    break;

                // Member Panel Selected
                case 1:
                    tbMemberFname.Clear();
                    tbMemberSname.Clear();
                    tbMemberEmail.Clear();
                    tbMemberStreet.Clear();
                    tbMemberHouse.Clear();
                    break;

                // Loan Panel Selected
                case 2:
                    cbLoanBookID.SelectedIndex = -1;
                    cbLoanMemberID.SelectedIndex = -1;
                    tbLoanDateDue.Clear();
                    break;

                // Book Panel Selected
                case 3:
                    tbBookTitle.Clear();
                    cbBookAuthorID.SelectedIndex = -1;
                    cbBookCategoryID.SelectedIndex = -1;
                    break;

                // Catagory Panel Selected
                case 4:
                    tbCategory.Clear();
                    break;
            }
        }

        private void InsertRecord_Load(object sender, EventArgs e)
        {
            // Populate Book, Member, Author and Category Drop downs

            // Author
            string getAuthors = @"  SELECT
                                        authorid,
                                        fname || ' ' || sname AS authorname
                                    FROM author";

            DataTable dtAuthors = controller.RunQuery(getAuthors);

            cbBookAuthorID.DataSource = dtAuthors;
            cbBookAuthorID.DisplayMember = "authorname";
            cbBookAuthorID.ValueMember = "authorid";
            cbBookAuthorID.SelectedIndex = -1;

            // Book
            string getBooks = @"    SELECT
                                        bookid,
                                        title
                                    FROM book";

            DataTable dtBooks = controller.RunQuery(getBooks);

            cbLoanBookID.DataSource = dtBooks;
            cbLoanBookID.DisplayMember = "title";
            cbLoanBookID.ValueMember = "bookid";
            cbLoanBookID.SelectedIndex = -1;

            // Category
            string getCategory = @" SELECT
                                        categoryid,
                                        type
                                    FROM category";

            DataTable dtCategory = controller.RunQuery(getCategory);

            cbBookCategoryID.DataSource = dtCategory;
            cbBookCategoryID.DisplayMember = "type";
            cbBookCategoryID.ValueMember = "categoryid";
            cbBookCategoryID.SelectedIndex = -1;

            // Member
            string getMembers = @"  SELECT
                                        memberid,
                                        fname || ' ' || sname AS membername
                                    FROM member";

            DataTable dtMembers = controller.RunQuery(getMembers);

            cbLoanMemberID.DataSource = dtMembers;
            cbLoanMemberID.DisplayMember = "membername";
            cbLoanMemberID.ValueMember = "memberid";
            cbLoanMemberID.SelectedIndex = -1;
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

        private void btnLeft_Click(object sender, EventArgs e)
        {
            Panel oldPanel = (Panel)Controls.Find("pn" + CurrentTableList[CurrentTablePointer, 0].ToString(), true).SingleOrDefault();
            oldPanel.Enabled = false;

            ClearSelection();

            if (CurrentTablePointer != 0)
            {
                CurrentTablePointer--;
            }
            else
            {
                CurrentTablePointer = (CurrentTableList.Length / 3) - 1;
            }

            pnTableSelect.Location = new Point(Convert.ToInt16(CurrentTableList[CurrentTablePointer, 1]), 9);
            lblTableName.Text = CurrentTableList[CurrentTablePointer, 0].ToString();

            pnTableControls.Location = new Point(Convert.ToInt16(CurrentTableList[CurrentTablePointer, 2]), 434);

            Panel newPanel = (Panel)Controls.Find("pn" + CurrentTableList[CurrentTablePointer, 0].ToString(), true).SingleOrDefault();
            newPanel.Enabled = true;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Panel oldPanel = (Panel)Controls.Find("pn" + CurrentTableList[CurrentTablePointer, 0].ToString(), true).SingleOrDefault();
            oldPanel.Enabled = false;

            ClearSelection();

            if (CurrentTablePointer != (CurrentTableList.Length / 3) - 1)
            {
                CurrentTablePointer++;
            }
            else
            {
                CurrentTablePointer = 0;
            }

            pnTableSelect.Location = new Point(Convert.ToInt16(CurrentTableList[CurrentTablePointer, 1]), 9);
            lblTableName.Text = CurrentTableList[CurrentTablePointer, 0].ToString();

            pnTableControls.Location = new Point(Convert.ToInt16(CurrentTableList[CurrentTablePointer, 2]), 434);

            Panel newPanel = (Panel)Controls.Find("pn" + CurrentTableList[CurrentTablePointer, 0].ToString(), true).SingleOrDefault();
            newPanel.Enabled = true;
        }

    }
}
