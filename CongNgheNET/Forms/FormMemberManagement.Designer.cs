namespace LibraryManagement.Forms
{
    partial class FormMemberManagement
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
            this.chkActiveOnly = new System.Windows.Forms.CheckBox();
            this.cboMemberType = new System.Windows.Forms.ComboBox();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPayFine = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.colMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblTotalFine = new System.Windows.Forms.Label();
            this.lblTotalFineLabel = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.cboMemberTypeDetail = new System.Windows.Forms.ComboBox();
            this.lblMemberTypeDetail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtIdentityCard = new System.Windows.Forms.TextBox();
            this.lblIdentityCard = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.lblMemberCode = new System.Windows.Forms.Label();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.chkActiveOnly);
            this.panelTop.Controls.Add(this.cboMemberType);
            this.panelTop.Controls.Add(this.lblMemberType);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1240, 60);
            this.panelTop.TabIndex = 0;
            // 
            // chkActiveOnly
            // 
            this.chkActiveOnly.AutoSize = true;
            this.chkActiveOnly.Checked = true;
            this.chkActiveOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActiveOnly.Location = new System.Drawing.Point(720, 20);
            this.chkActiveOnly.Name = "chkActiveOnly";
            this.chkActiveOnly.Size = new System.Drawing.Size(130, 19);
            this.chkActiveOnly.TabIndex = 5;
            this.chkActiveOnly.Text = "Chỉ đang hoạt động";
            this.chkActiveOnly.UseVisualStyleBackColor = true;
            // 
            // cboMemberType
            // 
            this.cboMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberType.FormattingEnabled = true;
            this.cboMemberType.Location = new System.Drawing.Point(560, 17);
            this.cboMemberType.Name = "cboMemberType";
            this.cboMemberType.Size = new System.Drawing.Size(150, 23);
            this.cboMemberType.TabIndex = 4;
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Location = new System.Drawing.Point(500, 21);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(54, 15);
            this.lblMemberType.TabIndex = 3;
            this.lblMemberType.Text = "Loại thẻ:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(420, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(200, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm theo mã, tên, SĐT...";
            this.txtSearch.Size = new System.Drawing.Size(210, 25);
            this.txtSearch.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "👥 QUẢN LÝ ĐỘC GIẢ";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 60);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelButtons);
            this.splitContainer.Panel1.Controls.Add(this.dgvMembers);
            this.splitContainer.Panel1MinSize = 600;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelDetail);
            this.splitContainer.Panel2MinSize = 350;
            this.splitContainer.Size = new System.Drawing.Size(1240, 480);
            this.splitContainer.SplitterDistance = 830;
            this.splitContainer.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnRefresh);
            this.panelButtons.Controls.Add(this.btnPayFine);
            this.panelButtons.Controls.Add(this.btnHistory);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnEdit);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 430);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(830, 50);
            this.panelButtons.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(540, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 35);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnPayFine
            // 
            this.btnPayFine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnPayFine.FlatAppearance.BorderSize = 0;
            this.btnPayFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayFine.ForeColor = System.Drawing.Color.White;
            this.btnPayFine.Location = new System.Drawing.Point(430, 8);
            this.btnPayFine.Name = "btnPayFine";
            this.btnPayFine.Size = new System.Drawing.Size(100, 35);
            this.btnPayFine.TabIndex = 4;
            this.btnPayFine.Text = "Đóng phạt";
            this.btnPayFine.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(310, 8);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(110, 35);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "Lịch sử mượn";
            this.btnHistory.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(210, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(110, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(10, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembers.BackgroundColor = System.Drawing.Color.White;
            this.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemberID,
            this.colMemberCode,
            this.colFullName,
            this.colGender,
            this.colPhone,
            this.colMemberType,
            this.colExpiryDate,
            this.colTotalFine,
            this.colStatus});
            this.dgvMembers.Location = new System.Drawing.Point(10, 10);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(810, 415);
            this.dgvMembers.TabIndex = 0;
            // 
            // colMemberID
            // 
            this.colMemberID.HeaderText = "ID";
            this.colMemberID.Name = "colMemberID";
            this.colMemberID.ReadOnly = true;
            this.colMemberID.Visible = false;
            // 
            // colMemberCode
            // 
            this.colMemberCode.HeaderText = "Mã thẻ";
            this.colMemberCode.Name = "colMemberCode";
            this.colMemberCode.ReadOnly = true;
            this.colMemberCode.Width = 70;
            // 
            // colFullName
            // 
            this.colFullName.HeaderText = "Họ tên";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Width = 140;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Giới tính";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.Width = 75;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Điện thoại";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colMemberType
            // 
            this.colMemberType.HeaderText = "Loại thẻ";
            this.colMemberType.Name = "colMemberType";
            this.colMemberType.ReadOnly = true;
            this.colMemberType.Width = 85;
            // 
            // colExpiryDate
            // 
            this.colExpiryDate.HeaderText = "Hạn thẻ";
            this.colExpiryDate.Name = "colExpiryDate";
            this.colExpiryDate.ReadOnly = true;
            this.colExpiryDate.Width = 95;
            // 
            // colTotalFine
            // 
            this.colTotalFine.HeaderText = "Nợ phạt";
            this.colTotalFine.Name = "colTotalFine";
            this.colTotalFine.ReadOnly = true;
            this.colTotalFine.Width = 80;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 85;
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.White;
            this.panelDetail.Controls.Add(this.btnCancel);
            this.panelDetail.Controls.Add(this.btnSave);
            this.panelDetail.Controls.Add(this.txtNotes);
            this.panelDetail.Controls.Add(this.lblNotes);
            this.panelDetail.Controls.Add(this.lblTotalFine);
            this.panelDetail.Controls.Add(this.lblTotalFineLabel);
            this.panelDetail.Controls.Add(this.dtpExpiryDate);
            this.panelDetail.Controls.Add(this.lblExpiryDate);
            this.panelDetail.Controls.Add(this.cboMemberTypeDetail);
            this.panelDetail.Controls.Add(this.lblMemberTypeDetail);
            this.panelDetail.Controls.Add(this.txtAddress);
            this.panelDetail.Controls.Add(this.lblAddress);
            this.panelDetail.Controls.Add(this.txtIdentityCard);
            this.panelDetail.Controls.Add(this.lblIdentityCard);
            this.panelDetail.Controls.Add(this.txtEmail);
            this.panelDetail.Controls.Add(this.lblEmail);
            this.panelDetail.Controls.Add(this.txtPhone);
            this.panelDetail.Controls.Add(this.lblPhone);
            this.panelDetail.Controls.Add(this.dtpDateOfBirth);
            this.panelDetail.Controls.Add(this.lblDateOfBirth);
            this.panelDetail.Controls.Add(this.cboGender);
            this.panelDetail.Controls.Add(this.lblGender);
            this.panelDetail.Controls.Add(this.txtFullName);
            this.panelDetail.Controls.Add(this.lblFullName);
            this.panelDetail.Controls.Add(this.txtMemberCode);
            this.panelDetail.Controls.Add(this.lblMemberCode);
            this.panelDetail.Controls.Add(this.lblDetailTitle);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Padding = new System.Windows.Forms.Padding(15);
            this.panelDetail.Size = new System.Drawing.Size(406, 480);
            this.panelDetail.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(125, 435);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "❌ Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(15, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "💾 Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(105, 380);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(250, 45);
            this.txtNotes.TabIndex = 24;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNotes.Location = new System.Drawing.Point(15, 383);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(50, 15);
            this.lblNotes.TabIndex = 23;
            this.lblNotes.Text = "Ghi chú:";
            // 
            // lblTotalFine
            // 
            this.lblTotalFine.AutoSize = true;
            this.lblTotalFine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalFine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblTotalFine.Location = new System.Drawing.Point(105, 355);
            this.lblTotalFine.Name = "lblTotalFine";
            this.lblTotalFine.Size = new System.Drawing.Size(29, 19);
            this.lblTotalFine.TabIndex = 22;
            this.lblTotalFine.Text = "0 đ";
            // 
            // lblTotalFineLabel
            // 
            this.lblTotalFineLabel.AutoSize = true;
            this.lblTotalFineLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalFineLabel.Location = new System.Drawing.Point(15, 355);
            this.lblTotalFineLabel.Name = "lblTotalFineLabel";
            this.lblTotalFineLabel.Size = new System.Drawing.Size(55, 15);
            this.lblTotalFineLabel.TabIndex = 21;
            this.lblTotalFineLabel.Text = "Nợ phạt:";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiryDate.Location = new System.Drawing.Point(105, 320);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(150, 23);
            this.dtpExpiryDate.TabIndex = 20;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblExpiryDate.Location = new System.Drawing.Point(15, 323);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(52, 15);
            this.lblExpiryDate.TabIndex = 19;
            this.lblExpiryDate.Text = "Hạn thẻ:";
            // 
            // cboMemberTypeDetail
            // 
            this.cboMemberTypeDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberTypeDetail.FormattingEnabled = true;
            this.cboMemberTypeDetail.Location = new System.Drawing.Point(105, 288);
            this.cboMemberTypeDetail.Name = "cboMemberTypeDetail";
            this.cboMemberTypeDetail.Size = new System.Drawing.Size(150, 23);
            this.cboMemberTypeDetail.TabIndex = 18;
            // 
            // lblMemberTypeDetail
            // 
            this.lblMemberTypeDetail.AutoSize = true;
            this.lblMemberTypeDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMemberTypeDetail.Location = new System.Drawing.Point(15, 291);
            this.lblMemberTypeDetail.Name = "lblMemberTypeDetail";
            this.lblMemberTypeDetail.Size = new System.Drawing.Size(54, 15);
            this.lblMemberTypeDetail.TabIndex = 17;
            this.lblMemberTypeDetail.Text = "Loại thẻ:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.Location = new System.Drawing.Point(105, 256);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 23);
            this.txtAddress.TabIndex = 16;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddress.Location = new System.Drawing.Point(15, 259);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 15);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // txtIdentityCard
            // 
            this.txtIdentityCard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdentityCard.Location = new System.Drawing.Point(105, 224);
            this.txtIdentityCard.Name = "txtIdentityCard";
            this.txtIdentityCard.Size = new System.Drawing.Size(150, 23);
            this.txtIdentityCard.TabIndex = 14;
            // 
            // lblIdentityCard
            // 
            this.lblIdentityCard.AutoSize = true;
            this.lblIdentityCard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIdentityCard.Location = new System.Drawing.Point(15, 227);
            this.lblIdentityCard.Name = "lblIdentityCard";
            this.lblIdentityCard.Size = new System.Drawing.Size(41, 15);
            this.lblIdentityCard.TabIndex = 13;
            this.lblIdentityCard.Text = "CCCD:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(105, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 23);
            this.txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.Location = new System.Drawing.Point(15, 195);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(105, 160);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 23);
            this.txtPhone.TabIndex = 10;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.Location = new System.Drawing.Point(15, 163);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 15);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Điện thoại:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(105, 128);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(150, 23);
            this.dtpDateOfBirth.TabIndex = 8;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDateOfBirth.Location = new System.Drawing.Point(15, 131);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(62, 15);
            this.lblDateOfBirth.TabIndex = 7;
            this.lblDateOfBirth.Text = "Ngày sinh:";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(105, 96);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(100, 23);
            this.cboGender.TabIndex = 6;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGender.Location = new System.Drawing.Point(15, 99);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(57, 15);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Giới tính:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.Location = new System.Drawing.Point(105, 64);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(250, 23);
            this.txtFullName.TabIndex = 4;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFullName.Location = new System.Drawing.Point(15, 67);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(48, 15);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Họ tên:";
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtMemberCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMemberCode.Location = new System.Drawing.Point(105, 35);
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.ReadOnly = true;
            this.txtMemberCode.Size = new System.Drawing.Size(150, 23);
            this.txtMemberCode.TabIndex = 2;
            // 
            // lblMemberCode
            // 
            this.lblMemberCode.AutoSize = true;
            this.lblMemberCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMemberCode.Location = new System.Drawing.Point(15, 38);
            this.lblMemberCode.Name = "lblMemberCode";
            this.lblMemberCode.Size = new System.Drawing.Size(47, 15);
            this.lblMemberCode.TabIndex = 1;
            this.lblMemberCode.Text = "Mã thẻ:";
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.AutoSize = true;
            this.lblDetailTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDetailTitle.Location = new System.Drawing.Point(15, 10);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(173, 21);
            this.lblDetailTitle.TabIndex = 0;
            this.lblDetailTitle.Text = "👤 Thông tin độc giả";
            // 
            // FormMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1240, 540);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panelTop);
            this.Name = "FormMemberManagement";
            this.Text = "Quản lý độc giả";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.ComboBox cboMemberType;
        private System.Windows.Forms.CheckBox chkActiveOnly;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnPayFine;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.Label lblMemberCode;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblIdentityCard;
        private System.Windows.Forms.TextBox txtIdentityCard;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblMemberTypeDetail;
        private System.Windows.Forms.ComboBox cboMemberTypeDetail;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label lblTotalFineLabel;
        private System.Windows.Forms.Label lblTotalFine;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
