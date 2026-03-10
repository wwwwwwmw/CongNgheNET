using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    public partial class FormBorrow : Form
    {
        private BookDAO bookDAO = new BookDAO();
        private MemberDAO memberDAO = new MemberDAO();
        private BorrowRecordDAO borrowRecordDAO = new BorrowRecordDAO();
        private Member? selectedMember;

        public FormBorrow()
        {
            InitializeComponent();
        }
    }
}
