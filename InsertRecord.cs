using System.Data;
using System.Diagnostics;

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
                    dtpDueDate.Value = DateTime.Today.AddDays(3);
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

        /// <summary>
        /// Populates the Insert Record Combo Boxes
        /// </summary>
        private void PopulateScreenData()
        {
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

        private void InsertRecord_Load(object sender, EventArgs e)
        {
            // Populate Book, Member, Author and Category Drop downs
            PopulateScreenData();

            // Setup Date Picker for Loan Due Date
            dtpDueDate.MinDate = DateTime.Today;
            dtpDueDate.CustomFormat = "yyyy-MM-dd";
            dtpDueDate.Format = DateTimePickerFormat.Custom;

            dtpDueDate.Value = DateTime.Today.AddDays(3);
        }

        private void InsertRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturntoDashboard();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSelection();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string InsertSQL = "SELECT 1";
            List<ParameterMap> Parameters = new List<ParameterMap>();

            switch (CurrentTablePointer)
            {
                // Author Panel Selected
                case 0:
                    InsertSQL = @"  INSERT INTO author
                                        (
                                            fname,
                                            sname
                                        )
                                    VALUES
                                        (
                                            @authorFname,
                                            @authorSname
                                        )
                                    ";

                    ParameterMap AuthorForename = new ParameterMap();
                    AuthorForename.parameterName = "authorFname";
                    AuthorForename.parameterValue = tbAuthorFname.Text;

                    ParameterMap AuthorSurname = new ParameterMap();
                    AuthorSurname.parameterName = "authorSname";
                    AuthorSurname.parameterValue = tbAuthorSname.Text;

                    Parameters.Add(AuthorForename);
                    Parameters.Add(AuthorSurname);

                    break;

                // Member Panel Selected
                case 1:
                    InsertSQL = @"  INSERT INTO member
                                        (
                                            fname,
                                            sname,
                                            email,
                                            streetname,
                                            houseidentifier
                                        )
                                    VALUES
                                        (
                                            @fname,
                                            @sname,
                                            @email,
                                            @streetname,
                                            @houseidentifier
                                        )
                                    ";

                    ParameterMap MemberForename = new ParameterMap();
                    MemberForename.parameterName = "fname";
                    MemberForename.parameterValue = tbMemberFname.Text;

                    ParameterMap MemberSurname = new ParameterMap();
                    MemberSurname.parameterName = "sname";
                    MemberSurname.parameterValue = tbMemberSname.Text;

                    ParameterMap MemberEmail = new ParameterMap();
                    MemberEmail.parameterName = "email";
                    MemberEmail.parameterValue = tbMemberEmail.Text;

                    ParameterMap MemberStreet = new ParameterMap();
                    MemberStreet.parameterName = "streetname";
                    MemberStreet.parameterValue = tbMemberStreet.Text;

                    ParameterMap MemberHouse = new ParameterMap();
                    MemberHouse.parameterName = "houseidentifier";
                    MemberHouse.parameterValue = tbMemberHouse.Text;

                    Parameters.Add(MemberForename);
                    Parameters.Add(MemberSurname);
                    Parameters.Add(MemberEmail);
                    Parameters.Add(MemberStreet);
                    Parameters.Add(MemberHouse);

                    break;

                // Loan Panel Selected
                case 2:
                    // Check if Member already has 3 loans
                    int MemberID = Convert.ToInt16(cbLoanMemberID.SelectedValue);
                    Debug.WriteLine(MemberID);
                    string LoanCount = @$"  SELECT
                                                COUNT(l.loanid) AS NoOfLoans
                                            FROM loan AS l
                                            WHERE l.memberid = {MemberID}
                                                AND IFNULL(l.datereturned, 1) = 1";

                    DataTable MemberLoans = controller.RunQuery(LoanCount);
                    DataRow row = MemberLoans.Rows[0];
                    int NoOfLoans = Convert.ToInt16(row[0]);

                    if (NoOfLoans >= 3)
                    {
                        DialogResult result = MessageBox.Show($"This Person already has {NoOfLoans} Loans. Do you want to continue?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            break;
                        }
                    }

                    InsertSQL = @"  INSERT INTO loan
                                        (
                                            bookid,
                                            memberid,
                                            dateout,
                                            datedue
                                        )
                                    VALUES
                                        (
                                            @bookid,
                                            @memberid,
                                            @dateout,
                                            @datedue
                                        )
                                    ";

                    ParameterMap LoanBookID = new ParameterMap();
                    LoanBookID.parameterName = "bookid";
                    LoanBookID.parameterValue = cbLoanBookID.SelectedValue ?? "";    // if SelectedValue is null, return "" so it fails the presence check

                    ParameterMap LoanMemberID = new ParameterMap();
                    LoanMemberID.parameterName = "memberid";
                    LoanMemberID.parameterValue = cbLoanMemberID.SelectedValue ?? "";

                    ParameterMap LoanDateOut = new ParameterMap();
                    LoanDateOut.parameterName = "dateout";
                    LoanDateOut.parameterValue = DateTime.Today.ToString("yyyy-MM-dd");

                    ParameterMap LoanDateDue = new ParameterMap();
                    LoanDateDue.parameterName = "datedue";
                    LoanDateDue.parameterValue = dtpDueDate.Value.ToString("yyyy-MM-dd");

                    Parameters.Add(LoanBookID);
                    Parameters.Add(LoanMemberID);
                    Parameters.Add(LoanDateOut);
                    Parameters.Add(LoanDateDue);

                    break;

                // Book Panel Selected
                case 3:
                    InsertSQL = @"  INSERT INTO book
                                        (
                                            title,
                                            authorid,
                                            categoryid
                                        )
                                    VALUES
                                        (
                                            @title,
                                            @authorid,
                                            @categoryid
                                        )
                                    ";

                    ParameterMap BookTitle = new ParameterMap();
                    BookTitle.parameterName = "title";
                    BookTitle.parameterValue = tbBookTitle.Text;

                    ParameterMap BookAuthorID = new ParameterMap();
                    BookAuthorID.parameterName = "authorid";
                    BookAuthorID.parameterValue = cbBookAuthorID.SelectedValue ?? "";

                    ParameterMap BookCategoryID = new ParameterMap();
                    BookCategoryID.parameterName = "categoryid";
                    BookCategoryID.parameterValue = cbBookCategoryID.SelectedValue ?? "";

                    Parameters.Add(BookTitle);
                    Parameters.Add(BookAuthorID);
                    Parameters.Add(BookCategoryID);

                    break;

                // Catagory Panel Selected
                case 4:
                    InsertSQL = @"  INSERT INTO category
                                        (
                                            type
                                        )
                                    VALUES
                                        (
                                            @type
                                        )
                                    ";

                    ParameterMap CategoryType = new ParameterMap();
                    CategoryType.parameterName = "type";
                    CategoryType.parameterValue = tbCategory.Text;

                    Parameters.Add(CategoryType);

                    break;
            }

            bool presenceCheckFailed = false;

            foreach (ParameterMap param in Parameters)
            {
                if (param.parameterValue == "")
                {
                    presenceCheckFailed = true;
                }
            }

            if (presenceCheckFailed)
            {
                MessageBox.Show("Please make sure all fields are filled.");
            }
            else
            {
                int changed = controller.RunNonQuery(InsertSQL, Parameters);

                if (changed > 0)
                {
                    MessageBox.Show("Record Added Successfully!");
                }

                ClearSelection();

                // Update Drop Downs
                PopulateScreenData();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReturntoDashboard();
        }
    }
}
