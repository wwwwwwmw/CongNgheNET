using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    /// <summary>
    /// Form xem chi tiết sách với hình ảnh lớn và danh sách người đang mượn
    /// </summary>
    public class FormBookDetail : Form
    {
        private Book book;
        private string imagesFolder;

        public FormBookDetail(Book book, string imagesFolder)
        {
            this.book = book;
            this.imagesFolder = imagesFolder;
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = $"Chi tiết sách: {book.Title}";
            this.Size = new Size(850, 580);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // === LEFT PANEL - Image ===
            Panel panelLeft = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(220, this.ClientSize.Height),
                BackColor = Color.FromArgb(248, 249, 250)
            };

            PictureBox picBook = new PictureBox
            {
                Location = new Point(15, 20),
                Size = new Size(190, 250),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            LoadBookImage(picBook);
            panelLeft.Controls.Add(picBook);

            // Status
            Label lblStatus = new Label
            {
                Text = book.IsAvailable ? "✅ Còn sách" : "❌ Hết sách",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = book.IsAvailable ? Color.FromArgb(46, 204, 113) : Color.FromArgb(231, 76, 60),
                Location = new Point(15, 280),
                AutoSize = true
            };
            panelLeft.Controls.Add(lblStatus);

            Label lblQuantity = new Label
            {
                Text = $"Số lượng: {book.AvailableCopies}/{book.TotalCopies} bản",
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(100, 100, 100),
                Location = new Point(15, 305),
                AutoSize = true
            };
            panelLeft.Controls.Add(lblQuantity);

            this.Controls.Add(panelLeft);

            // === RIGHT PANEL - Info ===
            Panel panelRight = new Panel
            {
                Location = new Point(220, 0),
                Size = new Size(this.ClientSize.Width - 220, this.ClientSize.Height - 50),
                BackColor = Color.White,
                AutoScroll = true,
                Padding = new Padding(10)
            };

            int y = 15;
            int labelX = 15;
            int valueX = 110;

            // Title
            Label lblTitle = new Label
            {
                Text = book.Title,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(labelX, y),
                MaximumSize = new Size(580, 50),
                AutoSize = true
            };
            panelRight.Controls.Add(lblTitle);
            y += lblTitle.PreferredHeight + 15;

            // Info rows
            AddRow("📖 ISBN:", book.ISBN ?? "N/A", labelX, valueX, ref y, panelRight);
            AddRow("✍️ Tác giả:", book.AuthorName ?? "N/A", labelX, valueX, ref y, panelRight);
            AddRow("📁 Thể loại:", book.CategoryName ?? "N/A", labelX, valueX, ref y, panelRight);
            AddRow("🏢 NXB:", book.PublisherName ?? "N/A", labelX, valueX, ref y, panelRight);
            AddRow("📅 Năm XB:", book.PublishYear?.ToString() ?? "N/A", labelX, valueX, ref y, panelRight);
            AddRow("💰 Giá trị:", book.Price.ToString("N0") + " đ", labelX, valueX, ref y, panelRight);
            AddRow("📍 Vị trí:", book.Location ?? "N/A", labelX, valueX, ref y, panelRight);

            y += 5;

            // Description
            Label lblDescTitle = new Label
            {
                Text = "📝 Mô tả:",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(labelX, y),
                AutoSize = true
            };
            panelRight.Controls.Add(lblDescTitle);
            y += 20;

            TextBox txtDesc = new TextBox
            {
                Text = string.IsNullOrEmpty(book.Description) ? "Chưa có mô tả" : book.Description,
                Font = new Font("Segoe UI", 9),
                Location = new Point(labelX, y),
                Size = new Size(580, 50),
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                BackColor = Color.FromArgb(250, 250, 250),
                BorderStyle = BorderStyle.FixedSingle
            };
            panelRight.Controls.Add(txtDesc);
            y += 55;

            // Borrowers section
            Label lblBorrowers = new Label
            {
                Text = "👥 Người đang mượn sách này:",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.FromArgb(155, 89, 182),
                Location = new Point(labelX, y),
                AutoSize = true
            };
            panelRight.Controls.Add(lblBorrowers);
            y += 22;

            DataGridView dgvBorrowers = new DataGridView
            {
                Location = new Point(labelX, y),
                Size = new Size(580, 100),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            dgvBorrowers.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(155, 89, 182),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            dgvBorrowers.Columns.Add("MemberName", "Độc giả");
            dgvBorrowers.Columns.Add("BorrowDate", "Ngày mượn");
            dgvBorrowers.Columns.Add("DueDate", "Hạn trả");
            dgvBorrowers.Columns.Add("Status", "Trạng thái");
            dgvBorrowers.Columns["MemberName"]!.Width = 180;
            dgvBorrowers.Columns["BorrowDate"]!.Width = 130;
            dgvBorrowers.Columns["DueDate"]!.Width = 130;
            dgvBorrowers.Columns["Status"]!.Width = 120;

            LoadBorrowers(dgvBorrowers);
            panelRight.Controls.Add(dgvBorrowers);

            this.Controls.Add(panelRight);

            // === BOTTOM PANEL - Close Button ===
            Panel panelBottom = new Panel
            {
                Location = new Point(220, this.ClientSize.Height - 50),
                Size = new Size(this.ClientSize.Width - 220, 50),
                BackColor = Color.FromArgb(248, 249, 250)
            };

            Button btnClose = new Button
            {
                Text = "Đóng",
                Font = new Font("Segoe UI", 10),
                Size = new Size(100, 35),
                Location = new Point(panelBottom.Width - 120, 8),
                BackColor = Color.FromArgb(52, 152, 219),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => this.Close();
            panelBottom.Controls.Add(btnClose);

            this.Controls.Add(panelBottom);
        }

        private void AddRow(string label, string value, int labelX, int valueX, ref int y, Panel parent)
        {
            Label lblLabel = new Label
            {
                Text = label,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Gray,
                Location = new Point(labelX, y),
                Size = new Size(90, 20)
            };
            parent.Controls.Add(lblLabel);

            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(valueX, y),
                MaximumSize = new Size(480, 25),
                AutoSize = true
            };
            parent.Controls.Add(lblValue);
            y += 23;
        }

        private void LoadBorrowers(DataGridView dgv)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                            SELECT m.FullName, br.BorrowDate, br.DueDate, br.Status
                            FROM BorrowRecords br
                            INNER JOIN Members m ON br.MemberID = m.MemberID
                            WHERE br.BookID = @BookID AND br.Status IN (N'Đang mượn', N'Quá hạn')
                            ORDER BY br.BorrowDate DESC";
                        cmd.Parameters.AddWithValue("@BookID", book.BookID);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string status = reader.GetString(3);
                                dgv.Rows.Add(
                                    reader.GetString(0),
                                    reader.GetDateTime(1).ToString("dd/MM/yyyy"),
                                    reader.GetDateTime(2).ToString("dd/MM/yyyy"),
                                    status
                                );
                                if (status == "Quá hạn")
                                    dgv.Rows[dgv.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
                            }
                        }
                    }
                }

                if (dgv.Rows.Count == 0)
                {
                    dgv.Rows.Add("Không có ai đang mượn", "-", "-", "-");
                    dgv.Rows[0].DefaultCellStyle.ForeColor = Color.Gray;
                }
            }
            catch (Exception ex)
            {
                dgv.Rows.Add("Lỗi: " + ex.Message, "-", "-", "-");
            }
        }

        private void LoadBookImage(PictureBox pic)
        {
            if (string.IsNullOrEmpty(book.ImagePath))
            {
                var bmp = new Bitmap(190, 250);
                using (var g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.FromArgb(245, 245, 245));
                    using (var font = new Font("Segoe UI", 36))
                    using (var brush = new SolidBrush(Color.FromArgb(180, 180, 180)))
                    {
                        g.DrawString("📚", font, brush, 60, 80);
                    }
                    using (var font = new Font("Segoe UI", 9))
                    using (var brush = new SolidBrush(Color.FromArgb(150, 150, 150)))
                    {
                        g.DrawString("Không có hình ảnh", font, brush, 35, 150);
                    }
                }
                pic.Image = bmp;
                return;
            }

            try
            {
                string fullPath = Path.IsPathRooted(book.ImagePath)
                    ? book.ImagePath
                    : Path.Combine(imagesFolder, book.ImagePath);

                if (File.Exists(fullPath))
                {
                    using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        pic.Image = Image.FromStream(stream);
                    }
                }
            }
            catch { }
        }
    }
}
