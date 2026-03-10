using LibraryManagement.Data;

namespace LibraryManagement.Forms
{
    public partial class FormReport : Form
    {
        private BookDAO bookDAO = new BookDAO();
        private MemberDAO memberDAO = new MemberDAO();
        private BorrowRecordDAO borrowRecordDAO = new BorrowRecordDAO();

        public FormReport()
        {
            InitializeComponent();
        }
    }
}
