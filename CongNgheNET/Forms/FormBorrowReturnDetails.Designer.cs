namespace LibraryManagement.Forms
{
    partial class FormBorrowReturnDetails
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBorrow = new System.Windows.Forms.TabPage();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.lblBorrowSummary = new System.Windows.Forms.Label();
            this.tabReturn = new System.Windows.Forms.TabPage();
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.lblReturnSummary = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.tabReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(984, 50);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(318, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHI TIẾT PHIẾU MƯỢN / TRẢ SÁCH";
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.lblFrom);
            this.panelFilter.Controls.Add(this.dtpFrom);
            this.panelFilter.Controls.Add(this.lblTo);
            this.panelFilter.Controls.Add(this.dtpTo);
            this.panelFilter.Controls.Add(this.btnFilter);
            this.panelFilter.Controls.Add(this.btnExport);
            this.panelFilter.Location = new System.Drawing.Point(20, 60);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(945, 50);
            this.panelFilter.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFrom.Location = new System.Drawing.Point(15, 15);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(55, 15);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Từ ngày:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(80, 12);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(130, 23);
            this.dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTo.Location = new System.Drawing.Point(225, 15);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(33, 15);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "Đến:";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(265, 12);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(130, 23);
            this.dtpTo.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(410, 9);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 32);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Lọc dữ liệu";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(520, 9);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(90, 32);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBorrow);
            this.tabControl.Controls.Add(this.tabReturn);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(20, 120);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(945, 440);
            this.tabControl.TabIndex = 2;
            // 
            // tabBorrow
            // 
            this.tabBorrow.BackColor = System.Drawing.Color.White;
            this.tabBorrow.Controls.Add(this.dgvBorrow);
            this.tabBorrow.Controls.Add(this.lblBorrowSummary);
            this.tabBorrow.Location = new System.Drawing.Point(4, 28);
            this.tabBorrow.Name = "tabBorrow";
            this.tabBorrow.Padding = new System.Windows.Forms.Padding(10);
            this.tabBorrow.Size = new System.Drawing.Size(937, 408);
            this.tabBorrow.TabIndex = 0;
            this.tabBorrow.Text = "Phiếu mượn";
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.AllowUserToAddRows = false;
            this.dgvBorrow.AllowUserToDeleteRows = false;
            this.dgvBorrow.BackgroundColor = System.Drawing.Color.White;
            this.dgvBorrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(10, 10);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.ReadOnly = true;
            this.dgvBorrow.RowHeadersVisible = false;
            this.dgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrow.Size = new System.Drawing.Size(915, 355);
            this.dgvBorrow.TabIndex = 0;
            // 
            // lblBorrowSummary
            // 
            this.lblBorrowSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBorrowSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblBorrowSummary.Location = new System.Drawing.Point(10, 370);
            this.lblBorrowSummary.Name = "lblBorrowSummary";
            this.lblBorrowSummary.Size = new System.Drawing.Size(900, 25);
            this.lblBorrowSummary.TabIndex = 1;
            // 
            // tabReturn
            // 
            this.tabReturn.BackColor = System.Drawing.Color.White;
            this.tabReturn.Controls.Add(this.dgvReturn);
            this.tabReturn.Controls.Add(this.lblReturnSummary);
            this.tabReturn.Location = new System.Drawing.Point(4, 28);
            this.tabReturn.Name = "tabReturn";
            this.tabReturn.Padding = new System.Windows.Forms.Padding(10);
            this.tabReturn.Size = new System.Drawing.Size(937, 408);
            this.tabReturn.TabIndex = 1;
            this.tabReturn.Text = "Phiếu trả";
            // 
            // dgvReturn
            // 
            this.dgvReturn.AllowUserToAddRows = false;
            this.dgvReturn.AllowUserToDeleteRows = false;
            this.dgvReturn.BackgroundColor = System.Drawing.Color.White;
            this.dgvReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturn.Location = new System.Drawing.Point(10, 10);
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.ReadOnly = true;
            this.dgvReturn.RowHeadersVisible = false;
            this.dgvReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturn.Size = new System.Drawing.Size(915, 355);
            this.dgvReturn.TabIndex = 0;
            // 
            // lblReturnSummary
            // 
            this.lblReturnSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReturnSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblReturnSummary.Location = new System.Drawing.Point(10, 370);
            this.lblReturnSummary.Name = "lblReturnSummary";
            this.lblReturnSummary.Size = new System.Drawing.Size(900, 25);
            this.lblReturnSummary.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(865, 570);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormBorrowReturnDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(984, 621);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormBorrowReturnDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết phiếu mượn / trả sách";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabBorrow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.tabReturn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBorrow;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.Label lblBorrowSummary;
        private System.Windows.Forms.TabPage tabReturn;
        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.Label lblReturnSummary;
        private System.Windows.Forms.Button btnClose;
    }
}
