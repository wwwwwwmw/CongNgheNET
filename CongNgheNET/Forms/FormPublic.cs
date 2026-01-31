using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    /// <summary>
    /// Form công khai - Cho phép xem sách không cần đăng nhập
    /// </summary>
    public partial class FormPublic : Form
    {
        private BookDAO bookDAO = new BookDAO();
        private List<Book> allBooks = new List<Book>();

        public FormPublic()
        {
            InitializeComponent();
            SetupEvents();
            LoadCategories();
            LoadBooks();
        }

        private void SetupEvents()
        {
            // Đăng ký sự kiện cho các controls đã tạo trong Designer
            btnRegister.Click += (s, e) =>
            {
                MessageBox.Show("Để đăng ký thẻ thư viện, vui lòng:\n\n" +
                    "1. Đến trực tiếp thư viện với CMND/CCCD\n" +
                    "2. Điền đơn đăng ký\n" +
                    "3. Nhận thẻ và tài khoản\n\n" +
                    "📞 Liên hệ: 0123-456-789\n" +
                    "📍 Địa chỉ: 123 Đường ABC, Quận XYZ",
                    "Hướng dẫn đăng ký thẻ thư viện", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            btnLogin.Click += BtnLogin_Click;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            cboCategory.SelectedIndexChanged += CboCategory_SelectedIndexChanged;
            btnReset.Click += (s, e) => LoadBooks();
        }

        private void LoadCategories()
        {
            try
            {
                cboCategory.Items.Clear();
                cboCategory.Items.Add(new ComboBoxItem { Value = 0, Text = "-- Tất cả thể loại --" });

                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT CategoryID, CategoryName FROM Categories WHERE IsActive = 1 ORDER BY CategoryName";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cboCategory.Items.Add(new ComboBoxItem
                                {
                                    Value = reader.GetInt32(0),
                                    Text = reader.GetString(1)
                                });
                            }
                        }
                    }
                }

                cboCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thể loại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBooks()
        {
            try
            {
                allBooks = bookDAO.GetAll();
                DisplayBooks(allBooks);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sách: " + ex.Message + "\n\nVui lòng kiểm tra kết nối database.",
                    "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayBooks(List<Book> books)
        {
            flowBooks.Controls.Clear();
            lblTotalBooks.Text = $"Tổng: {books.Count} sách";

            foreach (var book in books)
            {
                var card = CreateBookCard(book);
                flowBooks.Controls.Add(card);
            }
        }

        private Panel CreateBookCard(Book book)
        {
            Panel card = new Panel
            {
                Size = new Size(220, 320),
                BackColor = Color.White,
                Margin = new Padding(10),
                Cursor = Cursors.Hand,
                Tag = book
            };

            // Border
            card.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                    Color.FromArgb(230, 230, 230), ButtonBorderStyle.Solid);
            };

            // Book Image
            PictureBox picBook = new PictureBox
            {
                Size = new Size(200, 180),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(245, 245, 245)
            };

            // Load image
            if (!string.IsNullOrEmpty(book.ImagePath))
            {
                string imagePath = Path.Combine(Application.StartupPath, "Images", book.ImagePath);
                if (File.Exists(imagePath))
                {
                    try
                    {
                        picBook.Image = Image.FromFile(imagePath);
                    }
                    catch
                    {
                        picBook.Image = null;
                    }
                }
            }

            if (picBook.Image == null)
            {
                // Default book icon
                Label lblNoImage = new Label
                {
                    Text = "📖",
                    Font = new Font("Segoe UI", 48),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                picBook.Controls.Add(lblNoImage);
            }

            // Title
            Label lblTitle = new Label
            {
                Text = book.Title,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(10, 195),
                Size = new Size(200, 40),
                MaximumSize = new Size(200, 40)
            };

            // Author
            Label lblAuthor = new Label
            {
                Text = "✍️ " + (book.AuthorName ?? "Chưa rõ"),
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Gray,
                Location = new Point(10, 235),
                Size = new Size(200, 20)
            };

            // Category
            Label lblCategory = new Label
            {
                Text = "📁 " + (book.CategoryName ?? "Chưa phân loại"),
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Gray,
                Location = new Point(10, 255),
                Size = new Size(200, 20)
            };

            // Status
            Label lblStatus = new Label
            {
                Text = book.AvailableCopies > 0 ? $"✅ Còn {book.AvailableCopies} cuốn" : "❌ Hết sách",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = book.AvailableCopies > 0 ? Color.FromArgb(46, 204, 113) : Color.FromArgb(231, 76, 60),
                Location = new Point(10, 280),
                Size = new Size(200, 25)
            };

            card.Controls.AddRange(new Control[] { picBook, lblTitle, lblAuthor, lblCategory, lblStatus });

            // Click event to show details
            card.Click += (s, e) => ShowBookDetail(book);
            foreach (Control c in card.Controls)
            {
                c.Click += (s, e) => ShowBookDetail(book);
            }

            // Hover effect
            card.MouseEnter += (s, e) => card.BackColor = Color.FromArgb(240, 248, 255);
            card.MouseLeave += (s, e) => card.BackColor = Color.White;

            return card;
        }

        private void ShowBookDetail(Book book)
        {
            using (var detailForm = new FormBookDetailPublic(book))
            {
                if (detailForm.ShowDialog() == DialogResult.Yes)
                {
                    // User wants to borrow -> need login
                    BtnLogin_Click(null, null);
                }
            }
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            FilterBooks();
        }

        private void CboCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            FilterBooks();
        }

        private void FilterBooks()
        {
            string searchText = txtSearch.Text.ToLower().Trim();
            int categoryId = (cboCategory.SelectedItem as ComboBoxItem)?.Value ?? 0;

            var filtered = allBooks.FindAll(b =>
            {
                bool matchSearch = string.IsNullOrEmpty(searchText) ||
                    b.Title.ToLower().Contains(searchText) ||
                    (b.AuthorName?.ToLower().Contains(searchText) ?? false) ||
                    (b.ISBN?.ToLower().Contains(searchText) ?? false);

                bool matchCategory = categoryId == 0 || b.CategoryID == categoryId;

                return matchSearch && matchCategory;
            });

            DisplayBooks(filtered);
        }

        private void BtnLogin_Click(object? sender, EventArgs? e)
        {
            using (var loginForm = new FormLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Login successful - open main form
                    this.Hide();
                    using (var mainForm = new FormMain())
                    {
                        mainForm.ShowDialog();
                    }
                    // After main form closed, show public form again or close
                    if (CurrentUser.User == null)
                    {
                        this.Show();
                        LoadBooks(); // Refresh
                    }
                    else
                    {
                        // Still logged in, maybe user closed window
                        CurrentUser.Logout();
                        this.Show();
                    }
                }
            }
        }
    }

    /// <summary>
    /// Helper class for ComboBox
    /// </summary>
    public class ComboBoxItem
    {
        public int Value { get; set; }
        public string Text { get; set; } = "";
        public override string ToString() => Text;
    }
}
