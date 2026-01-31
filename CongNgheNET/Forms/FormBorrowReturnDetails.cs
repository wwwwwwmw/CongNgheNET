using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryManagement.Data;

namespace LibraryManagement.Forms
{
    /// <summary>
    /// Form xem chi tiết phiếu mượn/trả
    /// </summary>
    public partial class FormBorrowReturnDetails : Form
    {
        public FormBorrowReturnDetails()
        {
            InitializeComponent();
            SetupDataGridViews();
            SetupInitialValues();
            LoadData();
        }

        private void SetupInitialValues()
        {
            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;
        }

        private void SetupDataGridViews()
        {
            // Setup dgvBorrow columns
            SetupDataGridViewStyle(dgvBorrow);
            dgvBorrow.Columns.Add("BorrowCode", "Mã phiếu");
            dgvBorrow.Columns.Add("MemberName", "Độc giả");
            dgvBorrow.Columns.Add("BookTitle", "Tên sách");
            dgvBorrow.Columns.Add("BorrowDate", "Ngày mượn");
            dgvBorrow.Columns.Add("DueDate", "Hạn trả");
            dgvBorrow.Columns.Add("Status", "Trạng thái");
            dgvBorrow.Columns.Add("StaffName", "Nhân viên");

            dgvBorrow.Columns["BorrowCode"]!.Width = 120;
            dgvBorrow.Columns["MemberName"]!.Width = 150;
            dgvBorrow.Columns["BookTitle"]!.Width = 220;
            dgvBorrow.Columns["BorrowDate"]!.Width = 90;
            dgvBorrow.Columns["DueDate"]!.Width = 90;
            dgvBorrow.Columns["Status"]!.Width = 90;
            dgvBorrow.Columns["StaffName"]!.Width = 120;

            // Setup dgvReturn columns
            SetupDataGridViewStyle(dgvReturn);
            dgvReturn.Columns.Add("BorrowCode", "Mã phiếu");
            dgvReturn.Columns.Add("MemberName", "Độc giả");
            dgvReturn.Columns.Add("BookTitle", "Tên sách");
            dgvReturn.Columns.Add("BorrowDate", "Ngày mượn");
            dgvReturn.Columns.Add("ReturnDate", "Ngày trả");
            dgvReturn.Columns.Add("FineAmount", "Tiền phạt");
            dgvReturn.Columns.Add("StaffName", "Nhân viên");

            dgvReturn.Columns["BorrowCode"]!.Width = 120;
            dgvReturn.Columns["MemberName"]!.Width = 150;
            dgvReturn.Columns["BookTitle"]!.Width = 220;
            dgvReturn.Columns["BorrowDate"]!.Width = 90;
            dgvReturn.Columns["ReturnDate"]!.Width = 90;
            dgvReturn.Columns["FineAmount"]!.Width = 90;
            dgvReturn.Columns["StaffName"]!.Width = 120;
        }

        private void SetupDataGridViewStyle(DataGridView dgv)
        {
            dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(52, 73, 94),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnFilter_Click(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExport_Click(object? sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            LoadBorrowRecords();
            LoadReturnRecords();
        }

        private void LoadBorrowRecords()
        {
            dgvBorrow.Rows.Clear();

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

                        int count = 0;
                        int borrowing = 0;
                        int overdue = 0;
                        int returned = 0;

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string status = reader["Status"]?.ToString() ?? "";
                                int rowIndex = dgvBorrow.Rows.Add(
                                    reader["BorrowCode"],
                                    reader["MemberName"],
                                    reader["BookTitle"],
                                    ((DateTime)reader["BorrowDate"]).ToString("dd/MM/yyyy"),
                                    ((DateTime)reader["DueDate"]).ToString("dd/MM/yyyy"),
                                    status,
                                    reader["StaffName"]
                                );

                                // Color by status
                                if (status == "Quá hạn")
                                {
                                    dgvBorrow.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Red;
                                    overdue++;
                                }
                                else if (status == "Đã trả")
                                {
                                    dgvBorrow.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Green;
                                    returned++;
                                }
                                else if (status == "Đang mượn")
                                {
                                    dgvBorrow.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(41, 128, 185);
                                    borrowing++;
                                }

                                count++;
                            }
                        }

                        lblBorrowSummary.Text = $"📊 Tổng: {count} phiếu | 📖 Đang mượn: {borrowing} | ⚠️ Quá hạn: {overdue} | ✅ Đã trả: {returned}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu phiếu mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadReturnRecords()
        {
            dgvReturn.Rows.Clear();

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
                        int count = 0;

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                decimal fine = reader["FineAmount"] != DBNull.Value ? (decimal)reader["FineAmount"] : 0;
                                totalFine += fine;

                                int rowIndex = dgvReturn.Rows.Add(
                                    reader["BorrowCode"],
                                    reader["MemberName"],
                                    reader["BookTitle"],
                                    ((DateTime)reader["BorrowDate"]).ToString("dd/MM/yyyy"),
                                    reader["ReturnDate"] != DBNull.Value ? ((DateTime)reader["ReturnDate"]).ToString("dd/MM/yyyy") : "-",
                                    fine > 0 ? fine.ToString("N0") + " đ" : "-",
                                    reader["StaffName"]
                                );

                                if (fine > 0)
                                    dgvReturn.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.OrangeRed;

                                count++;
                            }
                        }

                        lblReturnSummary.Text = $"📊 Tổng: {count} phiếu trả | 💰 Tổng tiền phạt đã thu: {totalFine:N0} đ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu phiếu trả: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToExcel()
        {
            DataGridView currentDgv = tabControl.SelectedIndex == 0 ? dgvBorrow : dgvReturn;
            string type = tabControl.SelectedIndex == 0 ? "PhieuMuon" : "PhieuTra";

            if (currentDgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                saveDialog.FileName = $"{type}_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var writer = new System.IO.StreamWriter(saveDialog.FileName, false, System.Text.Encoding.UTF8))
                        {
                            // Headers
                            var headers = new System.Collections.Generic.List<string>();
                            foreach (DataGridViewColumn col in currentDgv.Columns)
                            {
                                headers.Add(col.HeaderText);
                            }
                            writer.WriteLine(string.Join(",", headers));

                            // Data
                            foreach (DataGridViewRow row in currentDgv.Rows)
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
    }
}
