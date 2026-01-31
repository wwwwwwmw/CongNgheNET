namespace LibraryManagement.Forms
{
    partial class FormReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvBorrowRecords = new System.Windows.Forms.DataGridView();
            this.colBorrowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDaysLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblSelectedInfo = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowRecords)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1220, 50);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TRẢ SÁCH";
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Controls.Add(this.btnRefresh);
            this.panelSearch.Controls.Add(this.cboStatus);
            this.panelSearch.Controls.Add(this.lblStatus);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Location = new System.Drawing.Point(20, 55);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1180, 55);
            this.panelSearch.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(590, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 32);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(420, 14);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(150, 23);
            this.cboStatus.TabIndex = 3;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(350, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 15);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Trạng thái:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(80, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Mã phiếu, mã thẻ, tên độc giả, tên sách...";
            this.txtSearch.Size = new System.Drawing.Size(250, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(15, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(59, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // dgvBorrowRecords
            // 
            this.dgvBorrowRecords.AllowUserToAddRows = false;
            this.dgvBorrowRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBorrowRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvBorrowRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBorrowRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBorrowID,
            this.colBorrowCode,
            this.colMemberCode,
            this.colMemberName,
            this.colBookTitle,
            this.colBorrowDate,
            this.colDueDate,
            this.colDaysLeft,
            this.colStatus});
            this.dgvBorrowRecords.Location = new System.Drawing.Point(20, 120);
            this.dgvBorrowRecords.Name = "dgvBorrowRecords";
            this.dgvBorrowRecords.ReadOnly = true;
            this.dgvBorrowRecords.RowHeadersVisible = false;
            this.dgvBorrowRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowRecords.Size = new System.Drawing.Size(1180, 330);
            this.dgvBorrowRecords.TabIndex = 2;
            this.dgvBorrowRecords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowRecords_CellDoubleClick);
            this.dgvBorrowRecords.SelectionChanged += new System.EventHandler(this.dgvBorrowRecords_SelectionChanged);
            // 
            // colBorrowID
            // 
            this.colBorrowID.HeaderText = "ID";
            this.colBorrowID.Name = "colBorrowID";
            this.colBorrowID.ReadOnly = true;
            this.colBorrowID.Visible = false;
            // 
            // colBorrowCode
            // 
            this.colBorrowCode.HeaderText = "Mã phiếu";
            this.colBorrowCode.Name = "colBorrowCode";
            this.colBorrowCode.ReadOnly = true;
            this.colBorrowCode.Width = 110;
            // 
            // colMemberCode
            // 
            this.colMemberCode.HeaderText = "Mã thẻ";
            this.colMemberCode.Name = "colMemberCode";
            this.colMemberCode.ReadOnly = true;
            this.colMemberCode.Width = 80;
            // 
            // colMemberName
            // 
            this.colMemberName.HeaderText = "Tên độc giả";
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.ReadOnly = true;
            this.colMemberName.Width = 150;
            // 
            // colBookTitle
            // 
            this.colBookTitle.HeaderText = "Tên sách";
            this.colBookTitle.Name = "colBookTitle";
            this.colBookTitle.ReadOnly = true;
            this.colBookTitle.Width = 280;
            // 
            // colBorrowDate
            // 
            this.colBorrowDate.HeaderText = "Ngày mượn";
            this.colBorrowDate.Name = "colBorrowDate";
            this.colBorrowDate.ReadOnly = true;
            // 
            // colDueDate
            // 
            this.colDueDate.HeaderText = "Hạn trả";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            // 
            // colDaysLeft
            // 
            this.colDaysLeft.HeaderText = "Còn/Quá hạn";
            this.colDaysLeft.Name = "colDaysLeft";
            this.colDaysLeft.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelInfo.Controls.Add(this.lblSelectedInfo);
            this.panelInfo.Location = new System.Drawing.Point(20, 460);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(800, 60);
            this.panelInfo.TabIndex = 3;
            // 
            // lblSelectedInfo
            // 
            this.lblSelectedInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSelectedInfo.Location = new System.Drawing.Point(0, 0);
            this.lblSelectedInfo.Name = "lblSelectedInfo";
            this.lblSelectedInfo.Padding = new System.Windows.Forms.Padding(5);
            this.lblSelectedInfo.Size = new System.Drawing.Size(800, 60);
            this.lblSelectedInfo.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.Controls.Add(this.btnRenew);
            this.panelButtons.Controls.Add(this.btnReturn);
            this.panelButtons.Location = new System.Drawing.Point(840, 460);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(360, 60);
            this.panelButtons.TabIndex = 4;
            // 
            // btnRenew
            // 
            this.btnRenew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRenew.FlatAppearance.BorderSize = 0;
            this.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenew.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRenew.ForeColor = System.Drawing.Color.White;
            this.btnRenew.Location = new System.Drawing.Point(150, 5);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(100, 50);
            this.btnRenew.TabIndex = 1;
            this.btnRenew.Text = "Gia hạn";
            this.btnRenew.UseVisualStyleBackColor = false;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(0, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(130, 50);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Trả sách";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FormReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1220, 540);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.dgvBorrowRecords);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelTop);
            this.Name = "FormReturn";
            this.Text = "Trả sách";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowRecords)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvBorrowRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDaysLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblSelectedInfo;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnReturn;
    }
}
