using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    public partial class FormPublic : Form
    {
        private BookDAO bookDAO = new BookDAO();

        public FormPublic()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var books = bookDAO.GetAll();
        }
    }
}
