using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    /// <summary>
    /// Form xem chi tiết sách (công khai)
    /// </summary>
    public class FormBookDetailPublic : Form
    {
        private Book book;

        public FormBookDetailPublic(Book book)
        {
            this.book = book;
            InitializeComponent();
            LoadBookInfo();
        }

        private void InitializeComponent()
        {
            this.Text = $"Chi tiết sách: {book.Title}";
            this.Size = new Size(700, 500);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.White;
        }

        private void LoadBookInfo()
        {
            // === LEFT PANEL - Image and Status ===
            Panel panelLeft = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(200, this.ClientSize.Height),
                BackColor = Color.FromArgb(248, 249, 250)
            };

            PictureBox picBook = new PictureBox
            {
                Size = new Size(170, 220),
                Location = new Point(15, 20),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            if (!string.IsNullOrEmpty(book.ImagePath))
            {
                string imagePath = Path.Combine(Application.StartupPath, "Images", book.ImagePath);
                if (File.Exists(imagePath))
                {
                    try { picBook.Image = Image.FromFile(imagePath); }
                    catch { }
                }
            }

            if (picBook.Image == null)
            {
                Label lblNoImg = new Label
                {
                    Text = "📖",
                    Font = new Font("Segoe UI", 40),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                picBook.Controls.Add(lblNoImg);
            }
            panelLeft.Controls.Add(picBook);

            // Status label
            string statusText = book.AvailableCopies > 0
                ? $"✅ Còn sách"
                : $"❌ Hết sách";
            Color statusColor = book.AvailableCopies > 0 ? Color.FromArgb(46, 204, 113) : Color.FromArgb(231, 76, 60);

            Label lblStatus = new Label
            {
                Text = statusText,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = statusColor,
                Location = new Point(15, 250),
                AutoSize = true
            };
            panelLeft.Controls.Add(lblStatus);

            Label lblQuantity = new Label
            {
                Text = $"Số lượng: {book.AvailableCopies}/{book.TotalCopies} bản",
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(100, 100, 100),
                Location = new Point(15, 275),
                AutoSize = true
            };
            panelLeft.Controls.Add(lblQuantity);

            this.Controls.Add(panelLeft);

            // === RIGHT PANEL - Book Info ===
            Panel panelRight = new Panel
            {
                Location = new Point(200, 0),
                Size = new Size(485, this.ClientSize.Height - 60),
                BackColor = Color.White,
                Padding = new Padding(15),
                AutoScroll = true
            };

            int y = 15;

            // Title
            Label lblBookTitle = new Label
            {
                Text = book.Title,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(10, y),
                MaximumSize = new Size(450, 50),
                AutoSize = true
            };
            panelRight.Controls.Add(lblBookTitle);
            y += lblBookTitle.PreferredHeight + 15;

            // Info rows
            AddInfoRow("🔢 ISBN:", book.ISBN ?? "N/A", ref y, panelRight);
            AddInfoRow("✍️ Tác giả:", book.AuthorName ?? "Chưa rõ", ref y, panelRight);
            AddInfoRow("📁 Thể loại:", book.CategoryName ?? "Chưa phân loại", ref y, panelRight);
            AddInfoRow("🏢 NXB:", book.PublisherName ?? "N/A", ref y, panelRight);
            AddInfoRow("📅 Năm XB:", book.PublishYear?.ToString() ?? "N/A", ref y, panelRight);
            AddInfoRow("📍 Vị trí:", book.Location ?? "N/A", ref y, panelRight);
            AddInfoRow("💰 Giá trị:", book.Price > 0 ? book.Price.ToString("N0") + " đ" : "N/A", ref y, panelRight);

            y += 10;

            // Description
            Label lblDescTitle = new Label
            {
                Text = "📝 Mô tả:",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, y),
                AutoSize = true
            };
            panelRight.Controls.Add(lblDescTitle);
            y += 22;

            TextBox txtDesc = new TextBox
            {
                Text = string.IsNullOrEmpty(book.Description) ? "Chưa có mô tả" : book.Description,
                Font = new Font("Segoe UI", 9),
                Location = new Point(10, y),
                Size = new Size(450, 60),
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                BackColor = Color.FromArgb(250, 250, 250)
            };
            panelRight.Controls.Add(txtDesc);
            y += 70;

            // Fee note
            Label lblFeeNote = new Label
            {
                Text = "💡 Mượn sách MIỄN PHÍ | Chỉ thu phí khi trả trễ",
                Font = new Font("Segoe UI", 8, FontStyle.Italic),
                ForeColor = Color.FromArgb(41, 128, 185),
                Location = new Point(10, y),
                AutoSize = true
            };
            panelRight.Controls.Add(lblFeeNote);

            this.Controls.Add(panelRight);

            // === BOTTOM PANEL - Buttons ===
            Panel panelBottom = new Panel
            {
                Location = new Point(200, this.ClientSize.Height - 60),
                Size = new Size(485, 60),
                BackColor = Color.FromArgb(248, 249, 250)
            };

            Button btnBorrow = new Button
            {
                Text = "Đăng nhập để mượn sách",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(200, 38),
                Location = new Point(15, 10),
                Cursor = Cursors.Hand,
                Enabled = book.AvailableCopies > 0
            };
            btnBorrow.FlatAppearance.BorderSize = 0;
            btnBorrow.Click += (s, e) => { this.DialogResult = DialogResult.Yes; this.Close(); };

            Button btnClose = new Button
            {
                Text = "Đóng",
                Font = new Font("Segoe UI", 10),
                BackColor = Color.FromArgb(52, 152, 219),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(80, 38),
                Location = new Point(230, 10),
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => this.Close();

            panelBottom.Controls.AddRange(new Control[] { btnBorrow, btnClose });
            this.Controls.Add(panelBottom);
        }

        private void AddInfoRow(string label, string value, ref int y, Panel parent)
        {
            Label lblLabel = new Label
            {
                Text = label,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Gray,
                Location = new Point(10, y),
                Size = new Size(90, 22)
            };
            parent.Controls.Add(lblLabel);

            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(100, y),
                MaximumSize = new Size(350, 30),
                AutoSize = true
            };
            parent.Controls.Add(lblValue);

            y += 25;
        }
    }
}
