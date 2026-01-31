namespace LibraryManagement.Forms
{
    partial class FormUserManagement
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.btnResetPwd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.cboUserRole = new System.Windows.Forms.ComboBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panelDetail.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(314, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "👥 QUẢN LÝ NGƯỜI DÙNG";
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Controls.Add(this.btnRefresh);
            this.panelSearch.Controls.Add(this.btnAdd);
            this.panelSearch.Controls.Add(this.cboRole);
            this.panelSearch.Controls.Add(this.lblRole);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Location = new System.Drawing.Point(20, 55);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(750, 55);
            this.panelSearch.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(610, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 32);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "🔄";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(500, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "➕ Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboRole
            // 
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(360, 14);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(120, 23);
            this.cboRole.TabIndex = 3;
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.cboRole_SelectedIndexChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(300, 17);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(47, 15);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Vai trò:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(80, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tên đăng nhập, họ tên...";
            this.txtSearch.Size = new System.Drawing.Size(200, 25);
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
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvUsers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserID,
            this.colUsername,
            this.colFullName,
            this.colEmail,
            this.colRole,
            this.colStatus,
            this.colLastLogin});
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Location = new System.Drawing.Point(20, 120);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(750, 400);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellDoubleClick);
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
            // 
            // colUserID
            // 
            this.colUserID.HeaderText = "ID";
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            this.colUserID.Visible = false;
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Tên đăng nhập";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            this.colUsername.Width = 120;
            // 
            // colFullName
            // 
            this.colFullName.HeaderText = "Họ tên";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Width = 180;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 180;
            // 
            // colRole
            // 
            this.colRole.HeaderText = "Vai trò";
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            this.colRole.Width = 80;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 80;
            // 
            // colLastLogin
            // 
            this.colLastLogin.HeaderText = "Đăng nhập cuối";
            this.colLastLogin.Name = "colLastLogin";
            this.colLastLogin.ReadOnly = true;
            this.colLastLogin.Width = 130;
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.White;
            this.panelDetail.Controls.Add(this.btnResetPwd);
            this.panelDetail.Controls.Add(this.btnDelete);
            this.panelDetail.Controls.Add(this.btnCancel);
            this.panelDetail.Controls.Add(this.btnSave);
            this.panelDetail.Controls.Add(this.txtNewPassword);
            this.panelDetail.Controls.Add(this.lblPassword);
            this.panelDetail.Controls.Add(this.chkActive);
            this.panelDetail.Controls.Add(this.cboUserRole);
            this.panelDetail.Controls.Add(this.lblUserRole);
            this.panelDetail.Controls.Add(this.txtPhone);
            this.panelDetail.Controls.Add(this.lblPhone);
            this.panelDetail.Controls.Add(this.txtEmail);
            this.panelDetail.Controls.Add(this.lblEmail);
            this.panelDetail.Controls.Add(this.txtFullName);
            this.panelDetail.Controls.Add(this.lblFullName);
            this.panelDetail.Controls.Add(this.txtUsername);
            this.panelDetail.Controls.Add(this.lblUsername);
            this.panelDetail.Controls.Add(this.lblDetail);
            this.panelDetail.Location = new System.Drawing.Point(790, 55);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(400, 470);
            this.panelDetail.TabIndex = 3;
            // 
            // btnResetPwd
            // 
            this.btnResetPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnResetPwd.FlatAppearance.BorderSize = 0;
            this.btnResetPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPwd.ForeColor = System.Drawing.Color.White;
            this.btnResetPwd.Location = new System.Drawing.Point(20, 355);
            this.btnResetPwd.Name = "btnResetPwd";
            this.btnResetPwd.Size = new System.Drawing.Size(130, 32);
            this.btnResetPwd.TabIndex = 17;
            this.btnResetPwd.Text = "Reset mật khẩu";
            this.btnResetPwd.UseVisualStyleBackColor = false;
            this.btnResetPwd.Click += new System.EventHandler(this.btnResetPwd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(190, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(110, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(20, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 35);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.Location = new System.Drawing.Point(140, 262);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PlaceholderText = "Để trống nếu không đổi";
            this.txtNewPassword.Size = new System.Drawing.Size(230, 25);
            this.txtNewPassword.TabIndex = 13;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 265);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 15);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Mật khẩu mới:";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(140, 230);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(131, 19);
            this.chkActive.TabIndex = 11;
            this.chkActive.Text = "Kích hoạt tài khoản";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // cboUserRole
            // 
            this.cboUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserRole.FormattingEnabled = true;
            this.cboUserRole.Location = new System.Drawing.Point(140, 192);
            this.cboUserRole.Name = "cboUserRole";
            this.cboUserRole.Size = new System.Drawing.Size(230, 23);
            this.cboUserRole.TabIndex = 10;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(20, 195);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(47, 15);
            this.lblUserRole.TabIndex = 9;
            this.lblUserRole.Text = "Vai trò:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(140, 157);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(230, 25);
            this.txtPhone.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 160);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(66, 15);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Điện thoại:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(140, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 25);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(140, 87);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(230, 25);
            this.txtFullName.TabIndex = 4;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(20, 90);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(46, 15);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Họ tên:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(140, 52);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(230, 25);
            this.txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 55);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Tên đăng nhập:";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblDetail.Location = new System.Drawing.Point(15, 15);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(180, 20);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "CHI TIẾT NGƯỜI DÙNG";
            // 
            // FormUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1220, 560);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelTop);
            this.Name = "FormUserManagement";
            this.Text = "Quản lý người dùng";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastLogin;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Button btnResetPwd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.ComboBox cboUserRole;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDetail;
    }
}
