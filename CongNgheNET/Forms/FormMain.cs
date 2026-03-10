using System;
using System.Windows.Forms;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    public partial class FormMain : Form
    {
        private User? currentUser;
        private Form? activeForm;

        public FormMain(User user)
        {
            InitializeComponent();
            currentUser = user;
            if (currentUser != null)
                lblUser.Text = currentUser.FullName;
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(childForm);
            childForm.Show();
        }
    }
}
