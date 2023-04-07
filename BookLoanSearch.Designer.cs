namespace PBLDatabaseFrontend
{
    partial class BookLoanSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookLoanSearch));
            ListView = new ListView();
            btnBack = new Button();
            cbTables = new ComboBox();
            lblTableSelect = new Label();
            lblSearchFilter = new Label();
            cbSearchFilter = new ComboBox();
            cbSearchItem = new ComboBox();
            btnClearSearch = new Button();
            btnLoanReturn = new Button();
            SuspendLayout();
            // 
            // ListView
            // 
            ListView.Dock = DockStyle.Left;
            ListView.FullRowSelect = true;
            ListView.Location = new Point(0, 0);
            ListView.MultiSelect = false;
            ListView.Name = "ListView";
            ListView.Size = new Size(462, 490);
            ListView.TabIndex = 0;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.View = View.Details;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(468, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 55);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cbTables
            // 
            cbTables.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTables.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTables.FormattingEnabled = true;
            cbTables.Location = new Point(568, 38);
            cbTables.Name = "cbTables";
            cbTables.Size = new Size(181, 29);
            cbTables.TabIndex = 8;
            cbTables.SelectedIndexChanged += cbTables_SelectedIndexChanged;
            // 
            // lblTableSelect
            // 
            lblTableSelect.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableSelect.Location = new Point(568, 12);
            lblTableSelect.Name = "lblTableSelect";
            lblTableSelect.Size = new Size(181, 23);
            lblTableSelect.TabIndex = 7;
            lblTableSelect.Text = "Select Table:";
            lblTableSelect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchFilter
            // 
            lblSearchFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearchFilter.Location = new Point(468, 95);
            lblSearchFilter.Name = "lblSearchFilter";
            lblSearchFilter.Size = new Size(139, 23);
            lblSearchFilter.TabIndex = 10;
            lblSearchFilter.Text = "Search By:";
            lblSearchFilter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbSearchFilter
            // 
            cbSearchFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSearchFilter.FormattingEnabled = true;
            cbSearchFilter.Location = new Point(610, 92);
            cbSearchFilter.Name = "cbSearchFilter";
            cbSearchFilter.Size = new Size(139, 29);
            cbSearchFilter.TabIndex = 11;
            cbSearchFilter.SelectedIndexChanged += cbSearchFilter_SelectedIndexChanged;
            // 
            // cbSearchItem
            // 
            cbSearchItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchItem.Enabled = false;
            cbSearchItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSearchItem.FormattingEnabled = true;
            cbSearchItem.Location = new Point(468, 144);
            cbSearchItem.Name = "cbSearchItem";
            cbSearchItem.Size = new Size(281, 29);
            cbSearchItem.TabIndex = 12;
            cbSearchItem.SelectedIndexChanged += cbSearchItem_SelectedIndexChanged;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearSearch.Location = new Point(645, 197);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(104, 55);
            btnClearSearch.TabIndex = 14;
            btnClearSearch.Text = "Clear Search";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // btnLoanReturn
            // 
            btnLoanReturn.Enabled = false;
            btnLoanReturn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoanReturn.Location = new Point(468, 197);
            btnLoanReturn.Name = "btnLoanReturn";
            btnLoanReturn.Size = new Size(124, 55);
            btnLoanReturn.TabIndex = 15;
            btnLoanReturn.Text = "Register Book Return";
            btnLoanReturn.UseVisualStyleBackColor = true;
            btnLoanReturn.Click += btnLoanReturn_Click;
            // 
            // BookLoanSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 490);
            Controls.Add(btnLoanReturn);
            Controls.Add(btnClearSearch);
            Controls.Add(cbSearchItem);
            Controls.Add(cbSearchFilter);
            Controls.Add(lblSearchFilter);
            Controls.Add(btnBack);
            Controls.Add(cbTables);
            Controls.Add(lblTableSelect);
            Controls.Add(ListView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookLoanSearch";
            Text = "Book/Loan Search";
            FormClosing += BookLoanSearch_FormClosing;
            Load += BookLoanSearch_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView ListView;
        private Button btnBack;
        private ComboBox cbTables;
        private Label lblTableSelect;
        private Label lblSearchFilter;
        private ComboBox cbSearchFilter;
        private ComboBox cbSearchItem;
        private Label lblSearchItem;
        private Button btnClearSearch;
        private Button btnLoanReturn;
    }
}