namespace LibraryManagement.Forms
{
    partial class FormBookManagement
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
            this.chkAvailableOnly = new System.Windows.Forms.CheckBox();
            this.cboAuthor = new System.Windows.Forms.ComboBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.colBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvailableCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.numTotalCopies = new System.Windows.Forms.NumericUpDown();
            this.lblTotalCopies = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.cboAuthorDetail = new System.Windows.Forms.ComboBox();
            this.lblAuthorDetail = new System.Windows.Forms.Label();
            this.cboCategoryDetail = new System.Windows.Forms.ComboBox();
            this.lblCategoryDetail = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.picBookImage = new System.Windows.Forms.PictureBox();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.chkAvailableOnly);
            this.panelTop.Controls.Add(this.cboAuthor);
            this.panelTop.Controls.Add(this.lblAuthor);
            this.panelTop.Controls.Add(this.cboCategory);
            this.panelTop.Controls.Add(this.lblCategory);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1240, 60);
            this.panelTop.TabIndex = 0;
            // 
            // chkAvailableOnly
            // 
            this.chkAvailableOnly.AutoSize = true;
            this.chkAvailableOnly.Location = new System.Drawing.Point(880, 20);
            this.chkAvailableOnly.Name = "chkAvailableOnly";
            this.chkAvailableOnly.Size = new System.Drawing.Size(90, 19);
            this.chkAvailableOnly.TabIndex = 7;
            this.chkAvailableOnly.Text = "Chỉ còn sách";
            this.chkAvailableOnly.UseVisualStyleBackColor = true;
            // 
            // cboAuthor
            // 
            this.cboAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor.FormattingEnabled = true;
            this.cboAuthor.Location = new System.Drawing.Point(710, 18);
            this.cboAuthor.Name = "cboAuthor";
            this.cboAuthor.Size = new System.Drawing.Size(150, 23);
            this.cboAuthor.TabIndex = 6;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(650, 21);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(54, 15);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Tác giả:";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(490, 18);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(150, 23);
            this.cboCategory.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(430, 21);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(54, 15);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Thể loại:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(350, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(150, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm kiếm sách...";
            this.txtSearch.Size = new System.Drawing.Size(190, 25);
            this.txtSearch.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📚 QUẢN LÝ SÁCH";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 60);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelButtons);
            this.splitContainer.Panel1.Controls.Add(this.dgvBooks);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelDetail);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer.Size = new System.Drawing.Size(1240, 480);
            this.splitContainer.SplitterDistance = 840;
            this.splitContainer.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnRefresh);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnEdit);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(10, 430);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(820, 40);
            this.panelButtons.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(300, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 32);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(200, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(100, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBookID,
            this.colISBN,
            this.colTitle,
            this.colCategoryName,
            this.colAuthorName,
            this.colTotalCopies,
            this.colAvailableCopies,
            this.colLocation});
            this.dgvBooks.Location = new System.Drawing.Point(10, 10);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(820, 415);
            this.dgvBooks.TabIndex = 0;
            // 
            // colBookID
            // 
            this.colBookID.HeaderText = "ID";
            this.colBookID.Name = "BookID";
            this.colBookID.ReadOnly = true;
            this.colBookID.Visible = false;
            // 
            // colISBN
            // 
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "ISBN";
            this.colISBN.ReadOnly = true;
            this.colISBN.Width = 100;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Tên sách";
            this.colTitle.Name = "Title";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 250;
            // 
            // colCategoryName
            // 
            this.colCategoryName.HeaderText = "Thể loại";
            this.colCategoryName.Name = "CategoryName";
            this.colCategoryName.ReadOnly = true;
            // 
            // colAuthorName
            // 
            this.colAuthorName.HeaderText = "Tác giả";
            this.colAuthorName.Name = "AuthorName";
            this.colAuthorName.ReadOnly = true;
            this.colAuthorName.Width = 120;
            // 
            // colTotalCopies
            // 
            this.colTotalCopies.HeaderText = "Tổng";
            this.colTotalCopies.Name = "TotalCopies";
            this.colTotalCopies.ReadOnly = true;
            this.colTotalCopies.Width = 60;
            // 
            // colAvailableCopies
            // 
            this.colAvailableCopies.HeaderText = "Còn";
            this.colAvailableCopies.Name = "AvailableCopies";
            this.colAvailableCopies.ReadOnly = true;
            this.colAvailableCopies.Width = 60;
            // 
            // colLocation
            // 
            this.colLocation.HeaderText = "Vị trí";
            this.colLocation.Name = "Location";
            this.colLocation.ReadOnly = true;
            this.colLocation.Width = 80;
            // 
            // panelDetail
            // 
            this.panelDetail.AutoScroll = true;
            this.panelDetail.BackColor = System.Drawing.Color.White;
            this.panelDetail.Controls.Add(this.btnCancel);
            this.panelDetail.Controls.Add(this.btnSave);
            this.panelDetail.Controls.Add(this.txtDescription);
            this.panelDetail.Controls.Add(this.lblDescription);
            this.panelDetail.Controls.Add(this.txtLocation);
            this.panelDetail.Controls.Add(this.lblLocation);
            this.panelDetail.Controls.Add(this.numTotalCopies);
            this.panelDetail.Controls.Add(this.lblTotalCopies);
            this.panelDetail.Controls.Add(this.numPrice);
            this.panelDetail.Controls.Add(this.lblPrice);
            this.panelDetail.Controls.Add(this.numYear);
            this.panelDetail.Controls.Add(this.lblYear);
            this.panelDetail.Controls.Add(this.cboPublisher);
            this.panelDetail.Controls.Add(this.lblPublisher);
            this.panelDetail.Controls.Add(this.cboAuthorDetail);
            this.panelDetail.Controls.Add(this.lblAuthorDetail);
            this.panelDetail.Controls.Add(this.cboCategoryDetail);
            this.panelDetail.Controls.Add(this.lblCategoryDetail);
            this.panelDetail.Controls.Add(this.txtBookTitle);
            this.panelDetail.Controls.Add(this.lblBookTitle);
            this.panelDetail.Controls.Add(this.txtISBN);
            this.panelDetail.Controls.Add(this.lblISBN);
            this.panelDetail.Controls.Add(this.btnViewDetail);
            this.panelDetail.Controls.Add(this.btnRemoveImage);
            this.panelDetail.Controls.Add(this.btnBrowseImage);
            this.panelDetail.Controls.Add(this.panelImage);
            this.panelDetail.Controls.Add(this.lblDetailTitle);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(5, 5);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(386, 470);
            this.panelDetail.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(115, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 32);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "❌ Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(15, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 32);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "💾 Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Location = new System.Drawing.Point(85, 370);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 50);
            this.txtDescription.TabIndex = 24;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescription.Location = new System.Drawing.Point(15, 373);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(41, 15);
            this.lblDescription.TabIndex = 23;
            this.lblDescription.Text = "Mô tả:";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLocation.Location = new System.Drawing.Point(85, 340);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(200, 23);
            this.txtLocation.TabIndex = 22;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocation.Location = new System.Drawing.Point(15, 343);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(37, 15);
            this.lblLocation.TabIndex = 21;
            this.lblLocation.Text = "Vị trí:";
            // 
            // numTotalCopies
            // 
            this.numTotalCopies.Location = new System.Drawing.Point(85, 310);
            this.numTotalCopies.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTotalCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTotalCopies.Name = "numTotalCopies";
            this.numTotalCopies.Size = new System.Drawing.Size(70, 23);
            this.numTotalCopies.TabIndex = 20;
            this.numTotalCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTotalCopies
            // 
            this.lblTotalCopies.AutoSize = true;
            this.lblTotalCopies.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalCopies.Location = new System.Drawing.Point(15, 312);
            this.lblTotalCopies.Name = "lblTotalCopies";
            this.lblTotalCopies.Size = new System.Drawing.Size(58, 15);
            this.lblTotalCopies.TabIndex = 19;
            this.lblTotalCopies.Text = "Số lượng:";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(85, 280);
            this.numPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(100, 23);
            this.numPrice.TabIndex = 18;
            this.numPrice.ThousandsSeparator = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrice.Location = new System.Drawing.Point(15, 282);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(28, 15);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Giá:";
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(85, 250);
            this.numYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(80, 23);
            this.numYear.TabIndex = 16;
            this.numYear.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblYear.Location = new System.Drawing.Point(15, 252);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 15);
            this.lblYear.TabIndex = 15;
            this.lblYear.Text = "Năm XB:";
            // 
            // cboPublisher
            // 
            this.cboPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPublisher.FormattingEnabled = true;
            this.cboPublisher.Location = new System.Drawing.Point(85, 220);
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(200, 23);
            this.cboPublisher.TabIndex = 14;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPublisher.Location = new System.Drawing.Point(15, 223);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(32, 15);
            this.lblPublisher.TabIndex = 13;
            this.lblPublisher.Text = "NXB:";
            // 
            // cboAuthorDetail
            // 
            this.cboAuthorDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthorDetail.FormattingEnabled = true;
            this.cboAuthorDetail.Location = new System.Drawing.Point(85, 190);
            this.cboAuthorDetail.Name = "cboAuthorDetail";
            this.cboAuthorDetail.Size = new System.Drawing.Size(200, 23);
            this.cboAuthorDetail.TabIndex = 12;
            // 
            // lblAuthorDetail
            // 
            this.lblAuthorDetail.AutoSize = true;
            this.lblAuthorDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAuthorDetail.Location = new System.Drawing.Point(15, 193);
            this.lblAuthorDetail.Name = "lblAuthorDetail";
            this.lblAuthorDetail.Size = new System.Drawing.Size(51, 15);
            this.lblAuthorDetail.TabIndex = 11;
            this.lblAuthorDetail.Text = "Tác giả:";
            // 
            // cboCategoryDetail
            // 
            this.cboCategoryDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoryDetail.FormattingEnabled = true;
            this.cboCategoryDetail.Location = new System.Drawing.Point(85, 160);
            this.cboCategoryDetail.Name = "cboCategoryDetail";
            this.cboCategoryDetail.Size = new System.Drawing.Size(200, 23);
            this.cboCategoryDetail.TabIndex = 10;
            // 
            // lblCategoryDetail
            // 
            this.lblCategoryDetail.AutoSize = true;
            this.lblCategoryDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCategoryDetail.Location = new System.Drawing.Point(15, 163);
            this.lblCategoryDetail.Name = "lblCategoryDetail";
            this.lblCategoryDetail.Size = new System.Drawing.Size(51, 15);
            this.lblCategoryDetail.TabIndex = 9;
            this.lblCategoryDetail.Text = "Thể loại:";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookTitle.Location = new System.Drawing.Point(85, 130);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(200, 23);
            this.txtBookTitle.TabIndex = 8;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookTitle.Location = new System.Drawing.Point(15, 133);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(57, 15);
            this.lblBookTitle.TabIndex = 7;
            this.lblBookTitle.Text = "Tên sách:";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtISBN.Location = new System.Drawing.Point(85, 100);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(200, 23);
            this.txtISBN.TabIndex = 6;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblISBN.Location = new System.Drawing.Point(15, 103);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 15);
            this.lblISBN.TabIndex = 5;
            this.lblISBN.Text = "ISBN:";
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnViewDetail.FlatAppearance.BorderSize = 0;
            this.btnViewDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetail.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnViewDetail.ForeColor = System.Drawing.Color.White;
            this.btnViewDetail.Location = new System.Drawing.Point(145, 70);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(140, 25);
            this.btnViewDetail.TabIndex = 4;
            this.btnViewDetail.Text = "Xem chi tiết";
            this.btnViewDetail.UseVisualStyleBackColor = false;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRemoveImage.FlatAppearance.BorderSize = 0;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveImage.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRemoveImage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveImage.Location = new System.Drawing.Point(220, 40);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(65, 25);
            this.btnRemoveImage.TabIndex = 3;
            this.btnRemoveImage.Text = "Xóa ảnh";
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBrowseImage.FlatAppearance.BorderSize = 0;
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImage.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBrowseImage.ForeColor = System.Drawing.Color.White;
            this.btnBrowseImage.Location = new System.Drawing.Point(145, 40);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(70, 25);
            this.btnBrowseImage.TabIndex = 2;
            this.btnBrowseImage.Text = "Chọn ảnh";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImage.Controls.Add(this.picBookImage);
            this.panelImage.Location = new System.Drawing.Point(15, 40);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(120, 55);
            this.panelImage.TabIndex = 1;
            // 
            // picBookImage
            // 
            this.picBookImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.picBookImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBookImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBookImage.Location = new System.Drawing.Point(0, 0);
            this.picBookImage.Name = "picBookImage";
            this.picBookImage.Size = new System.Drawing.Size(118, 53);
            this.picBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBookImage.TabIndex = 0;
            this.picBookImage.TabStop = false;
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.AutoSize = true;
            this.lblDetailTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDetailTitle.Location = new System.Drawing.Point(15, 10);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(118, 21);
            this.lblDetailTitle.TabIndex = 0;
            this.lblDetailTitle.Text = "Thông tin sách";
            // 
            // FormBookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1240, 540);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panelTop);
            this.Name = "FormBookManagement";
            this.Text = "Quản lý sách";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBookImage)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ComboBox cboAuthor;
        private System.Windows.Forms.CheckBox chkAvailableOnly;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalCopies;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailableCopies;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox picBookImage;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblCategoryDetail;
        private System.Windows.Forms.ComboBox cboCategoryDetail;
        private System.Windows.Forms.Label lblAuthorDetail;
        private System.Windows.Forms.ComboBox cboAuthorDetail;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.ComboBox cboPublisher;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblTotalCopies;
        private System.Windows.Forms.NumericUpDown numTotalCopies;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
