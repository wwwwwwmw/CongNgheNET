namespace LibraryManagement.Forms
{
    partial class FormReport
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
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnBorrowReturnDetails = new System.Windows.Forms.Button();
            this.lblQuickActions = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cboReportType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.panelStats = new System.Windows.Forms.Panel();
            this.lblSummary = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panelStats.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(277, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỐNG KÊ - BÁO CÁO";
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.btnBorrowReturnDetails);
            this.panelFilter.Controls.Add(this.lblQuickActions);
            this.panelFilter.Controls.Add(this.btnPrint);
            this.panelFilter.Controls.Add(this.btnExport);
            this.panelFilter.Controls.Add(this.btnGenerate);
            this.panelFilter.Controls.Add(this.dtpTo);
            this.panelFilter.Controls.Add(this.lblTo);
            this.panelFilter.Controls.Add(this.dtpFrom);
            this.panelFilter.Controls.Add(this.lblFrom);
            this.panelFilter.Controls.Add(this.cboReportType);
            this.panelFilter.Controls.Add(this.lblType);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 50);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelFilter.Size = new System.Drawing.Size(1220, 100);
            this.panelFilter.TabIndex = 1;
            // 
            // btnBorrowReturnDetails
            // 
            this.btnBorrowReturnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBorrowReturnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrowReturnDetails.FlatAppearance.BorderSize = 0;
            this.btnBorrowReturnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowReturnDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBorrowReturnDetails.ForeColor = System.Drawing.Color.White;
            this.btnBorrowReturnDetails.Location = new System.Drawing.Point(95, 57);
            this.btnBorrowReturnDetails.Name = "btnBorrowReturnDetails";
            this.btnBorrowReturnDetails.Size = new System.Drawing.Size(80, 32);
            this.btnBorrowReturnDetails.TabIndex = 10;
            this.btnBorrowReturnDetails.Text = "Mượn/Trả";
            this.btnBorrowReturnDetails.UseVisualStyleBackColor = false;
            // 
            // lblQuickActions
            // 
            this.lblQuickActions.AutoSize = true;
            this.lblQuickActions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuickActions.Location = new System.Drawing.Point(15, 62);
            this.lblQuickActions.Name = "lblQuickActions";
            this.lblQuickActions.Size = new System.Drawing.Size(74, 15);
            this.lblQuickActions.TabIndex = 9;
            this.lblQuickActions.Text = "Xem chi tiết:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(825, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(50, 32);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(730, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 32);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(630, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(90, 32);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Tạo báo cáo";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(495, 14);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(120, 23);
            this.dtpTo.TabIndex = 5;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTo.Location = new System.Drawing.Point(460, 17);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(33, 15);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "Đến:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(330, 14);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(120, 23);
            this.dtpFrom.TabIndex = 3;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFrom.Location = new System.Drawing.Point(305, 17);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(24, 15);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Từ:";
            // 
            // cboReportType
            // 
            this.cboReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReportType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboReportType.FormattingEnabled = true;
            this.cboReportType.Items.AddRange(new object[] {
            "Tổng quan",
            "Sách mượn nhiều nhất",
            "Độc giả mượn nhiều nhất",
            "Sách quá hạn",
            "Thống kê theo ngày",
            "Danh sách phạt chưa thu",
            "Danh sách sách hết"});
            this.cboReportType.Location = new System.Drawing.Point(70, 14);
            this.cboReportType.Name = "cboReportType";
            this.cboReportType.Size = new System.Drawing.Size(220, 23);
            this.cboReportType.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblType.Location = new System.Drawing.Point(15, 17);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(53, 15);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Báo cáo:";
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.AutoScroll = true;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.dgvReport);
            this.panelContent.Location = new System.Drawing.Point(20, 160);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1180, 360);
            this.panelContent.TabIndex = 2;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(0, 0);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(1180, 360);
            this.dgvReport.TabIndex = 0;
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelStats.Controls.Add(this.lblSummary);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStats.Location = new System.Drawing.Point(0, 530);
            this.panelStats.Name = "panelStats";
            this.panelStats.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.panelStats.Size = new System.Drawing.Size(1220, 50);
            this.panelStats.TabIndex = 3;
            // 
            // lblSummary
            // 
            this.lblSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSummary.Location = new System.Drawing.Point(20, 5);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(1180, 40);
            this.lblSummary.TabIndex = 0;
            this.lblSummary.Text = "📊 Chọn loại báo cáo và nhấn \"Tạo báo cáo\" để xem thống kê";
            this.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1220, 580);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.Name = "FormReport";
            this.Text = "Thống kê - Báo cáo";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panelStats.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboReportType;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblQuickActions;
        private System.Windows.Forms.Button btnBorrowReturnDetails;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblSummary;
    }
}
