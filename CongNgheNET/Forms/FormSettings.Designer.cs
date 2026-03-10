namespace LibraryManagement.Forms
{
    partial class FormSettings
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabBorrow = new System.Windows.Forms.TabPage();
            this.tabFine = new System.Windows.Forms.TabPage();
            this.numMaxBorrowDays = new System.Windows.Forms.NumericUpDown();
            this.numMaxBooksPerMember = new System.Windows.Forms.NumericUpDown();
            this.numFinePerDay = new System.Windows.Forms.NumericUpDown();
            this.txtLibraryName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormSettings";
            this.Text = "Cai dat he thong";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabBorrow;
        private System.Windows.Forms.TabPage tabFine;
        private System.Windows.Forms.NumericUpDown numMaxBorrowDays;
        private System.Windows.Forms.NumericUpDown numMaxBooksPerMember;
        private System.Windows.Forms.NumericUpDown numFinePerDay;
        private System.Windows.Forms.TextBox txtLibraryName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
