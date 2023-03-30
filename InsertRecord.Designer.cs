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
            pnMember = new Panel();
            pnLoan = new Panel();
            pnBook = new Panel();
            pnCatagory = new Panel();
            btnRight = new Button();
            pnTableSelect = new Panel();
            btnLeft = new Button();
            lblTableName = new Label();
            pnTableSelect.SuspendLayout();
            SuspendLayout();
            // 
            // pnAuthor
            // 
            pnAuthor.BackColor = SystemColors.Window;
            pnAuthor.BorderStyle = BorderStyle.FixedSingle;
            pnAuthor.Enabled = false;
            pnAuthor.Location = new Point(13, 70);
            pnAuthor.Name = "pnAuthor";
            pnAuthor.Size = new Size(200, 358);
            pnAuthor.TabIndex = 2;
            // 
            // pnMember
            // 
            pnMember.BackColor = SystemColors.Window;
            pnMember.BorderStyle = BorderStyle.FixedSingle;
            pnMember.Enabled = false;
            pnMember.Location = new Point(232, 70);
            pnMember.Name = "pnMember";
            pnMember.Size = new Size(200, 358);
            pnMember.TabIndex = 3;
            // 
            // pnLoan
            // 
            pnLoan.BackColor = SystemColors.Window;
            pnLoan.BorderStyle = BorderStyle.FixedSingle;
            pnLoan.Location = new Point(451, 70);
            pnLoan.Name = "pnLoan";
            pnLoan.Size = new Size(200, 358);
            pnLoan.TabIndex = 4;
            // 
            // pnBook
            // 
            pnBook.BackColor = SystemColors.Window;
            pnBook.BorderStyle = BorderStyle.FixedSingle;
            pnBook.Enabled = false;
            pnBook.Location = new Point(670, 70);
            pnBook.Name = "pnBook";
            pnBook.Size = new Size(200, 358);
            pnBook.TabIndex = 5;
            // 
            // pnCatagory
            // 
            pnCatagory.BackColor = SystemColors.Window;
            pnCatagory.BorderStyle = BorderStyle.FixedSingle;
            pnCatagory.Enabled = false;
            pnCatagory.Location = new Point(889, 70);
            pnCatagory.Name = "pnCatagory";
            pnCatagory.Size = new Size(200, 358);
            pnCatagory.TabIndex = 6;
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
            pnTableSelect.Location = new Point(438, 9);
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
            // InsertRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 490);
            Controls.Add(pnTableSelect);
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
    }
}