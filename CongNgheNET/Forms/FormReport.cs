using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    /// <summary>
    /// Form thống kê báo cáo
    /// </summary>
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
            SetupEventHandlers();
            InitializeDatePickers();
            LoadDashboardStats();
        }

        private void SetupEventHandlers()
        {
            cboReportType.SelectedIndexChanged += (s, e) => GenerateReport();
            btnGenerate.Click += (s, e) => GenerateReport();
            btnExport.Click += (s, e) => ExportToExcel();
            btnPrint.Click += (s, e) => PrintReport();
            btnBorrowReturnDetails.Click += (s, e) => OpenBorrowReturnDetailsForm();
        }

        private void InitializeDatePickers()
        {
            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;
            cboReportType.SelectedIndex = 0;
        }

        private void LoadDashboardStats()
        {
            GenerateReport();
        }

        private void ClearDynamicControls()
        {
            // Remove dynamically created controls (stat cards, labels) but keep dgvReport
            var controlsToRemove = new System.Collections.Generic.List<Control>();
            foreach (Control ctrl in panelContent.Controls)
            {
                if (ctrl != dgvReport)
                {
                    controlsToRemove.Add(ctrl);
                }
            }
            foreach (var ctrl in controlsToRemove)
            {
                panelContent.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
        }

        private void GenerateReport()
        {
            ClearDynamicControls();
            dgvReport.Columns.Clear();
            dgvReport.Rows.Clear();
            lblSummary.Text = "";

            switch (cboReportType.SelectedIndex)
            {
                case 0: // Tổng quan
                    ShowDashboardOverview();
                    break;
                case 1: // Sách mượn nhiều nhất
                    ShowMostBorrowedBooks();
                    break;
                case 2: // Độc giả mượn nhiều nhất
                    ShowTopBorrowers();
                    break;
                case 3: // Sách quá hạn
                    ShowOverdueBooks();
                    break;
                case 4: // Thống kê theo ngày
                    ShowDailyStats();
                    break;
                case 5: // Phạt chưa thu
                    ShowUnpaidFines();
                    break;
                case 6: // Sách hết
                    ShowOutOfStockBooks();
                    break;
            }
        }

        private void ShowDashboardOverview()
        {
            // Hide dgvReport for dashboard view
            dgvReport.Visible = false;

            try
            {
                var borrowDAO = new BorrowRecordDAO();
                var stats = borrowDAO.GetDashboardStats();
                var memberDAO = new MemberDAO();
                var totalMembers = memberDAO.GetAll().Count;

                // Stats cards
                CreateStatCard("📚 Tổng sách", stats.TotalBooks.ToString("N0"), Color.FromArgb(52, 152, 219), 30, 30);
                CreateStatCard("🔄 Đang mượn", stats.BorrowingBooks.ToString("N0"), Color.FromArgb(46, 204, 113), 300, 30);
                CreateStatCard("⚠️ Quá hạn", stats.OverdueBooks.ToString("N0"), Color.FromArgb(231, 76, 60), 570, 30);
                CreateStatCard("👥 Độc giả", totalMembers.ToString("N0"), Color.FromArgb(155, 89, 182), 840, 30);

                // Recent activities - get today's stats
                var lblRecent = new Label
                {
                    Text = $"📅 Thống kê hôm nay ({DateTime.Today:dd/MM/yyyy}):",
                    Location = new Point(30, 170),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold)
                };
                panelContent.Controls.Add(lblRecent);

                var todayBorrowed = borrowDAO.CountByDate(DateTime.Today, "Borrow");
                var todayReturned = borrowDAO.CountByDate(DateTime.Today, "Return");

                var lblToday = new Label
                {
                    Text = $"   📖 Mượn: {todayBorrowed} phiếu    |    📥 Trả: {todayReturned} phiếu",
                    Location = new Point(30, 200),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 11)
                };
                panelContent.Controls.Add(lblToday);

                // Available books
                var bookDAO = new BookDAO();
                var allBooks = bookDAO.Search(null, null, null);
                int available = 0;
                int outOfStock = 0;
                foreach (var book in allBooks)
                {
                    if (book.AvailableQuantity > 0) available++;
                    else outOfStock++;
                }

                var lblAvail = new Label
                {
                    Text = $"   ✅ Sách còn: {available}    |    ❌ Sách hết: {outOfStock}",
                    Location = new Point(30, 230),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 11)
                };
                panelContent.Controls.Add(lblAvail);

                lblSummary.Text = $"📊 Báo cáo tổng quan - Cập nhật lúc {DateTime.Now:HH:mm dd/MM/yyyy}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateStatCard(string title, string value, Color color, int x, int y)
        {
            var card = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(240, 110),
                BackColor = color
            };

            var lblTitle = new Label
            {
                Text = title,
                Location = new Point(15, 15),
                AutoSize = true,
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.White
            };

            var lblValue = new Label
            {
                Text = value,
                Location = new Point(15, 50),
                AutoSize = true,
                Font = new Font("Segoe UI", 26, FontStyle.Bold),
                ForeColor = Color.White
            };

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);
            panelContent.Controls.Add(card);
        }

        private void ShowMostBorrowedBooks()
        {
            var dgv = CreateReportGrid();
            dgv.Columns.Add("STT", "STT");
            dgv.Columns.Add("BookTitle", "Tên sách");
            dgv.Columns.Add("Author", "Tác giả");
            dgv.Columns.Add("BorrowCount", "Lượt mượn");
            dgv.Columns.Add("Quantity", "Tồn kho");

            dgv.Columns["STT"]!.Width = 50;
            dgv.Columns["BookTitle"]!.Width = 400;
            dgv.Columns["Author"]!.Width = 200;
            dgv.Columns["BorrowCount"]!.Width = 100;
            dgv.Columns["Quantity"]!.Width = 100;

            try
            {
                var borrowDAO = new BorrowRecordDAO();
                var topBooks = borrowDAO.GetMostBorrowedBooks(dtpFrom.Value, dtpTo.Value, 20);

                int stt = 1;
                foreach (var item in topBooks)
                {
                    dgv.Rows.Add(stt++, item.BookTitle, item.AuthorName, item.BorrowCount, item.Quantity);
                }

                lblSummary.Text = $"📊 Top {topBooks.Count} sách mượn nhiều nhất từ {dtpFrom.Value:dd/MM/yyyy} đến {dtpTo.Value:dd/MM/yyyy}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowTopBorrowers()
        {
            var dgv = CreateReportGrid();
            dgv.Columns.Add("STT", "STT");
            dgv.Columns.Add("MemberCode", "Mã thẻ");
            dgv.Columns.Add("MemberName", "Tên độc giả");
            dgv.Columns.Add("BorrowCount", "Số lần mượn");
            dgv.Columns.Add("Phone", "SĐT");

            dgv.Columns["STT"]!.Width = 50;
            dgv.Columns["MemberCode"]!.Width = 100;
            dgv.Columns["MemberName"]!.Width = 300;
            dgv.Columns["BorrowCount"]!.Width = 120;
            dgv.Columns["Phone"]!.Width = 150;

            try
            {
                var borrowDAO = new BorrowRecordDAO();
                var topMembers = borrowDAO.GetTopBorrowers(dtpFrom.Value, dtpTo.Value, 20);

                int stt = 1;
                foreach (var item in topMembers)
                {
                    dgv.Rows.Add(stt++, item.MemberCode, item.MemberName, item.BorrowCount, item.Phone);
                }

                lblSummary.Text = $"📊 Top {topMembers.Count} độc giả mượn nhiều nhất từ {dtpFrom.Value:dd/MM/yyyy} đến {dtpTo.Value:dd/MM/yyyy}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowOverdueBooks()
        {
            var dgv = CreateReportGrid();
            dgv.Columns.Add("BorrowCode", "Mã phiếu");
            dgv.Columns.Add("MemberName", "Độc giả");
            dgv.Columns.Add("BookTitle", "Tên sách");
            dgv.Columns.Add("DueDate", "Hạn trả");
            dgv.Columns.Add("DaysOverdue", "Số ngày quá hạn");
            dgv.Columns.Add("EstFine", "Tiền phạt dự kiến");

            dgv.Columns["BorrowCode"]!.Width = 110;
            dgv.Columns["MemberName"]!.Width = 200;
            dgv.Columns["BookTitle"]!.Width = 300;
            dgv.Columns["DueDate"]!.Width = 100;
            dgv.Columns["DaysOverdue"]!.Width = 120;
            dgv.Columns["EstFine"]!.Width = 130;

            try
            {
                var borrowDAO = new BorrowRecordDAO();
                var overdueList = borrowDAO.Search(null, BorrowRecord.STATUS_OVERDUE);

                var settingDAO = new SystemSettingDAO();
                decimal finePerDay = settingDAO.GetDecimalValue(SystemSetting.KEY_FINE_PER_DAY, 5000);
                decimal totalFine = 0;

                foreach (var record in overdueList)
                {
                    decimal fine = record.DaysOverdue * finePerDay;
                    totalFine += fine;
                    dgv.Rows.Add(record.BorrowCode, record.MemberName, record.BookTitle,
                        record.DueDate.ToString("dd/MM/yyyy"), record.DaysOverdue, fine.ToString("N0"));
                }

                lblSummary.Text = $"📊 Tổng: {overdueList.Count} phiếu quá hạn | Tổng tiền phạt dự kiến: {totalFine:N0} VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowDailyStats()
        {
            var dgv = CreateReportGrid();
            dgv.Columns.Add("Date", "Ngày");
            dgv.Columns.Add("BorrowCount", "Số lượt mượn");
            dgv.Columns.Add("ReturnCount", "Số lượt trả");
            dgv.Columns.Add("NewMembers", "ĐG mới");

            dgv.Columns["Date"]!.Width = 150;
            dgv.Columns["BorrowCount"]!.Width = 150;
            dgv.Columns["ReturnCount"]!.Width = 150;
            dgv.Columns["NewMembers"]!.Width = 150;

            try
            {
                var borrowDAO = new BorrowRecordDAO();
                var dailyStats = borrowDAO.GetDailyStats(dtpFrom.Value, dtpTo.Value);

                int totalBorrow = 0, totalReturn = 0;
                foreach (var stat in dailyStats)
                {
                    dgv.Rows.Add(stat.Date.ToString("dd/MM/yyyy"), stat.BorrowCount, stat.ReturnCount, stat.NewMembers);
                    totalBorrow += stat.BorrowCount;
                    totalReturn += stat.ReturnCount;
                }

                lblSummary.Text = $"📊 Từ {dtpFrom.Value:dd/MM/yyyy} đến {dtpTo.Value:dd/MM/yyyy}: {totalBorrow} lượt mượn, {totalReturn} lượt trả";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowUnpaidFines()
        {
            var dgv = CreateReportGrid();
            dgv.Columns.Add("MemberCode", "Mã thẻ");
            dgv.Columns.Add("MemberName", "Tên độc giả");
            dgv.Columns.Add("Phone", "SĐT");
            dgv.Columns.Add("TotalFine", "Tổng nợ phạt");

            dgv.Columns["MemberCode"]!.Width = 120;
            dgv.Columns["MemberName"]!.Width = 300;
            dgv.Columns["Phone"]!.Width = 150;
            dgv.Columns["TotalFine"]!.Width = 150;

            try
            {
                var memberDAO = new MemberDAO();
                var members = memberDAO.GetAll();
                decimal totalUnpaid = 0;
                int count = 0;

                foreach (var member in members)
                {
                    if (member.TotalFine > 0)
                    {
                        dgv.Rows.Add(member.MemberCode, member.FullName, member.Phone, member.TotalFine.ToString("N0"));
                        totalUnpaid += member.TotalFine;
                        count++;
                    }
                }

                lblSummary.Text = $"📊 Có {count} độc giả còn nợ phạt | Tổng tiền phạt chưa thu: {totalUnpaid:N0} VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowOutOfStockBooks()
        {
            var dgv = CreateReportGrid();
            dgv.Columns.Add("BookCode", "Mã sách");
            dgv.Columns.Add("BookTitle", "Tên sách");
            dgv.Columns.Add("Author", "Tác giả");
            dgv.Columns.Add("Category", "Thể loại");
            dgv.Columns.Add("TotalQty", "Tổng SL");
            dgv.Columns.Add("BorrowedQty", "Đang mượn");

            dgv.Columns["BookCode"]!.Width = 100;
            dgv.Columns["BookTitle"]!.Width = 350;
            dgv.Columns["Author"]!.Width = 180;
            dgv.Columns["Category"]!.Width = 120;
            dgv.Columns["TotalQty"]!.Width = 80;
            dgv.Columns["BorrowedQty"]!.Width = 100;

            try
            {
                var bookDAO = new BookDAO();
                var allBooks = bookDAO.Search(null, null, null);
                int count = 0;

                foreach (var book in allBooks)
                {
                    if (book.AvailableQuantity <= 0)
                    {
                        dgv.Rows.Add(book.BookCode, book.Title, book.AuthorName, book.CategoryName,
                            book.Quantity, book.BorrowedQuantity);
                        count++;
                    }
                }

                lblSummary.Text = $"📊 Có {count} đầu sách đã hết (đang được mượn hết)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataGridView CreateReportGrid()
        {
            // Show dgvReport for grid-based reports
            dgvReport.Visible = true;

            // Clear existing columns and data
            dgvReport.Columns.Clear();
            dgvReport.Rows.Clear();

            // Apply column header style
            dgvReport.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(52, 73, 94),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            return dgvReport;
        }

        private void ExportToExcel()
        {
            if (dgvReport == null || dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                saveDialog.FileName = $"BaoCao_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var writer = new System.IO.StreamWriter(saveDialog.FileName, false, System.Text.Encoding.UTF8))
                        {
                            // Headers
                            var headers = new System.Collections.Generic.List<string>();
                            foreach (DataGridViewColumn col in dgvReport.Columns)
                            {
                                headers.Add(col.HeaderText);
                            }
                            writer.WriteLine(string.Join(",", headers));

                            // Data
                            foreach (DataGridViewRow row in dgvReport.Rows)
                            {
                                var values = new System.Collections.Generic.List<string>();
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    values.Add($"\"{cell.Value?.ToString() ?? ""}\"");
                                }
                                writer.WriteLine(string.Join(",", values));
                            }
                        }

                        MessageBox.Show("Xuất file thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{saveDialog.FileName}\"");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void PrintReport()
        {
            MessageBox.Show("Tính năng in báo cáo đang được phát triển.\n" +
                "Bạn có thể xuất ra file CSV và in từ Excel.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenBorrowReturnDetailsForm()
        {
            using (var form = new FormBorrowReturnDetails())
            {
                form.ShowDialog(this);
            }
        }

        private void ShowBorrowRecordDetails()
        {
            var dgv = CreateReportGrid();
            dgv.Columns.Add("BorrowCode", "Mã phiếu");
            dgv.Columns.Add("MemberName", "Độc giả");
            dgv.Columns.Add("BookTitle", "Tên sách");
            dgv.Columns.Add("BorrowDate", "Ngày mượn");
            dgv.Columns.Add("DueDate", "Hạn trả");
            dgv.Columns.Add("Status", "Trạng thái");
            dgv.Columns.Add("StaffName", "Nhân viên");

            dgv.Columns["BorrowCode"]!.Width = 130;
            dgv.Columns["MemberName"]!.Width = 180;
            dgv.Columns["BookTitle"]!.Width = 280;
            dgv.Columns["BorrowDate"]!.Width = 100;
            dgv.Columns["DueDate"]!.Width = 100;
            dgv.Columns["Status"]!.Width = 100;
            dgv.Columns["StaffName"]!.Width = 120;

            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                            SELECT br.BorrowCode, m.FullName AS MemberName, b.Title AS BookTitle,
                                   br.BorrowDate, br.DueDate, br.Status, u.FullName AS StaffName
                            FROM BorrowRecords br
                            INNER JOIN Members m ON br.MemberID = m.MemberID
                            INNER JOIN Books b ON br.BookID = b.BookID
                            LEFT JOIN Users u ON br.StaffID = u.UserID
                            WHERE br.BorrowDate BETWEEN @FromDate AND @ToDate
                            ORDER BY br.BorrowDate DESC";
                        cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date);
                        cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date.AddDays(1).AddSeconds(-1));

                        using (var reader = cmd.ExecuteReader())
                        {
                            int count = 0;
                            while (reader.Read())
                            {
                                string status = reader["Status"].ToString() ?? "";
                                int rowIndex = dgv.Rows.Add(
                                    reader["BorrowCode"],
                                    reader["MemberName"],
                                    reader["BookTitle"],
                                    ((DateTime)reader["BorrowDate"]).ToString("dd/MM/yyyy"),
                                    ((DateTime)reader["DueDate"]).ToString("dd/MM/yyyy"),
                                    status,
                                    reader["StaffName"]
                                );

                                // Đổi màu theo trạng thái
                                if (status == "Quá hạn")
                                    dgv.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Red;
                                else if (status == "Đã trả")
                                    dgv.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Green;

                                count++;
                            }
                            lblSummary.Text = $"📋 Danh sách {count} phiếu mượn từ {dtpFrom.Value:dd/MM/yyyy} đến {dtpTo.Value:dd/MM/yyyy}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowReturnRecordDetails()
        {
            var dgv = CreateReportGrid();
            dgv.Columns.Add("BorrowCode", "Mã phiếu");
            dgv.Columns.Add("MemberName", "Độc giả");
            dgv.Columns.Add("BookTitle", "Tên sách");
            dgv.Columns.Add("BorrowDate", "Ngày mượn");
            dgv.Columns.Add("ReturnDate", "Ngày trả");
            dgv.Columns.Add("FineAmount", "Tiền phạt");
            dgv.Columns.Add("StaffName", "Nhân viên");

            dgv.Columns["BorrowCode"]!.Width = 130;
            dgv.Columns["MemberName"]!.Width = 180;
            dgv.Columns["BookTitle"]!.Width = 280;
            dgv.Columns["BorrowDate"]!.Width = 100;
            dgv.Columns["ReturnDate"]!.Width = 100;
            dgv.Columns["FineAmount"]!.Width = 100;
            dgv.Columns["StaffName"]!.Width = 120;

            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                            SELECT br.BorrowCode, m.FullName AS MemberName, b.Title AS BookTitle,
                                   br.BorrowDate, br.ReturnDate, br.FineAmount, u.FullName AS StaffName
                            FROM BorrowRecords br
                            INNER JOIN Members m ON br.MemberID = m.MemberID
                            INNER JOIN Books b ON br.BookID = b.BookID
                            LEFT JOIN Users u ON br.StaffID = u.UserID
                            WHERE br.Status = N'Đã trả' 
                              AND br.ReturnDate BETWEEN @FromDate AND @ToDate
                            ORDER BY br.ReturnDate DESC";
                        cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date);
                        cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date.AddDays(1).AddSeconds(-1));

                        decimal totalFine = 0;
                        using (var reader = cmd.ExecuteReader())
                        {
                            int count = 0;
                            while (reader.Read())
                            {
                                decimal fine = reader["FineAmount"] != DBNull.Value ? (decimal)reader["FineAmount"] : 0;
                                totalFine += fine;

                                int rowIndex = dgv.Rows.Add(
                                    reader["BorrowCode"],
                                    reader["MemberName"],
                                    reader["BookTitle"],
                                    ((DateTime)reader["BorrowDate"]).ToString("dd/MM/yyyy"),
                                    reader["ReturnDate"] != DBNull.Value ? ((DateTime)reader["ReturnDate"]).ToString("dd/MM/yyyy") : "-",
                                    fine > 0 ? fine.ToString("N0") + " đ" : "-",
                                    reader["StaffName"]
                                );

                                // Đổi màu nếu có phạt
                                if (fine > 0)
                                    dgv.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.OrangeRed;

                                count++;
                            }
                            lblSummary.Text = $"📋 Danh sách {count} phiếu trả từ {dtpFrom.Value:dd/MM/yyyy} đến {dtpTo.Value:dd/MM/yyyy} | 💰 Tổng tiền phạt: {totalFine:N0} đ";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
