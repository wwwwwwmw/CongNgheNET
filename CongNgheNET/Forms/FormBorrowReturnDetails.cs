using LibraryManagement.Data;

namespace LibraryManagement.Forms
{
    public partial class FormBorrowReturnDetails : Form
    {
        private BorrowRecordDAO borrowRecordDAO = new BorrowRecordDAO();

        public FormBorrowReturnDetails()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
        }
    }
}
