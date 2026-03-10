using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    public partial class FormMemberManagement : Form
    {
        private MemberDAO memberDAO = new MemberDAO();
        private Member? selectedMember;

        public FormMemberManagement()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var members = memberDAO.GetAll();
        }
    }
}
