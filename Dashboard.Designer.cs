namespace PBLDatabaseFrontend
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInsNewRecord = new System.Windows.Forms.Button();
            this.btnVMTables = new System.Windows.Forms.Button();
            this.pnSoftwareInfo = new System.Windows.Forms.Panel();
            this.lblSoftwareVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.lblMostPopularBooks = new System.Windows.Forms.Label();
            this.lblMostPopularAuthors = new System.Windows.Forms.Label();
            this.lblOverdueBooks = new System.Windows.Forms.Label();
            this.lblBooksDueForReturn = new System.Windows.Forms.Label();
            this.lvMostPopularBooks = new System.Windows.Forms.ListView();
            this.lvBooksDueForReturn = new System.Windows.Forms.ListView();
            this.lvOverdueBooks = new System.Windows.Forms.ListView();
            this.lvMostPopularAuthors = new System.Windows.Forms.ListView();
            this.pnNavigation.SuspendLayout();
            this.pnSoftwareInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnNavigation
            // 
            this.pnNavigation.BackColor = System.Drawing.SystemColors.Window;
            this.pnNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnNavigation.Controls.Add(this.btnSearch);
            this.pnNavigation.Controls.Add(this.btnInsNewRecord);
            this.pnNavigation.Controls.Add(this.btnVMTables);
            this.pnNavigation.Location = new System.Drawing.Point(514, 12);
            this.pnNavigation.Name = "pnNavigation";
            this.pnNavigation.Size = new System.Drawing.Size(234, 221);
            this.pnNavigation.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Image = global::PBLDatabaseFrontend.Properties.Resources.SearchIcon;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(7, 153);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(220, 58);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Book/Loan Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnInsNewRecord
            // 
            this.btnInsNewRecord.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsNewRecord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsNewRecord.Image = global::PBLDatabaseFrontend.Properties.Resources.NewRecordIcon;
            this.btnInsNewRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsNewRecord.Location = new System.Drawing.Point(7, 8);
            this.btnInsNewRecord.Name = "btnInsNewRecord";
            this.btnInsNewRecord.Size = new System.Drawing.Size(220, 58);
            this.btnInsNewRecord.TabIndex = 1;
            this.btnInsNewRecord.Text = "Insert New Record";
            this.btnInsNewRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsNewRecord.UseVisualStyleBackColor = false;
            // 
            // btnVMTables
            // 
            this.btnVMTables.BackColor = System.Drawing.SystemColors.Control;
            this.btnVMTables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVMTables.Image = global::PBLDatabaseFrontend.Properties.Resources.View_ModifyIcon;
            this.btnVMTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVMTables.Location = new System.Drawing.Point(7, 80);
            this.btnVMTables.Name = "btnVMTables";
            this.btnVMTables.Size = new System.Drawing.Size(220, 58);
            this.btnVMTables.TabIndex = 0;
            this.btnVMTables.Text = "View/Modify Tables";
            this.btnVMTables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVMTables.UseVisualStyleBackColor = false;
            // 
            // pnSoftwareInfo
            // 
            this.pnSoftwareInfo.BackColor = System.Drawing.SystemColors.Window;
            this.pnSoftwareInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSoftwareInfo.Controls.Add(this.lblSoftwareVersion);
            this.pnSoftwareInfo.Controls.Add(this.pictureBox1);
            this.pnSoftwareInfo.Controls.Add(this.lblLoginInfo);
            this.pnSoftwareInfo.Location = new System.Drawing.Point(514, 256);
            this.pnSoftwareInfo.Name = "pnSoftwareInfo";
            this.pnSoftwareInfo.Size = new System.Drawing.Size(234, 221);
            this.pnSoftwareInfo.TabIndex = 5;
            // 
            // lblSoftwareVersion
            // 
            this.lblSoftwareVersion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoftwareVersion.Location = new System.Drawing.Point(2, 196);
            this.lblSoftwareVersion.Name = "lblSoftwareVersion";
            this.lblSoftwareVersion.Size = new System.Drawing.Size(228, 23);
            this.lblSoftwareVersion.TabIndex = 2;
            this.lblSoftwareVersion.Text = "Software Version: 1.0.0";
            this.lblSoftwareVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PBLDatabaseFrontend.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginInfo.Location = new System.Drawing.Point(2, 173);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(228, 23);
            this.lblLoginInfo.TabIndex = 1;
            this.lblLoginInfo.Text = "Logged in as: <User>";
            this.lblLoginInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMostPopularBooks
            // 
            this.lblMostPopularBooks.BackColor = System.Drawing.SystemColors.Window;
            this.lblMostPopularBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostPopularBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMostPopularBooks.Location = new System.Drawing.Point(12, 12);
            this.lblMostPopularBooks.Name = "lblMostPopularBooks";
            this.lblMostPopularBooks.Size = new System.Drawing.Size(234, 30);
            this.lblMostPopularBooks.TabIndex = 6;
            this.lblMostPopularBooks.Text = "Top 5 Most Popular Books";
            this.lblMostPopularBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMostPopularAuthors
            // 
            this.lblMostPopularAuthors.BackColor = System.Drawing.SystemColors.Window;
            this.lblMostPopularAuthors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostPopularAuthors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMostPopularAuthors.Location = new System.Drawing.Point(12, 256);
            this.lblMostPopularAuthors.Name = "lblMostPopularAuthors";
            this.lblMostPopularAuthors.Size = new System.Drawing.Size(234, 30);
            this.lblMostPopularAuthors.TabIndex = 7;
            this.lblMostPopularAuthors.Text = "Top 5 Most Popular Authors";
            this.lblMostPopularAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverdueBooks
            // 
            this.lblOverdueBooks.BackColor = System.Drawing.SystemColors.Window;
            this.lblOverdueBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOverdueBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOverdueBooks.Location = new System.Drawing.Point(263, 256);
            this.lblOverdueBooks.Name = "lblOverdueBooks";
            this.lblOverdueBooks.Size = new System.Drawing.Size(234, 30);
            this.lblOverdueBooks.TabIndex = 8;
            this.lblOverdueBooks.Text = "Overdue Books";
            this.lblOverdueBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBooksDueForReturn
            // 
            this.lblBooksDueForReturn.BackColor = System.Drawing.SystemColors.Window;
            this.lblBooksDueForReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBooksDueForReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBooksDueForReturn.Location = new System.Drawing.Point(263, 12);
            this.lblBooksDueForReturn.Name = "lblBooksDueForReturn";
            this.lblBooksDueForReturn.Size = new System.Drawing.Size(234, 30);
            this.lblBooksDueForReturn.TabIndex = 9;
            this.lblBooksDueForReturn.Text = "Books Due For Return";
            this.lblBooksDueForReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvMostPopularBooks
            // 
            this.lvMostPopularBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvMostPopularBooks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMostPopularBooks.Location = new System.Drawing.Point(12, 45);
            this.lvMostPopularBooks.Name = "lvMostPopularBooks";
            this.lvMostPopularBooks.Size = new System.Drawing.Size(234, 188);
            this.lvMostPopularBooks.TabIndex = 10;
            this.lvMostPopularBooks.UseCompatibleStateImageBehavior = false;
            this.lvMostPopularBooks.View = System.Windows.Forms.View.Details;
            // 
            // lvBooksDueForReturn
            // 
            this.lvBooksDueForReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvBooksDueForReturn.Location = new System.Drawing.Point(263, 45);
            this.lvBooksDueForReturn.Name = "lvBooksDueForReturn";
            this.lvBooksDueForReturn.Size = new System.Drawing.Size(234, 188);
            this.lvBooksDueForReturn.TabIndex = 11;
            this.lvBooksDueForReturn.UseCompatibleStateImageBehavior = false;
            this.lvBooksDueForReturn.View = System.Windows.Forms.View.Details;
            // 
            // lvOverdueBooks
            // 
            this.lvOverdueBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvOverdueBooks.Location = new System.Drawing.Point(263, 289);
            this.lvOverdueBooks.Name = "lvOverdueBooks";
            this.lvOverdueBooks.Size = new System.Drawing.Size(234, 188);
            this.lvOverdueBooks.TabIndex = 12;
            this.lvOverdueBooks.UseCompatibleStateImageBehavior = false;
            this.lvOverdueBooks.View = System.Windows.Forms.View.Details;
            // 
            // lvMostPopularAuthors
            // 
            this.lvMostPopularAuthors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvMostPopularAuthors.Location = new System.Drawing.Point(12, 289);
            this.lvMostPopularAuthors.Name = "lvMostPopularAuthors";
            this.lvMostPopularAuthors.Size = new System.Drawing.Size(234, 188);
            this.lvMostPopularAuthors.TabIndex = 13;
            this.lvMostPopularAuthors.UseCompatibleStateImageBehavior = false;
            this.lvMostPopularAuthors.View = System.Windows.Forms.View.Details;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 490);
            this.Controls.Add(this.lvMostPopularAuthors);
            this.Controls.Add(this.lvOverdueBooks);
            this.Controls.Add(this.lvBooksDueForReturn);
            this.Controls.Add(this.lvMostPopularBooks);
            this.Controls.Add(this.lblBooksDueForReturn);
            this.Controls.Add(this.lblOverdueBooks);
            this.Controls.Add(this.lblMostPopularAuthors);
            this.Controls.Add(this.lblMostPopularBooks);
            this.Controls.Add(this.pnSoftwareInfo);
            this.Controls.Add(this.pnNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Pontybryn Library - Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnNavigation.ResumeLayout(false);
            this.pnSoftwareInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnNavigation;
        private Panel pnSoftwareInfo;
        private Label lblSoftwareVersion;
        private Label lblLoginInfo;
        private PictureBox pictureBox1;
        private Label lblMostPopularBooks;
        private Label lblMostPopularAuthors;
        private Label lblOverdueBooks;
        private Label lblBooksDueForReturn;
        private ListView lvMostPopularBooks;
        private ListView lvBooksDueForReturn;
        private ListView lvOverdueBooks;
        private ListView lvMostPopularAuthors;
        private Button btnSearch;
        private Button btnInsNewRecord;
        private Button btnVMTables;
    }
}