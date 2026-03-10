namespace LibraryManagement.Forms
{
    partial class FormReturn
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
            this.dgvBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.dgvReturnList = new System.Windows.Forms.DataGridView();
            this.btnAddReturn = new System.Windows.Forms.Button();
            this.btnRemoveReturn = new System.Windows.Forms.Button();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblFine = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "FormReturn";
            this.Text = "Tra sach";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel panelMember;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.DataGridView dgvBorrowedBooks;
        private System.Windows.Forms.DataGridView dgvReturnList;
        private System.Windows.Forms.Button btnAddReturn;
        private System.Windows.Forms.Button btnRemoveReturn;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCancel;
    }
}
