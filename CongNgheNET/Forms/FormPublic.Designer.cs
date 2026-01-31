namespace LibraryManagement.Forms
{
    partial class FormPublic
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.searchLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panelBooks = new System.Windows.Forms.Panel();
            this.flowBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.searchLayout.SuspendLayout();
            this.panelBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.btnLogin);
            this.panelHeader.Controls.Add(this.btnRegister);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1280, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(1150, 18);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập (NV)";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(1035, 18);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 35);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Đăng ký thẻ";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(536, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📚 THƯ VIỆN SÁCH - Tra cứu && Mượn sách online";
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Controls.Add(this.searchLayout);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 70);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1280, 60);
            this.panelSearch.TabIndex = 1;
            // 
            // searchLayout
            // 
            this.searchLayout.ColumnCount = 6;
            this.searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.searchLayout.Controls.Add(this.lblSearch, 0, 0);
            this.searchLayout.Controls.Add(this.txtSearch, 1, 0);
            this.searchLayout.Controls.Add(this.lblCategory, 2, 0);
            this.searchLayout.Controls.Add(this.cboCategory, 3, 0);
            this.searchLayout.Controls.Add(this.lblTotalBooks, 4, 0);
            this.searchLayout.Controls.Add(this.btnReset, 5, 0);
            this.searchLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLayout.Location = new System.Drawing.Point(0, 0);
            this.searchLayout.Name = "searchLayout";
            this.searchLayout.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.searchLayout.RowCount = 1;
            this.searchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchLayout.Size = new System.Drawing.Size(1280, 60);
            this.searchLayout.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSearch.Location = new System.Drawing.Point(18, 17);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(74, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(100, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Nhập tên sách, tác giả, ISBN...";
            this.txtSearch.Size = new System.Drawing.Size(290, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCategory.Location = new System.Drawing.Point(410, 17);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(15, 8, 3, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(67, 20);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Thể loại:";
            // 
            // cboCategory
            // 
            this.cboCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(485, 15);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(5);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(190, 28);
            this.cboCategory.TabIndex = 3;
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblTotalBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTotalBooks.Location = new System.Drawing.Point(1001, 18);
            this.lblTotalBooks.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(116, 19);
            this.lblTotalBooks.TabIndex = 4;
            this.lblTotalBooks.Text = "Tổng: 0 cuốn sách";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1180, 13);
            this.btnReset.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 33);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // panelBooks
            // 
            this.panelBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelBooks.Controls.Add(this.flowBooks);
            this.panelBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBooks.Location = new System.Drawing.Point(0, 130);
            this.panelBooks.Name = "panelBooks";
            this.panelBooks.Padding = new System.Windows.Forms.Padding(15);
            this.panelBooks.Size = new System.Drawing.Size(1280, 590);
            this.panelBooks.TabIndex = 2;
            // 
            // flowBooks
            // 
            this.flowBooks.AutoScroll = true;
            this.flowBooks.BackColor = System.Drawing.Color.Transparent;
            this.flowBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowBooks.Location = new System.Drawing.Point(15, 15);
            this.flowBooks.Name = "flowBooks";
            this.flowBooks.Size = new System.Drawing.Size(1250, 560);
            this.flowBooks.TabIndex = 0;
            // 
            // FormPublic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelBooks);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormPublic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "📚 Thư Viện Sách - Tra cứu công khai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.searchLayout.ResumeLayout(false);
            this.searchLayout.PerformLayout();
            this.panelBooks.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TableLayoutPanel searchLayout;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panelBooks;
        private System.Windows.Forms.FlowLayoutPanel flowBooks;
    }
}
