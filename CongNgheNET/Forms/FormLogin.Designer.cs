namespace LibraryManagement.Forms
{
    partial class FormLogin
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.mainPanel.Controls.Add(this.btnConfig);
            this.mainPanel.Controls.Add(this.btnExit);
            this.mainPanel.Controls.Add(this.btnLogin);
            this.mainPanel.Controls.Add(this.lblStatus);
            this.mainPanel.Controls.Add(this.txtPassword);
            this.mainPanel.Controls.Add(this.lblPassword);
            this.mainPanel.Controls.Add(this.txtUsername);
            this.mainPanel.Controls.Add(this.lblUsername);
            this.mainPanel.Controls.Add(this.lblSubtitle);
            this.mainPanel.Controls.Add(this.lblTitle);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(450, 350);
            this.mainPanel.TabIndex = 0;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnConfig.ForeColor = System.Drawing.Color.Gray;
            this.btnConfig.Location = new System.Drawing.Point(410, 10);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(30, 30);
            this.btnConfig.TabIndex = 9;
            this.btnConfig.Text = "⚙";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(230, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 40);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(75, 285);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(145, 40);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(75, 255);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(300, 25);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(75, 220);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "Nhập mật khẩu";
            this.txtPassword.Size = new System.Drawing.Size(300, 27);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.Location = new System.Drawing.Point(75, 195);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(75, 155);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Nhập tên đăng nhập";
            this.txtUsername.Size = new System.Drawing.Size(300, 27);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.Location = new System.Drawing.Point(75, 130);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(103, 19);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Tên đăng nhập:";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(0, 80);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(450, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Hệ thống quản lý thư viện đa máy LAN";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📚 QUẢN LÝ THƯ VIỆN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập - Quản lý Thư viện";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
    }
}
