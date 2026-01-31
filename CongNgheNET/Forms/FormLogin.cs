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

    /// <summary>
    /// Form cấu hình kết nối SQL Server
    /// </summary>
    public class FormConnectionConfig : Form
    {
        private TextBox txtServer = null!;
        private TextBox txtDatabase = null!;
        private RadioButton rbWindowsAuth = null!;
        private RadioButton rbSqlAuth = null!;
        private TextBox txtUserId = null!;
        private TextBox txtPassword = null!;
        private Button btnTest = null!;
        private Button btnSave = null!;
        private Label lblStatus = null!;

        public FormConnectionConfig()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Cấu hình kết nối";
            this.Size = new Size(450, 380);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Server
            var lblServer = new Label { Text = "Server:", Location = new Point(20, 25), AutoSize = true };
            txtServer = new TextBox { Location = new Point(150, 22), Size = new Size(260, 25), Text = "." };

            // Database
            var lblDatabase = new Label { Text = "Database:", Location = new Point(20, 60), AutoSize = true };
            txtDatabase = new TextBox { Location = new Point(150, 57), Size = new Size(260, 25), Text = "LibraryManagement" };

            // Auth type
            var lblAuth = new Label { Text = "Xác thực:", Location = new Point(20, 95), AutoSize = true };
            rbWindowsAuth = new RadioButton
            {
                Text = "Windows Authentication",
                Location = new Point(150, 93),
                AutoSize = true,
                Checked = true
            };
            rbWindowsAuth.CheckedChanged += (s, e) =>
            {
                txtUserId.Enabled = !rbWindowsAuth.Checked;
                txtPassword.Enabled = !rbWindowsAuth.Checked;
            };

            rbSqlAuth = new RadioButton
            {
                Text = "SQL Server Authentication",
                Location = new Point(150, 118),
                AutoSize = true
            };

            // SQL Auth fields
            var lblUserId = new Label { Text = "User ID:", Location = new Point(20, 155), AutoSize = true };
            txtUserId = new TextBox { Location = new Point(150, 152), Size = new Size(260, 25), Enabled = false };

            var lblPassword = new Label { Text = "Password:", Location = new Point(20, 190), AutoSize = true };
            txtPassword = new TextBox { Location = new Point(150, 187), Size = new Size(260, 25), PasswordChar = '*', Enabled = false };

            // Status
            lblStatus = new Label
            {
                Location = new Point(20, 230),
                Size = new Size(400, 25),
                ForeColor = Color.Blue
            };

            // Buttons
            btnTest = new Button
            {
                Text = "Test kết nối",
                Location = new Point(150, 270),
                Size = new Size(100, 35),
                BackColor = Color.FromArgb(52, 152, 219),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnTest.FlatAppearance.BorderSize = 0;
            btnTest.Click += BtnTest_Click;

            btnSave = new Button
            {
                Text = "Lưu",
                Location = new Point(260, 270),
                Size = new Size(80, 35),
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Click += BtnSave_Click;

            var btnCancel = new Button
            {
                Text = "Hủy",
                Location = new Point(350, 270),
                Size = new Size(70, 35),
                BackColor = Color.FromArgb(149, 165, 166),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click += (s, e) => this.Close();

            this.Controls.AddRange(new Control[] {
                lblServer, txtServer, lblDatabase, txtDatabase,
                lblAuth, rbWindowsAuth, rbSqlAuth,
                lblUserId, txtUserId, lblPassword, txtPassword,
                lblStatus, btnTest, btnSave, btnCancel
            });
        }

        private void BtnTest_Click(object? sender, EventArgs e)
        {
            string connStr = BuildConnectionString();
            lblStatus.Text = "Đang kiểm tra kết nối...";
            lblStatus.ForeColor = Color.Blue;
            Application.DoEvents();

            if (DatabaseConnection.TestConnection(connStr, out string error))
            {
                lblStatus.Text = "✓ Kết nối thành công!";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text = $"✗ Lỗi: {error}";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            DatabaseConnection.UpdateConnectionString(
                txtServer.Text,
                txtDatabase.Text,
                rbWindowsAuth.Checked,
                txtUserId.Text,
                txtPassword.Text
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private string BuildConnectionString()
        {
            var builder = new Microsoft.Data.SqlClient.SqlConnectionStringBuilder
            {
                DataSource = txtServer.Text,
                InitialCatalog = txtDatabase.Text,
                IntegratedSecurity = rbWindowsAuth.Checked,
                TrustServerCertificate = true
            };

            if (!rbWindowsAuth.Checked)
            {
                builder.UserID = txtUserId.Text;
                builder.Password = txtPassword.Text;
            }

            return builder.ConnectionString;
        }
    }
}
