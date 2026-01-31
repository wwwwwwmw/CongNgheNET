namespace LibraryManagement.Forms
{
    partial class FormSettings
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.lblConnectionInfo = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblFineUnit = new System.Windows.Forms.Label();
            this.numFinePerDay = new System.Windows.Forms.NumericUpDown();
            this.lblFine = new System.Windows.Forms.Label();
            this.lblBooksUnit = new System.Windows.Forms.Label();
            this.numMaxBooks = new System.Windows.Forms.NumericUpDown();
            this.lblMaxBooks = new System.Windows.Forms.Label();
            this.lblDaysUnit = new System.Windows.Forms.Label();
            this.numBorrowDays = new System.Windows.Forms.NumericUpDown();
            this.lblBorrowDays = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtLibraryName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLibInfo = new System.Windows.Forms.Label();
            this.panelLogs = new System.Windows.Forms.Panel();
            this.btnRefreshLogs = new System.Windows.Forms.Button();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.colLogTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLogs = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFinePerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBorrowDays)).BeginInit();
            this.panelLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(295, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "⚙️ CÀI ĐẶT HỆ THỐNG";
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.White;
            this.panelSettings.Controls.Add(this.btnSave);
            this.panelSettings.Controls.Add(this.btnTestConnection);
            this.panelSettings.Controls.Add(this.lblConnectionInfo);
            this.panelSettings.Controls.Add(this.lblConnection);
            this.panelSettings.Controls.Add(this.lblFineUnit);
            this.panelSettings.Controls.Add(this.numFinePerDay);
            this.panelSettings.Controls.Add(this.lblFine);
            this.panelSettings.Controls.Add(this.lblBooksUnit);
            this.panelSettings.Controls.Add(this.numMaxBooks);
            this.panelSettings.Controls.Add(this.lblMaxBooks);
            this.panelSettings.Controls.Add(this.lblDaysUnit);
            this.panelSettings.Controls.Add(this.numBorrowDays);
            this.panelSettings.Controls.Add(this.lblBorrowDays);
            this.panelSettings.Controls.Add(this.lblRules);
            this.panelSettings.Controls.Add(this.txtEmail);
            this.panelSettings.Controls.Add(this.lblEmail);
            this.panelSettings.Controls.Add(this.txtPhone);
            this.panelSettings.Controls.Add(this.lblPhone);
            this.panelSettings.Controls.Add(this.txtAddress);
            this.panelSettings.Controls.Add(this.lblAddress);
            this.panelSettings.Controls.Add(this.txtLibraryName);
            this.panelSettings.Controls.Add(this.lblName);
            this.panelSettings.Controls.Add(this.lblLibInfo);
            this.panelSettings.Location = new System.Drawing.Point(20, 55);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(550, 480);
            this.panelSettings.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(20, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 35);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Lưu cài đặt";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTestConnection.FlatAppearance.BorderSize = 0;
            this.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestConnection.ForeColor = System.Drawing.Color.White;
            this.btnTestConnection.Location = new System.Drawing.Point(20, 405);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(110, 32);
            this.btnTestConnection.TabIndex = 21;
            this.btnTestConnection.Text = "Test kết nối";
            this.btnTestConnection.UseVisualStyleBackColor = false;
            this.btnTestConnection.Click += new System.EventHandler(this.BtnTestConnection_Click);
            // 
            // lblConnectionInfo
            // 
            this.lblConnectionInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConnectionInfo.Location = new System.Drawing.Point(20, 360);
            this.lblConnectionInfo.Name = "lblConnectionInfo";
            this.lblConnectionInfo.Size = new System.Drawing.Size(500, 40);
            this.lblConnectionInfo.TabIndex = 20;
            this.lblConnectionInfo.Text = "Connection String:";
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblConnection.Location = new System.Drawing.Point(20, 330);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(148, 20);
            this.lblConnection.TabIndex = 19;
            this.lblConnection.Text = "KẾT NỐI MẠNG LAN";
            // 
            // lblFineUnit
            // 
            this.lblFineUnit.AutoSize = true;
            this.lblFineUnit.Location = new System.Drawing.Point(290, 275);
            this.lblFineUnit.Name = "lblFineUnit";
            this.lblFineUnit.Size = new System.Drawing.Size(58, 15);
            this.lblFineUnit.TabIndex = 18;
            this.lblFineUnit.Text = "VNĐ/ngày";
            // 
            // numFinePerDay
            // 
            this.numFinePerDay.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFinePerDay.Location = new System.Drawing.Point(180, 272);
            this.numFinePerDay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numFinePerDay.Name = "numFinePerDay";
            this.numFinePerDay.Size = new System.Drawing.Size(100, 23);
            this.numFinePerDay.TabIndex = 17;
            this.numFinePerDay.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Location = new System.Drawing.Point(20, 275);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(105, 15);
            this.lblFine.TabIndex = 16;
            this.lblFine.Text = "Tiền phạt quá hạn:";
            // 
            // lblBooksUnit
            // 
            this.lblBooksUnit.AutoSize = true;
            this.lblBooksUnit.Location = new System.Drawing.Point(270, 240);
            this.lblBooksUnit.Name = "lblBooksUnit";
            this.lblBooksUnit.Size = new System.Drawing.Size(59, 15);
            this.lblBooksUnit.TabIndex = 15;
            this.lblBooksUnit.Text = "quyển/lần";
            // 
            // numMaxBooks
            // 
            this.numMaxBooks.Location = new System.Drawing.Point(180, 237);
            this.numMaxBooks.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMaxBooks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxBooks.Name = "numMaxBooks";
            this.numMaxBooks.Size = new System.Drawing.Size(80, 23);
            this.numMaxBooks.TabIndex = 14;
            this.numMaxBooks.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblMaxBooks
            // 
            this.lblMaxBooks.AutoSize = true;
            this.lblMaxBooks.Location = new System.Drawing.Point(20, 240);
            this.lblMaxBooks.Name = "lblMaxBooks";
            this.lblMaxBooks.Size = new System.Drawing.Size(116, 15);
            this.lblMaxBooks.TabIndex = 13;
            this.lblMaxBooks.Text = "Số sách mượn tối đa:";
            // 
            // lblDaysUnit
            // 
            this.lblDaysUnit.AutoSize = true;
            this.lblDaysUnit.Location = new System.Drawing.Point(270, 205);
            this.lblDaysUnit.Name = "lblDaysUnit";
            this.lblDaysUnit.Size = new System.Drawing.Size(32, 15);
            this.lblDaysUnit.TabIndex = 12;
            this.lblDaysUnit.Text = "ngày";
            // 
            // numBorrowDays
            // 
            this.numBorrowDays.Location = new System.Drawing.Point(180, 202);
            this.numBorrowDays.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numBorrowDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBorrowDays.Name = "numBorrowDays";
            this.numBorrowDays.Size = new System.Drawing.Size(80, 23);
            this.numBorrowDays.TabIndex = 11;
            this.numBorrowDays.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // lblBorrowDays
            // 
            this.lblBorrowDays.AutoSize = true;
            this.lblBorrowDays.Location = new System.Drawing.Point(20, 205);
            this.lblBorrowDays.Name = "lblBorrowDays";
            this.lblBorrowDays.Size = new System.Drawing.Size(123, 15);
            this.lblBorrowDays.TabIndex = 10;
            this.lblBorrowDays.Text = "Số ngày mượn tối đa:";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblRules.Location = new System.Drawing.Point(20, 170);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(161, 20);
            this.lblRules.TabIndex = 9;
            this.lblRules.Text = "QUY ĐỊNH MƯỢN TRẢ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(390, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 25);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(340, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(140, 117);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(180, 25);
            this.txtPhone.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 120);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 15);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Điện thoại:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Location = new System.Drawing.Point(140, 82);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(380, 25);
            this.txtAddress.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 85);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(46, 15);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // txtLibraryName
            // 
            this.txtLibraryName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLibraryName.Location = new System.Drawing.Point(140, 47);
            this.txtLibraryName.Name = "txtLibraryName";
            this.txtLibraryName.Size = new System.Drawing.Size(380, 25);
            this.txtLibraryName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên thư viện:";
            // 
            // lblLibInfo
            // 
            this.lblLibInfo.AutoSize = true;
            this.lblLibInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLibInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblLibInfo.Location = new System.Drawing.Point(20, 15);
            this.lblLibInfo.Name = "lblLibInfo";
            this.lblLibInfo.Size = new System.Drawing.Size(202, 20);
            this.lblLibInfo.TabIndex = 0;
            this.lblLibInfo.Text = "📚 THÔNG TIN THƯ VIỆN";
            // 
            // panelLogs
            // 
            this.panelLogs.BackColor = System.Drawing.Color.White;
            this.panelLogs.Controls.Add(this.btnRefreshLogs);
            this.panelLogs.Controls.Add(this.btnClearLogs);
            this.panelLogs.Controls.Add(this.dgvLogs);
            this.panelLogs.Controls.Add(this.lblLogs);
            this.panelLogs.Location = new System.Drawing.Point(590, 55);
            this.panelLogs.Name = "panelLogs";
            this.panelLogs.Size = new System.Drawing.Size(600, 480);
            this.panelLogs.TabIndex = 2;
            // 
            // btnRefreshLogs
            // 
            this.btnRefreshLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefreshLogs.FlatAppearance.BorderSize = 0;
            this.btnRefreshLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshLogs.ForeColor = System.Drawing.Color.White;
            this.btnRefreshLogs.Location = new System.Drawing.Point(155, 440);
            this.btnRefreshLogs.Name = "btnRefreshLogs";
            this.btnRefreshLogs.Size = new System.Drawing.Size(100, 30);
            this.btnRefreshLogs.TabIndex = 3;
            this.btnRefreshLogs.Text = "🔄 Làm mới";
            this.btnRefreshLogs.UseVisualStyleBackColor = false;
            this.btnRefreshLogs.Click += new System.EventHandler(this.BtnRefreshLogs_Click);
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClearLogs.FlatAppearance.BorderSize = 0;
            this.btnClearLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLogs.ForeColor = System.Drawing.Color.White;
            this.btnClearLogs.Location = new System.Drawing.Point(15, 440);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(130, 30);
            this.btnClearLogs.TabIndex = 2;
            this.btnClearLogs.Text = "🗑 Xóa nhật ký cũ";
            this.btnClearLogs.UseVisualStyleBackColor = false;
            this.btnClearLogs.Click += new System.EventHandler(this.BtnClearLogs_Click);
            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.BackgroundColor = System.Drawing.Color.White;
            this.dgvLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLogs.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvLogs.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvLogs.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLogTime,
            this.colUsername,
            this.colAction});
            this.dgvLogs.EnableHeadersVisualStyles = false;
            this.dgvLogs.Location = new System.Drawing.Point(15, 50);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.RowHeadersVisible = false;
            this.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogs.Size = new System.Drawing.Size(570, 380);
            this.dgvLogs.TabIndex = 1;
            // 
            // colLogTime
            // 
            this.colLogTime.HeaderText = "Thời gian";
            this.colLogTime.Name = "colLogTime";
            this.colLogTime.ReadOnly = true;
            this.colLogTime.Width = 130;
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Người dùng";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Hoạt động";
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.Width = 320;
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblLogs.Location = new System.Drawing.Point(15, 15);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(170, 20);
            this.lblLogs.TabIndex = 0;
            this.lblLogs.Text = "NHẬT KÝ HOẠT ĐỘNG";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1220, 560);
            this.Controls.Add(this.panelLogs);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelTop);
            this.Name = "FormSettings";
            this.Text = "Cài đặt hệ thống";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFinePerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBorrowDays)).EndInit();
            this.panelLogs.ResumeLayout(false);
            this.panelLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label lblLibInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtLibraryName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblBorrowDays;
        private System.Windows.Forms.NumericUpDown numBorrowDays;
        private System.Windows.Forms.Label lblDaysUnit;
        private System.Windows.Forms.Label lblMaxBooks;
        private System.Windows.Forms.NumericUpDown numMaxBooks;
        private System.Windows.Forms.Label lblBooksUnit;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.NumericUpDown numFinePerDay;
        private System.Windows.Forms.Label lblFineUnit;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblConnectionInfo;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelLogs;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.Button btnRefreshLogs;
    }
}
