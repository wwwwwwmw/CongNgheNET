namespace LibraryManagement.Forms
{
    partial class FormBorrowReturnDetails
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.panelFilter = new System.Windows.Forms.Panel();
            this.cboFilterType = new System.Windows.Forms.ComboBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.lblTotalBorrowed = new System.Windows.Forms.Label();
            this.lblTotalReturned = new System.Windows.Forms.Label();
            this.lblTotalOverdue = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "FormBorrowReturnDetails";
            this.Text = "Chi tiet muon tra";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.ComboBox cboFilterType;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblTotalBorrowed;
        private System.Windows.Forms.Label lblTotalReturned;
        private System.Windows.Forms.Label lblTotalOverdue;
        private System.Windows.Forms.Button btnExport;
    }
}
