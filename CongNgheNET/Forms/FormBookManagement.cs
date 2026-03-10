using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    public partial class FormBookManagement : Form
    {
        private BookDAO bookDAO = new BookDAO();
        private Book? selectedBook;

        public FormBookManagement()
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
