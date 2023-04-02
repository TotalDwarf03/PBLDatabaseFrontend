namespace PBLDatabaseFrontend
{
    partial class InsertRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertRecord));
            pnAuthor = new Panel();
            tbAuthorSname = new TextBox();
            lblAuthorSname = new Label();
            tbAuthorFname = new TextBox();
            lblAuthorFname = new Label();
            pnMember = new Panel();
            tbMemberHouse = new TextBox();
            lblMemberHouse = new Label();
            tbMemberStreet = new TextBox();
            tbMemberEmail = new TextBox();
            lblMemberStreet = new Label();
            lblMemberEmail = new Label();
            tbMemberSname = new TextBox();
            tbMemberFname = new TextBox();
            lblMemberSname = new Label();
            lblMemberFname = new Label();
            pnLoan = new Panel();
            cbLoanMemberID = new ComboBox();
            lblLoanBookID = new Label();
            tbLoanDateDue = new TextBox();
            lblLoanMemberID = new Label();
            tbLoanDateOut = new TextBox();
            cbLoanBookID = new ComboBox();
            lblLoanDateDue = new Label();
            lblLoanDateOut = new Label();
            pnBook = new Panel();
            cbBookCatagoryID = new ComboBox();
            lblBookTitle = new Label();
            lblBookCatagoryID = new Label();
            tbBookTitle = new TextBox();
            cbBookAuthorID = new ComboBox();
            lblBookAuthorID = new Label();
            pnCatagory = new Panel();
            lblCatagory = new Label();
            tbCatagory = new TextBox();
            btnRight = new Button();
            pnTableSelect = new Panel();
            btnLeft = new Button();
            lblLoan = new Label();
            lblTableName = new Label();
            lblMember = new Label();
            lblAuthor = new Label();
            lblBook = new Label();
            lblCatagoryTitle = new Label();
            pnAuthor.SuspendLayout();
            pnMember.SuspendLayout();
            pnLoan.SuspendLayout();
            pnBook.SuspendLayout();
            pnCatagory.SuspendLayout();
            pnTableSelect.SuspendLayout();
            SuspendLayout();
            // 
            // pnAuthor
            // 
            pnAuthor.BackColor = SystemColors.Window;
            pnAuthor.BorderStyle = BorderStyle.FixedSingle;
            pnAuthor.Controls.Add(tbAuthorSname);
            pnAuthor.Controls.Add(lblAuthorSname);
            pnAuthor.Controls.Add(tbAuthorFname);
            pnAuthor.Controls.Add(lblAuthorFname);
            pnAuthor.Enabled = false;
            pnAuthor.Location = new Point(13, 70);
            pnAuthor.Name = "pnAuthor";
            pnAuthor.Size = new Size(200, 358);
            pnAuthor.TabIndex = 2;
            // 
            // tbAuthorSname
            // 
            tbAuthorSname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbAuthorSname.Location = new Point(3, 79);
            tbAuthorSname.Name = "tbAuthorSname";
            tbAuthorSname.Size = new Size(192, 29);
            tbAuthorSname.TabIndex = 3;
            // 
            // lblAuthorSname
            // 
            lblAuthorSname.AutoSize = true;
            lblAuthorSname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAuthorSname.Location = new Point(3, 55);
            lblAuthorSname.Name = "lblAuthorSname";
            lblAuthorSname.Size = new Size(82, 21);
            lblAuthorSname.TabIndex = 2;
            lblAuthorSname.Text = "Surname:";
            // 
            // tbAuthorFname
            // 
            tbAuthorFname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbAuthorFname.Location = new Point(3, 23);
            tbAuthorFname.Name = "tbAuthorFname";
            tbAuthorFname.Size = new Size(192, 29);
            tbAuthorFname.TabIndex = 1;
            // 
            // lblAuthorFname
            // 
            lblAuthorFname.AutoSize = true;
            lblAuthorFname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAuthorFname.Location = new Point(3, -1);
            lblAuthorFname.Name = "lblAuthorFname";
            lblAuthorFname.Size = new Size(90, 21);
            lblAuthorFname.TabIndex = 0;
            lblAuthorFname.Text = "Forename:";
            // 
            // pnMember
            // 
            pnMember.BackColor = SystemColors.Window;
            pnMember.BorderStyle = BorderStyle.FixedSingle;
            pnMember.Controls.Add(tbMemberHouse);
            pnMember.Controls.Add(lblMemberHouse);
            pnMember.Controls.Add(tbMemberStreet);
            pnMember.Controls.Add(tbMemberEmail);
            pnMember.Controls.Add(lblMemberStreet);
            pnMember.Controls.Add(lblMemberEmail);
            pnMember.Controls.Add(tbMemberSname);
            pnMember.Controls.Add(tbMemberFname);
            pnMember.Controls.Add(lblMemberSname);
            pnMember.Controls.Add(lblMemberFname);
            pnMember.Enabled = false;
            pnMember.Location = new Point(232, 70);
            pnMember.Name = "pnMember";
            pnMember.Size = new Size(200, 358);
            pnMember.TabIndex = 3;
            // 
            // tbMemberHouse
            // 
            tbMemberHouse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbMemberHouse.Location = new Point(3, 247);
            tbMemberHouse.Name = "tbMemberHouse";
            tbMemberHouse.Size = new Size(192, 29);
            tbMemberHouse.TabIndex = 13;
            // 
            // lblMemberHouse
            // 
            lblMemberHouse.AutoSize = true;
            lblMemberHouse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMemberHouse.Location = new Point(3, 223);
            lblMemberHouse.Name = "lblMemberHouse";
            lblMemberHouse.Size = new Size(138, 21);
            lblMemberHouse.TabIndex = 12;
            lblMemberHouse.Text = "House Identifier:";
            // 
            // tbMemberStreet
            // 
            tbMemberStreet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbMemberStreet.Location = new Point(3, 191);
            tbMemberStreet.Name = "tbMemberStreet";
            tbMemberStreet.Size = new Size(192, 29);
            tbMemberStreet.TabIndex = 11;
            // 
            // tbMemberEmail
            // 
            tbMemberEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbMemberEmail.Location = new Point(3, 135);
            tbMemberEmail.Name = "tbMemberEmail";
            tbMemberEmail.Size = new Size(192, 29);
            tbMemberEmail.TabIndex = 9;
            // 
            // lblMemberStreet
            // 
            lblMemberStreet.AutoSize = true;
            lblMemberStreet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMemberStreet.Location = new Point(3, 167);
            lblMemberStreet.Name = "lblMemberStreet";
            lblMemberStreet.Size = new Size(109, 21);
            lblMemberStreet.TabIndex = 10;
            lblMemberStreet.Text = "Street Name:";
            // 
            // lblMemberEmail
            // 
            lblMemberEmail.AutoSize = true;
            lblMemberEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMemberEmail.Location = new Point(3, 111);
            lblMemberEmail.Name = "lblMemberEmail";
            lblMemberEmail.Size = new Size(57, 21);
            lblMemberEmail.TabIndex = 8;
            lblMemberEmail.Text = "Email:";
            // 
            // tbMemberSname
            // 
            tbMemberSname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbMemberSname.Location = new Point(3, 80);
            tbMemberSname.Name = "tbMemberSname";
            tbMemberSname.Size = new Size(192, 29);
            tbMemberSname.TabIndex = 7;
            // 
            // tbMemberFname
            // 
            tbMemberFname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbMemberFname.Location = new Point(3, 24);
            tbMemberFname.Name = "tbMemberFname";
            tbMemberFname.Size = new Size(192, 29);
            tbMemberFname.TabIndex = 5;
            // 
            // lblMemberSname
            // 
            lblMemberSname.AutoSize = true;
            lblMemberSname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMemberSname.Location = new Point(3, 56);
            lblMemberSname.Name = "lblMemberSname";
            lblMemberSname.Size = new Size(82, 21);
            lblMemberSname.TabIndex = 6;
            lblMemberSname.Text = "Surname:";
            // 
            // lblMemberFname
            // 
            lblMemberFname.AutoSize = true;
            lblMemberFname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMemberFname.Location = new Point(3, 0);
            lblMemberFname.Name = "lblMemberFname";
            lblMemberFname.Size = new Size(90, 21);
            lblMemberFname.TabIndex = 4;
            lblMemberFname.Text = "Forename:";
            // 
            // pnLoan
            // 
            pnLoan.BackColor = SystemColors.Window;
            pnLoan.BorderStyle = BorderStyle.FixedSingle;
            pnLoan.Controls.Add(cbLoanMemberID);
            pnLoan.Controls.Add(lblLoanBookID);
            pnLoan.Controls.Add(tbLoanDateDue);
            pnLoan.Controls.Add(lblLoanMemberID);
            pnLoan.Controls.Add(tbLoanDateOut);
            pnLoan.Controls.Add(cbLoanBookID);
            pnLoan.Controls.Add(lblLoanDateDue);
            pnLoan.Controls.Add(lblLoanDateOut);
            pnLoan.Location = new Point(451, 70);
            pnLoan.Name = "pnLoan";
            pnLoan.Size = new Size(200, 358);
            pnLoan.TabIndex = 4;
            // 
            // cbLoanMemberID
            // 
            cbLoanMemberID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbLoanMemberID.FormattingEnabled = true;
            cbLoanMemberID.Location = new Point(3, 78);
            cbLoanMemberID.Name = "cbLoanMemberID";
            cbLoanMemberID.Size = new Size(192, 29);
            cbLoanMemberID.TabIndex = 13;
            // 
            // lblLoanBookID
            // 
            lblLoanBookID.AutoSize = true;
            lblLoanBookID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoanBookID.Location = new Point(3, 0);
            lblLoanBookID.Name = "lblLoanBookID";
            lblLoanBookID.Size = new Size(54, 21);
            lblLoanBookID.TabIndex = 10;
            lblLoanBookID.Text = "Book:";
            // 
            // tbLoanDateDue
            // 
            tbLoanDateDue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbLoanDateDue.Location = new Point(3, 191);
            tbLoanDateDue.Name = "tbLoanDateDue";
            tbLoanDateDue.Size = new Size(192, 29);
            tbLoanDateDue.TabIndex = 17;
            // 
            // lblLoanMemberID
            // 
            lblLoanMemberID.AutoSize = true;
            lblLoanMemberID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoanMemberID.Location = new Point(3, 55);
            lblLoanMemberID.Name = "lblLoanMemberID";
            lblLoanMemberID.Size = new Size(79, 21);
            lblLoanMemberID.TabIndex = 12;
            lblLoanMemberID.Text = "Member:";
            // 
            // tbLoanDateOut
            // 
            tbLoanDateOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbLoanDateOut.Location = new Point(3, 135);
            tbLoanDateOut.Name = "tbLoanDateOut";
            tbLoanDateOut.Size = new Size(192, 29);
            tbLoanDateOut.TabIndex = 15;
            // 
            // cbLoanBookID
            // 
            cbLoanBookID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbLoanBookID.FormattingEnabled = true;
            cbLoanBookID.Location = new Point(3, 23);
            cbLoanBookID.Name = "cbLoanBookID";
            cbLoanBookID.Size = new Size(192, 29);
            cbLoanBookID.TabIndex = 11;
            // 
            // lblLoanDateDue
            // 
            lblLoanDateDue.AutoSize = true;
            lblLoanDateDue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoanDateDue.Location = new Point(3, 167);
            lblLoanDateDue.Name = "lblLoanDateDue";
            lblLoanDateDue.Size = new Size(82, 21);
            lblLoanDateDue.TabIndex = 16;
            lblLoanDateDue.Text = "Surname:";
            // 
            // lblLoanDateOut
            // 
            lblLoanDateOut.AutoSize = true;
            lblLoanDateOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoanDateOut.Location = new Point(3, 111);
            lblLoanDateOut.Name = "lblLoanDateOut";
            lblLoanDateOut.Size = new Size(90, 21);
            lblLoanDateOut.TabIndex = 14;
            lblLoanDateOut.Text = "Forename:";
            // 
            // pnBook
            // 
            pnBook.BackColor = SystemColors.Window;
            pnBook.BorderStyle = BorderStyle.FixedSingle;
            pnBook.Controls.Add(cbBookCatagoryID);
            pnBook.Controls.Add(lblBookTitle);
            pnBook.Controls.Add(lblBookCatagoryID);
            pnBook.Controls.Add(tbBookTitle);
            pnBook.Controls.Add(cbBookAuthorID);
            pnBook.Controls.Add(lblBookAuthorID);
            pnBook.Enabled = false;
            pnBook.Location = new Point(670, 70);
            pnBook.Name = "pnBook";
            pnBook.Size = new Size(200, 358);
            pnBook.TabIndex = 5;
            // 
            // cbBookCatagoryID
            // 
            cbBookCatagoryID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbBookCatagoryID.FormattingEnabled = true;
            cbBookCatagoryID.Location = new Point(3, 134);
            cbBookCatagoryID.Name = "cbBookCatagoryID";
            cbBookCatagoryID.Size = new Size(192, 29);
            cbBookCatagoryID.TabIndex = 9;
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookTitle.Location = new Point(3, 0);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(48, 21);
            lblBookTitle.TabIndex = 4;
            lblBookTitle.Text = "Title:";
            // 
            // lblBookCatagoryID
            // 
            lblBookCatagoryID.AutoSize = true;
            lblBookCatagoryID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookCatagoryID.Location = new Point(3, 111);
            lblBookCatagoryID.Name = "lblBookCatagoryID";
            lblBookCatagoryID.Size = new Size(84, 21);
            lblBookCatagoryID.TabIndex = 8;
            lblBookCatagoryID.Text = "Catagory:";
            // 
            // tbBookTitle
            // 
            tbBookTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBookTitle.Location = new Point(3, 24);
            tbBookTitle.Name = "tbBookTitle";
            tbBookTitle.Size = new Size(192, 29);
            tbBookTitle.TabIndex = 5;
            // 
            // cbBookAuthorID
            // 
            cbBookAuthorID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbBookAuthorID.FormattingEnabled = true;
            cbBookAuthorID.Location = new Point(3, 79);
            cbBookAuthorID.Name = "cbBookAuthorID";
            cbBookAuthorID.Size = new Size(192, 29);
            cbBookAuthorID.TabIndex = 7;
            // 
            // lblBookAuthorID
            // 
            lblBookAuthorID.AutoSize = true;
            lblBookAuthorID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookAuthorID.Location = new Point(3, 56);
            lblBookAuthorID.Name = "lblBookAuthorID";
            lblBookAuthorID.Size = new Size(68, 21);
            lblBookAuthorID.TabIndex = 6;
            lblBookAuthorID.Text = "Author:";
            // 
            // pnCatagory
            // 
            pnCatagory.BackColor = SystemColors.Window;
            pnCatagory.BorderStyle = BorderStyle.FixedSingle;
            pnCatagory.Controls.Add(lblCatagory);
            pnCatagory.Controls.Add(tbCatagory);
            pnCatagory.Enabled = false;
            pnCatagory.Location = new Point(889, 70);
            pnCatagory.Name = "pnCatagory";
            pnCatagory.Size = new Size(200, 358);
            pnCatagory.TabIndex = 6;
            // 
            // lblCatagory
            // 
            lblCatagory.AutoSize = true;
            lblCatagory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCatagory.Location = new Point(3, -1);
            lblCatagory.Name = "lblCatagory";
            lblCatagory.Size = new Size(84, 21);
            lblCatagory.TabIndex = 10;
            lblCatagory.Text = "Catagory:";
            // 
            // tbCatagory
            // 
            tbCatagory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbCatagory.Location = new Point(3, 23);
            tbCatagory.Name = "tbCatagory";
            tbCatagory.Size = new Size(192, 29);
            tbCatagory.TabIndex = 11;
            // 
            // btnRight
            // 
            btnRight.BackColor = SystemColors.Window;
            btnRight.FlatAppearance.BorderSize = 0;
            btnRight.FlatStyle = FlatStyle.Flat;
            btnRight.Image = Properties.Resources.right_arrow;
            btnRight.Location = new Point(187, 1);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(35, 50);
            btnRight.TabIndex = 8;
            btnRight.UseVisualStyleBackColor = false;
            btnRight.Click += btnRight_Click;
            // 
            // pnTableSelect
            // 
            pnTableSelect.BackColor = SystemColors.Window;
            pnTableSelect.BorderStyle = BorderStyle.FixedSingle;
            pnTableSelect.Controls.Add(btnLeft);
            pnTableSelect.Controls.Add(lblTableName);
            pnTableSelect.Controls.Add(btnRight);
            pnTableSelect.Location = new Point(438, 6);
            pnTableSelect.Name = "pnTableSelect";
            pnTableSelect.Size = new Size(227, 55);
            pnTableSelect.TabIndex = 9;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = SystemColors.Window;
            btnLeft.FlatAppearance.BorderSize = 0;
            btnLeft.FlatStyle = FlatStyle.Flat;
            btnLeft.Image = Properties.Resources.left_arrow;
            btnLeft.Location = new Point(2, 1);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(35, 50);
            btnLeft.TabIndex = 10;
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // lblLoan
            // 
            lblLoan.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoan.Location = new Point(482, 11);
            lblLoan.Name = "lblLoan";
            lblLoan.Size = new Size(138, 50);
            lblLoan.TabIndex = 15;
            lblLoan.Text = "Loan";
            lblLoan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTableName
            // 
            lblTableName.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableName.Location = new Point(43, 1);
            lblTableName.Name = "lblTableName";
            lblTableName.Size = new Size(138, 50);
            lblTableName.TabIndex = 9;
            lblTableName.Text = "Loan";
            lblTableName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMember
            // 
            lblMember.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMember.Location = new Point(263, 11);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(138, 50);
            lblMember.TabIndex = 11;
            lblMember.Text = "Member";
            lblMember.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            lblAuthor.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAuthor.Location = new Point(44, 11);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(138, 50);
            lblAuthor.TabIndex = 12;
            lblAuthor.Text = "Author";
            lblAuthor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBook
            // 
            lblBook.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBook.Location = new Point(701, 11);
            lblBook.Name = "lblBook";
            lblBook.Size = new Size(138, 50);
            lblBook.TabIndex = 13;
            lblBook.Text = "Book";
            lblBook.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCatagoryTitle
            // 
            lblCatagoryTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCatagoryTitle.Location = new Point(920, 11);
            lblCatagoryTitle.Name = "lblCatagoryTitle";
            lblCatagoryTitle.Size = new Size(138, 50);
            lblCatagoryTitle.TabIndex = 14;
            lblCatagoryTitle.Text = "Catagory";
            lblCatagoryTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InsertRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 490);
            Controls.Add(pnTableSelect);
            Controls.Add(lblLoan);
            Controls.Add(lblCatagoryTitle);
            Controls.Add(lblBook);
            Controls.Add(lblAuthor);
            Controls.Add(lblMember);
            Controls.Add(pnCatagory);
            Controls.Add(pnBook);
            Controls.Add(pnLoan);
            Controls.Add(pnMember);
            Controls.Add(pnAuthor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InsertRecord";
            Text = "Insert New Record";
            FormClosing += InsertRecord_FormClosing;
            pnAuthor.ResumeLayout(false);
            pnAuthor.PerformLayout();
            pnMember.ResumeLayout(false);
            pnMember.PerformLayout();
            pnLoan.ResumeLayout(false);
            pnLoan.PerformLayout();
            pnBook.ResumeLayout(false);
            pnBook.PerformLayout();
            pnCatagory.ResumeLayout(false);
            pnCatagory.PerformLayout();
            pnTableSelect.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel pnAuthor;
        private Panel pnMember;
        private Panel pnLoan;
        private Panel pnBook;
        private Panel pnCatagory;
        private Button button1;
        private Button btnRight;
        private Panel pnTableSelect;
        private Label lblTableName;
        private Button btnLeft;
        private TextBox tbAuthorSname;
        private Label lblAuthorSname;
        private TextBox tbAuthorFname;
        private Label lblAuthorFname;
        private TextBox tbMemberHouse;
        private Label lblMemberHouse;
        private TextBox tbMemberStreet;
        private TextBox tbMemberEmail;
        private Label lblMemberStreet;
        private Label lblMemberEmail;
        private TextBox tbMemberSname;
        private TextBox tbMemberFname;
        private Label lblMemberSname;
        private Label lblMemberFname;
        private ComboBox cbLoanMemberID;
        private Label lblLoanBookID;
        private TextBox tbLoanDateDue;
        private Label lblLoanMemberID;
        private TextBox tbLoanDateOut;
        private ComboBox cbLoanBookID;
        private Label lblLoanDateDue;
        private Label lblLoanDateOut;
        private ComboBox cbBookCatagoryID;
        private Label lblBookTitle;
        private Label lblBookCatagoryID;
        private TextBox tbBookTitle;
        private ComboBox cbBookAuthorID;
        private Label lblBookAuthorID;
        private Label lblCatagory;
        private TextBox tbCatagory;
        private Label lblLoan;
        private Label lblMember;
        private Label lblAuthor;
        private Label lblBook;
        private Label lblCatagoryTitle;
    }
}