namespace LibraryManagement.Forms
{
    partial class FormBorrow
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
            this.panelMember = new System.Windows.Forms.Panel();
            this.lblMemberTitle = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.btnFindMember = new System.Windows.Forms.Button();
            this.lblMemberInfo = new System.Windows.Forms.Label();
            this.lblMemberStatus = new System.Windows.Forms.Label();
            this.panelBorrowList = new System.Windows.Forms.Panel();
            this.lblCurrentBorrow = new System.Windows.Forms.Label();
            this.dgvBorrowing = new System.Windows.Forms.DataGridView();
            this.colBorrowBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBook = new System.Windows.Forms.Panel();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtBookSearch = new System.Windows.Forms.TextBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.colBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvailableCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.lblDays = new System.Windows.Forms.Label();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelMember.SuspendLayout();
            this.panelBorrowList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowing)).BeginInit();
            this.panelBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
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
            this.lblTitle.Size = new System.Drawing.Size(165, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MƯỢN SÁCH";
            // 
            // panelMember
            // 
            this.panelMember.BackColor = System.Drawing.Color.White;
            this.panelMember.Controls.Add(this.lblMemberTitle);
            this.panelMember.Controls.Add(this.lblCode);
            this.panelMember.Controls.Add(this.txtMemberCode);
            this.panelMember.Controls.Add(this.btnFindMember);
            this.panelMember.Controls.Add(this.lblMemberInfo);
            this.panelMember.Controls.Add(this.lblMemberStatus);
            this.panelMember.Location = new System.Drawing.Point(20, 60);
            this.panelMember.Name = "panelMember";
            this.panelMember.Padding = new System.Windows.Forms.Padding(15);
            this.panelMember.Size = new System.Drawing.Size(500, 200);
            this.panelMember.TabIndex = 1;
            // 
            // lblMemberTitle
            // 
            this.lblMemberTitle.AutoSize = true;
            this.lblMemberTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMemberTitle.Location = new System.Drawing.Point(15, 10);
            this.lblMemberTitle.Name = "lblMemberTitle";
            this.lblMemberTitle.Size = new System.Drawing.Size(168, 20);
            this.lblMemberTitle.TabIndex = 0;
            this.lblMemberTitle.Text = "👤 Thông tin độc giả";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(15, 48);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(47, 15);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Mã thẻ:";
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMemberCode.Location = new System.Drawing.Point(80, 42);
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.Size = new System.Drawing.Size(150, 25);
            this.txtMemberCode.TabIndex = 2;
            // 
            // btnFindMember
            // 
            this.btnFindMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFindMember.FlatAppearance.BorderSize = 0;
            this.btnFindMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindMember.ForeColor = System.Drawing.Color.White;
            this.btnFindMember.Location = new System.Drawing.Point(240, 40);
            this.btnFindMember.Name = "btnFindMember";
            this.btnFindMember.Size = new System.Drawing.Size(85, 30);
            this.btnFindMember.TabIndex = 3;
            this.btnFindMember.Text = "Tìm kiếm";
            this.btnFindMember.UseVisualStyleBackColor = false;
            // 
            // lblMemberInfo
            // 
            this.lblMemberInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMemberInfo.Location = new System.Drawing.Point(15, 80);
            this.lblMemberInfo.Name = "lblMemberInfo";
            this.lblMemberInfo.Size = new System.Drawing.Size(460, 60);
            this.lblMemberInfo.TabIndex = 4;
            // 
            // lblMemberStatus
            // 
            this.lblMemberStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMemberStatus.Location = new System.Drawing.Point(15, 145);
            this.lblMemberStatus.Name = "lblMemberStatus";
            this.lblMemberStatus.Size = new System.Drawing.Size(460, 25);
            this.lblMemberStatus.TabIndex = 5;
            // 
            // panelBorrowList
            // 
            this.panelBorrowList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelBorrowList.Controls.Add(this.lblCurrentBorrow);
            this.panelBorrowList.Controls.Add(this.dgvBorrowing);
            this.panelBorrowList.Location = new System.Drawing.Point(20, 265);
            this.panelBorrowList.Name = "panelBorrowList";
            this.panelBorrowList.Size = new System.Drawing.Size(500, 215);
            this.panelBorrowList.TabIndex = 2;
            // 
            // lblCurrentBorrow
            // 
            this.lblCurrentBorrow.AutoSize = true;
            this.lblCurrentBorrow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrentBorrow.Location = new System.Drawing.Point(0, 5);
            this.lblCurrentBorrow.Name = "lblCurrentBorrow";
            this.lblCurrentBorrow.Size = new System.Drawing.Size(132, 19);
            this.lblCurrentBorrow.TabIndex = 0;
            this.lblCurrentBorrow.Text = "📚 Sách đang mượn:";
            // 
            // dgvBorrowing
            // 
            this.dgvBorrowing.AllowUserToAddRows = false;
            this.dgvBorrowing.BackgroundColor = System.Drawing.Color.White;
            this.dgvBorrowing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBorrowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBorrowBookTitle,
            this.colBorrowDate,
            this.colDueDate,
            this.colBorrowStatus});
            this.dgvBorrowing.Location = new System.Drawing.Point(0, 30);
            this.dgvBorrowing.Name = "dgvBorrowing";
            this.dgvBorrowing.ReadOnly = true;
            this.dgvBorrowing.RowHeadersVisible = false;
            this.dgvBorrowing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowing.Size = new System.Drawing.Size(500, 180);
            this.dgvBorrowing.TabIndex = 1;
            // 
            // colBorrowBookTitle
            // 
            this.colBorrowBookTitle.HeaderText = "Tên sách";
            this.colBorrowBookTitle.Name = "colBorrowBookTitle";
            this.colBorrowBookTitle.ReadOnly = true;
            this.colBorrowBookTitle.Width = 220;
            // 
            // colBorrowDate
            // 
            this.colBorrowDate.HeaderText = "Ngày mượn";
            this.colBorrowDate.Name = "colBorrowDate";
            this.colBorrowDate.ReadOnly = true;
            this.colBorrowDate.Width = 90;
            // 
            // colDueDate
            // 
            this.colDueDate.HeaderText = "Hạn trả";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            this.colDueDate.Width = 90;
            // 
            // colBorrowStatus
            // 
            this.colBorrowStatus.HeaderText = "Trạng thái";
            this.colBorrowStatus.Name = "colBorrowStatus";
            this.colBorrowStatus.ReadOnly = true;
            this.colBorrowStatus.Width = 90;
            // 
            // panelBook
            // 
            this.panelBook.BackColor = System.Drawing.Color.White;
            this.panelBook.Controls.Add(this.lblBookTitle);
            this.panelBook.Controls.Add(this.lblSearch);
            this.panelBook.Controls.Add(this.txtBookSearch);
            this.panelBook.Controls.Add(this.dgvBooks);
            this.panelBook.Controls.Add(this.panelButtons);
            this.panelBook.Location = new System.Drawing.Point(540, 60);
            this.panelBook.Name = "panelBook";
            this.panelBook.Padding = new System.Windows.Forms.Padding(15);
            this.panelBook.Size = new System.Drawing.Size(660, 420);
            this.panelBook.TabIndex = 3;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBookTitle.Location = new System.Drawing.Point(15, 10);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(125, 20);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "Chọn sách mượn";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(15, 48);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 15);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Tìm sách:";
            // 
            // txtBookSearch
            // 
            this.txtBookSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBookSearch.Location = new System.Drawing.Point(80, 42);
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.PlaceholderText = "Nhập tên sách hoặc ISBN...";
            this.txtBookSearch.Size = new System.Drawing.Size(300, 25);
            this.txtBookSearch.TabIndex = 2;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvBooks.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvBooks.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBookID,
            this.colISBN,
            this.colTitle,
            this.colAuthorName,
            this.colAvailableCopies,
            this.colLocation});
            this.dgvBooks.EnableHeadersVisualStyles = false;
            this.dgvBooks.Location = new System.Drawing.Point(15, 80);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(620, 270);
            this.dgvBooks.TabIndex = 3;
            // 
            // colBookID
            // 
            this.colBookID.HeaderText = "ID";
            this.colBookID.Name = "colBookID";
            this.colBookID.ReadOnly = true;
            this.colBookID.Visible = false;
            // 
            // colISBN
            // 
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            this.colISBN.Width = 100;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Tên sách";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 220;
            // 
            // colAuthorName
            // 
            this.colAuthorName.HeaderText = "Tác giả";
            this.colAuthorName.Name = "colAuthorName";
            this.colAuthorName.ReadOnly = true;
            this.colAuthorName.Width = 120;
            // 
            // colAvailableCopies
            // 
            this.colAvailableCopies.HeaderText = "Còn lại";
            this.colAvailableCopies.Name = "colAvailableCopies";
            this.colAvailableCopies.ReadOnly = true;
            this.colAvailableCopies.Width = 70;
            // 
            // colLocation
            // 
            this.colLocation.HeaderText = "Vị trí";
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.Width = 80;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.lblDays);
            this.panelButtons.Controls.Add(this.numDays);
            this.panelButtons.Controls.Add(this.btnBorrow);
            this.panelButtons.Controls.Add(this.btnCancel);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(15, 360);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(630, 45);
            this.panelButtons.TabIndex = 4;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(0, 12);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(85, 15);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Số ngày mượn:";
            // 
            // numDays
            // 
            this.numDays.Location = new System.Drawing.Point(95, 8);
            this.numDays.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(70, 23);
            this.numDays.TabIndex = 1;
            this.numDays.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnBorrow.FlatAppearance.BorderSize = 0;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBorrow.ForeColor = System.Drawing.Color.White;
            this.btnBorrow.Location = new System.Drawing.Point(185, 2);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(120, 40);
            this.btnBorrow.TabIndex = 2;
            this.btnBorrow.Text = "Mượn sách";
            this.btnBorrow.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(315, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // FormBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1220, 540);
            this.Controls.Add(this.panelBook);
            this.Controls.Add(this.panelBorrowList);
            this.Controls.Add(this.panelMember);
            this.Controls.Add(this.panelTop);
            this.Name = "FormBorrow";
            this.Text = "Mượn sách";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMember.ResumeLayout(false);
            this.panelMember.PerformLayout();
            this.panelBorrowList.ResumeLayout(false);
            this.panelBorrowList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowing)).EndInit();
            this.panelBook.ResumeLayout(false);
            this.panelBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMember;
        private System.Windows.Forms.Label lblMemberTitle;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.Button btnFindMember;
        private System.Windows.Forms.Label lblMemberInfo;
        private System.Windows.Forms.Label lblMemberStatus;
        private System.Windows.Forms.Panel panelBorrowList;
        private System.Windows.Forms.Label lblCurrentBorrow;
        private System.Windows.Forms.DataGridView dgvBorrowing;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowStatus;
        private System.Windows.Forms.Panel panelBook;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtBookSearch;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailableCopies;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown numDays;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnCancel;
    }
}
