using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    /// <summary>
    /// Form đăng nhập hệ thống
    /// </summary>
    public partial class FormLogin : Form
    {
        private int loginAttempts = 0;
        private const int MAX_ATTEMPTS = 3;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Test database connection
            if (!DatabaseConnection.TestConnection(out string error))
            {
                lblStatus.Text = "⚠ Không thể kết nối CSDL. Kiểm tra cấu hình.";
                lblStatus.ForeColor = Color.Orange;
            }
            else
            {
                lblStatus.Text = "✓ Đã kết nối đến máy chủ";
                lblStatus.ForeColor = Color.Green;
            }

            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ShowError("Vui lòng nhập tên đăng nhập!");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowError("Vui lòng nhập mật khẩu!");
                txtPassword.Focus();
                return;
            }

            try
            {
                btnLogin.Enabled = false;
                lblStatus.Text = "Đang đăng nhập...";
                lblStatus.ForeColor = Color.Blue;
                Application.DoEvents();

                var userDAO = new UserDAO();
                var user = userDAO.Login(txtUsername.Text.Trim(), txtPassword.Text);

                if (user != null)
                {
                    // Login success
                    CurrentUser.Login(user);

                    // Log activity
                    var logDAO = new ActivityLogDAO();
                    logDAO.Log("Đăng nhập hệ thống", "Users", user.UserID);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    loginAttempts++;

                    if (loginAttempts >= MAX_ATTEMPTS)
                    {
                        ShowError($"Đăng nhập thất bại {MAX_ATTEMPTS} lần. Ứng dụng sẽ đóng.");
                        this.Close();
                    }
                    else
                    {
                        ShowError($"Sai tên đăng nhập hoặc mật khẩu! (Còn {MAX_ATTEMPTS - loginAttempts} lần thử)");
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError($"Lỗi kết nối: {ex.Message}");
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            using (var configForm = new FormConnectionConfig())
            {
                if (configForm.ShowDialog() == DialogResult.OK)
                {
                    // Reload connection status
                    FormLogin_Load(sender, e);
                }
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }

        private void ShowError(string message)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = Color.Red;
        }
    }
}
