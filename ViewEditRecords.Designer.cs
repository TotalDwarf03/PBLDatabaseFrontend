namespace PBLDatabaseFrontend
{
    partial class ViewEditRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEditRecords));
            DataGrid = new DataGridView();
            lblTableSelect = new Label();
            cbTables = new ComboBox();
            lblMode = new Label();
            cbMode = new ComboBox();
            btnSave = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            SuspendLayout();
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Dock = DockStyle.Bottom;
            DataGrid.EditMode = DataGridViewEditMode.EditOnKeystroke;
            DataGrid.Location = new Point(0, 70);
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            DataGrid.RowTemplate.Height = 25;
            DataGrid.Size = new Size(761, 420);
            DataGrid.TabIndex = 0;
            // 
            // lblTableSelect
            // 
            lblTableSelect.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableSelect.Location = new Point(83, 9);
            lblTableSelect.Name = "lblTableSelect";
            lblTableSelect.Size = new Size(181, 23);
            lblTableSelect.TabIndex = 1;
            lblTableSelect.Text = "Select Table:";
            lblTableSelect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbTables
            // 
            cbTables.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTables.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTables.FormattingEnabled = true;
            cbTables.Location = new Point(83, 35);
            cbTables.Name = "cbTables";
            cbTables.Size = new Size(181, 29);
            cbTables.TabIndex = 2;
            cbTables.SelectedIndexChanged += cbTables_SelectedIndexChanged;
            // 
            // lblMode
            // 
            lblMode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMode.Location = new Point(635, 9);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(114, 23);
            lblMode.TabIndex = 3;
            lblMode.Text = "Mode:";
            lblMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbMode
            // 
            cbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMode.FormattingEnabled = true;
            cbMode.Location = new Point(635, 35);
            cbMode.Name = "cbMode";
            cbMode.Size = new Size(114, 29);
            cbMode.TabIndex = 4;
            cbMode.SelectedIndexChanged += cbMode_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.SaveIcon;
            btnSave.Location = new Point(577, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(52, 52);
            btnSave.TabIndex = 5;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(65, 52);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ViewEditRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 490);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(cbMode);
            Controls.Add(lblMode);
            Controls.Add(cbTables);
            Controls.Add(lblTableSelect);
            Controls.Add(DataGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewEditRecords";
            Text = "Book/Loan Search";
            FormClosing += ViewEditRecords_FormClosing;
            Load += BookLoanSearch_Load;
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGrid;
        private Label lblTableSelect;
        private ComboBox cbTables;
        private Label lblMode;
        private ComboBox cbMode;
        private Button btnSave;
        private Button btnBack;
    }
}