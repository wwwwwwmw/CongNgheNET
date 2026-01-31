namespace LibraryManagement.Forms
{
    partial class FormMain
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
            timerDateTime?.Stop();
            timerDateTime?.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblDateTime);
            this.panelHeader.Controls.Add(this.lblCurrentUser);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1280, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(960, 32);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(300, 25);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "🕐 01/02/2026 00:00:00";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCurrentUser.ForeColor = System.Drawing.Color.White;
            this.lblCurrentUser.Location = new System.Drawing.Point(960, 10);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(300, 25);
            this.lblCurrentUser.TabIndex = 1;
            this.lblCurrentUser.Text = "👤 Tên người dùng (Admin)";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(378, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📚 HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 60);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 660);
            this.panelMenu.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(220, 60);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelContent.Size = new System.Drawing.Size(1060, 660);
            this.panelContent.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Thư viện - Hệ thống đa máy LAN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
    }
}
