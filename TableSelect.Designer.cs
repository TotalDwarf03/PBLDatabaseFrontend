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
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCatagory = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.SystemColors.Window;
            this.lblHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(249, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(262, 40);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Please Select a Table...";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackColor = System.Drawing.SystemColors.Window;
            this.btnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAuthor.Location = new System.Drawing.Point(94, 89);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(136, 70);
            this.btnAuthor.TabIndex = 1;
            this.btnAuthor.Text = "Author";
            this.btnAuthor.UseVisualStyleBackColor = false;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.Window;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBook.Location = new System.Drawing.Point(94, 210);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(136, 70);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            // 
            // btnCatagory
            // 
            this.btnCatagory.BackColor = System.Drawing.SystemColors.Window;
            this.btnCatagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatagory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCatagory.Location = new System.Drawing.Point(94, 331);
            this.btnCatagory.Name = "btnCatagory";
            this.btnCatagory.Size = new System.Drawing.Size(136, 70);
            this.btnCatagory.TabIndex = 3;
            this.btnCatagory.Text = "Catagory";
            this.btnCatagory.UseVisualStyleBackColor = false;
            // 
            // btnLoan
            // 
            this.btnLoan.BackColor = System.Drawing.SystemColors.Window;
            this.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoan.Location = new System.Drawing.Point(312, 210);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(136, 70);
            this.btnLoan.TabIndex = 4;
            this.btnLoan.Text = "Loan";
            this.btnLoan.UseVisualStyleBackColor = false;
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.SystemColors.Window;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMember.Location = new System.Drawing.Point(530, 210);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(136, 70);
            this.btnMember.TabIndex = 5;
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = false;
            // 
            // TableSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 490);
            this.ControlBox = false;
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnLoan);
            this.Controls.Add(this.btnCatagory);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TableSelect";
            this.Text = "Please Select a Table...";
            this.ResumeLayout(false);

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