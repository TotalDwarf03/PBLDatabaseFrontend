namespace PBLDatabaseFrontend
{
    partial class TableSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableSelect));
            lblHeading = new Label();
            btnAuthor = new Button();
            btnBook = new Button();
            btnCatagory = new Button();
            btnLoan = new Button();
            btnMember = new Button();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.BackColor = SystemColors.Window;
            lblHeading.BorderStyle = BorderStyle.FixedSingle;
            lblHeading.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(249, 9);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(262, 40);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Please Select a Table...";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAuthor
            // 
            btnAuthor.BackColor = SystemColors.Window;
            btnAuthor.FlatStyle = FlatStyle.Flat;
            btnAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAuthor.Image = Properties.Resources.AuthorIcon;
            btnAuthor.ImageAlign = ContentAlignment.MiddleLeft;
            btnAuthor.Location = new Point(94, 89);
            btnAuthor.Name = "btnAuthor";
            btnAuthor.Size = new Size(136, 70);
            btnAuthor.TabIndex = 1;
            btnAuthor.Text = "Author";
            btnAuthor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAuthor.UseVisualStyleBackColor = false;
            // 
            // btnBook
            // 
            btnBook.BackColor = SystemColors.Window;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBook.Image = Properties.Resources.bookIcon;
            btnBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnBook.Location = new Point(94, 210);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(136, 70);
            btnBook.TabIndex = 2;
            btnBook.Text = "Book";
            btnBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBook.UseVisualStyleBackColor = false;
            // 
            // btnCatagory
            // 
            btnCatagory.BackColor = SystemColors.Window;
            btnCatagory.FlatStyle = FlatStyle.Flat;
            btnCatagory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCatagory.Image = Properties.Resources.catagoryIcon;
            btnCatagory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCatagory.Location = new Point(94, 331);
            btnCatagory.Name = "btnCatagory";
            btnCatagory.Size = new Size(136, 70);
            btnCatagory.TabIndex = 3;
            btnCatagory.Text = "Catagory";
            btnCatagory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCatagory.UseVisualStyleBackColor = false;
            // 
            // btnLoan
            // 
            btnLoan.BackColor = SystemColors.Window;
            btnLoan.FlatStyle = FlatStyle.Flat;
            btnLoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoan.Image = Properties.Resources.LoanIcon;
            btnLoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoan.Location = new Point(312, 210);
            btnLoan.Name = "btnLoan";
            btnLoan.Size = new Size(136, 70);
            btnLoan.TabIndex = 4;
            btnLoan.Text = "Loan";
            btnLoan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoan.UseVisualStyleBackColor = false;
            // 
            // btnMember
            // 
            btnMember.BackColor = SystemColors.Window;
            btnMember.FlatStyle = FlatStyle.Flat;
            btnMember.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMember.Image = Properties.Resources.memberIcon;
            btnMember.ImageAlign = ContentAlignment.MiddleLeft;
            btnMember.Location = new Point(530, 210);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(136, 70);
            btnMember.TabIndex = 5;
            btnMember.Text = "Member";
            btnMember.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMember.UseVisualStyleBackColor = false;
            // 
            // TableSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 490);
            Controls.Add(btnMember);
            Controls.Add(btnLoan);
            Controls.Add(btnCatagory);
            Controls.Add(btnBook);
            Controls.Add(btnAuthor);
            Controls.Add(lblHeading);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TableSelect";
            Text = "Please Select a Table...";
            FormClosing += TableSelect_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Label lblHeading;
        private Button btnAuthor;
        private Button btnBook;
        private Button btnCatagory;
        private Button btnLoan;
        private Button btnMember;
    }
}