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
            pnNavigation = new Panel();
            btnSearch = new Button();
            btnInsNewRecord = new Button();
            btnVMTables = new Button();
            pnSoftwareInfo = new Panel();
            lblSoftwareVersion = new Label();
            pictureBox1 = new PictureBox();
            lblLoginInfo = new Label();
            lblMostPopularBooks = new Label();
            lblMostPopularAuthors = new Label();
            lblOverdueBooks = new Label();
            lblBooksDueForReturn = new Label();
            lvMostPopularBooks = new ListView();
            lvBooksDueForReturn = new ListView();
            lvOverdueBooks = new ListView();
            lvMostPopularAuthors = new ListView();
            pnNavigation.SuspendLayout();
            pnSoftwareInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnNavigation
            // 
            pnNavigation.BackColor = SystemColors.Window;
            pnNavigation.BorderStyle = BorderStyle.FixedSingle;
            pnNavigation.Controls.Add(btnSearch);
            pnNavigation.Controls.Add(btnInsNewRecord);
            pnNavigation.Controls.Add(btnVMTables);
            pnNavigation.Location = new Point(514, 12);
            pnNavigation.Name = "pnNavigation";
            pnNavigation.Size = new Size(234, 221);
            pnNavigation.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Control;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Image = Properties.Resources.SearchIcon;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(7, 80);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(220, 58);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Book/Loan Search";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnInsNewRecord
            // 
            btnInsNewRecord.BackColor = SystemColors.Control;
            btnInsNewRecord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsNewRecord.Image = Properties.Resources.NewRecordIcon;
            btnInsNewRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btnInsNewRecord.Location = new Point(7, 5);
            btnInsNewRecord.Name = "btnInsNewRecord";
            btnInsNewRecord.Size = new Size(220, 58);
            btnInsNewRecord.TabIndex = 1;
            btnInsNewRecord.Text = "Insert New Record";
            btnInsNewRecord.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInsNewRecord.UseVisualStyleBackColor = false;
            btnInsNewRecord.Click += btnInsNewRecord_Click;
            // 
            // btnVMTables
            // 
            btnVMTables.BackColor = SystemColors.Control;
            btnVMTables.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVMTables.Image = Properties.Resources.View_ModifyIcon;
            btnVMTables.ImageAlign = ContentAlignment.MiddleLeft;
            btnVMTables.Location = new Point(9, 155);
            btnVMTables.Name = "btnVMTables";
            btnVMTables.Size = new Size(220, 58);
            btnVMTables.TabIndex = 0;
            btnVMTables.Text = "View/Modify Records";
            btnVMTables.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVMTables.UseVisualStyleBackColor = false;
            btnVMTables.Click += btnVMTables_Click;
            // 
            // pnSoftwareInfo
            // 
            pnSoftwareInfo.BackColor = SystemColors.Window;
            pnSoftwareInfo.BorderStyle = BorderStyle.FixedSingle;
            pnSoftwareInfo.Controls.Add(lblSoftwareVersion);
            pnSoftwareInfo.Controls.Add(pictureBox1);
            pnSoftwareInfo.Controls.Add(lblLoginInfo);
            pnSoftwareInfo.Location = new Point(514, 256);
            pnSoftwareInfo.Name = "pnSoftwareInfo";
            pnSoftwareInfo.Size = new Size(234, 221);
            pnSoftwareInfo.TabIndex = 5;
            // 
            // lblSoftwareVersion
            // 
            lblSoftwareVersion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoftwareVersion.Location = new Point(2, 196);
            lblSoftwareVersion.Name = "lblSoftwareVersion";
            lblSoftwareVersion.Size = new Size(228, 23);
            lblSoftwareVersion.TabIndex = 2;
            lblSoftwareVersion.Text = "Software Version: 1.0.0";
            lblSoftwareVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(7, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 167);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLoginInfo
            // 
            lblLoginInfo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginInfo.Location = new Point(2, 173);
            lblLoginInfo.Name = "lblLoginInfo";
            lblLoginInfo.Size = new Size(228, 23);
            lblLoginInfo.TabIndex = 1;
            lblLoginInfo.Text = "Logged in as: <User>";
            lblLoginInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMostPopularBooks
            // 
            lblMostPopularBooks.BackColor = SystemColors.Window;
            lblMostPopularBooks.BorderStyle = BorderStyle.FixedSingle;
            lblMostPopularBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMostPopularBooks.Location = new Point(12, 12);
            lblMostPopularBooks.Name = "lblMostPopularBooks";
            lblMostPopularBooks.Size = new Size(234, 30);
            lblMostPopularBooks.TabIndex = 6;
            lblMostPopularBooks.Text = "Top 5 Most Popular Books";
            lblMostPopularBooks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMostPopularAuthors
            // 
            lblMostPopularAuthors.BackColor = SystemColors.Window;
            lblMostPopularAuthors.BorderStyle = BorderStyle.FixedSingle;
            lblMostPopularAuthors.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMostPopularAuthors.Location = new Point(12, 256);
            lblMostPopularAuthors.Name = "lblMostPopularAuthors";
            lblMostPopularAuthors.Size = new Size(234, 30);
            lblMostPopularAuthors.TabIndex = 7;
            lblMostPopularAuthors.Text = "Top 5 Most Popular Authors";
            lblMostPopularAuthors.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOverdueBooks
            // 
            lblOverdueBooks.BackColor = SystemColors.Window;
            lblOverdueBooks.BorderStyle = BorderStyle.FixedSingle;
            lblOverdueBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOverdueBooks.Location = new Point(263, 256);
            lblOverdueBooks.Name = "lblOverdueBooks";
            lblOverdueBooks.Size = new Size(234, 30);
            lblOverdueBooks.TabIndex = 8;
            lblOverdueBooks.Text = "Overdue Books";
            lblOverdueBooks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBooksDueForReturn
            // 
            lblBooksDueForReturn.BackColor = SystemColors.Window;
            lblBooksDueForReturn.BorderStyle = BorderStyle.FixedSingle;
            lblBooksDueForReturn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBooksDueForReturn.Location = new Point(263, 12);
            lblBooksDueForReturn.Name = "lblBooksDueForReturn";
            lblBooksDueForReturn.Size = new Size(234, 30);
            lblBooksDueForReturn.TabIndex = 9;
            lblBooksDueForReturn.Text = "Books Due for Return:";
            lblBooksDueForReturn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lvMostPopularBooks
            // 
            lvMostPopularBooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvMostPopularBooks.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvMostPopularBooks.Location = new Point(12, 45);
            lvMostPopularBooks.Name = "lvMostPopularBooks";
            lvMostPopularBooks.Size = new Size(234, 188);
            lvMostPopularBooks.TabIndex = 10;
            lvMostPopularBooks.UseCompatibleStateImageBehavior = false;
            lvMostPopularBooks.View = View.Details;
            // 
            // lvBooksDueForReturn
            // 
            lvBooksDueForReturn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvBooksDueForReturn.Location = new Point(263, 45);
            lvBooksDueForReturn.Name = "lvBooksDueForReturn";
            lvBooksDueForReturn.Size = new Size(234, 188);
            lvBooksDueForReturn.TabIndex = 11;
            lvBooksDueForReturn.UseCompatibleStateImageBehavior = false;
            lvBooksDueForReturn.View = View.Details;
            // 
            // lvOverdueBooks
            // 
            lvOverdueBooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvOverdueBooks.Location = new Point(263, 289);
            lvOverdueBooks.Name = "lvOverdueBooks";
            lvOverdueBooks.Size = new Size(234, 188);
            lvOverdueBooks.TabIndex = 12;
            lvOverdueBooks.UseCompatibleStateImageBehavior = false;
            lvOverdueBooks.View = View.Details;
            // 
            // lvMostPopularAuthors
            // 
            lvMostPopularAuthors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvMostPopularAuthors.Location = new Point(12, 289);
            lvMostPopularAuthors.Name = "lvMostPopularAuthors";
            lvMostPopularAuthors.Size = new Size(234, 188);
            lvMostPopularAuthors.TabIndex = 13;
            lvMostPopularAuthors.UseCompatibleStateImageBehavior = false;
            lvMostPopularAuthors.View = View.Details;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 490);
            Controls.Add(lvMostPopularAuthors);
            Controls.Add(lvOverdueBooks);
            Controls.Add(lvBooksDueForReturn);
            Controls.Add(lvMostPopularBooks);
            Controls.Add(lblBooksDueForReturn);
            Controls.Add(lblOverdueBooks);
            Controls.Add(lblMostPopularAuthors);
            Controls.Add(lblMostPopularBooks);
            Controls.Add(pnSoftwareInfo);
            Controls.Add(pnNavigation);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            Text = "Pontybryn Library - Dashboard";
            Load += Dashboard_Load;
            VisibleChanged += Dashboard_VisibleChanged;
            pnNavigation.ResumeLayout(false);
            pnSoftwareInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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