using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    public partial class FormUserManagement : Form
    {
        private UserDAO userDAO = new UserDAO();
        private User? selectedUser;

        public FormUserManagement()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
        }
    }
}
