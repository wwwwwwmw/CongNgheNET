using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    public partial class FormReturn : Form
    {
        private BorrowRecordDAO borrowRecordDAO = new BorrowRecordDAO();
        private MemberDAO memberDAO = new MemberDAO();
        private Member? selectedMember;

        public FormReturn()
        {
            InitializeComponent();
        }
    }
}
