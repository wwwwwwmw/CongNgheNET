namespace LibraryManagement.Forms
{
    partial class FormBorrow
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.panelMember = new System.Windows.Forms.Panel();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.panelBook = new System.Windows.Forms.Panel();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.dgvBorrowList = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "FormBorrow";
            this.Text = "Muon sach";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel panelMember;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Panel panelBook;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridView dgvBorrowList;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnCancel;
    }
}
