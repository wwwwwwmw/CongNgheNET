using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    /// <summary>
    /// Form gia hạn sách
    /// </summary>
    public class FormRenewBook : Form
    {
        private BorrowRecord record;
        private NumericUpDown numDays = null!;

        public FormRenewBook(BorrowRecord record)
        {
            this.record = record;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Gia hạn sách";
            this.Size = new Size(400, 280);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            var lblBook = new Label
            {
                Text = $"Sách: {record.BookTitle}",
                Location = new Point(20, 20),
                Size = new Size(350, 25),
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            var lblMember = new Label
            {
                Text = $"Độc giả: {record.MemberName}",
                Location = new Point(20, 50),
                AutoSize = true
            };

            var lblCurrentDue = new Label
            {
                Text = $"Hạn trả hiện tại: {record.DueDate:dd/MM/yyyy}",
                Location = new Point(20, 80),
                AutoSize = true
            };

            var lblDays = new Label { Text = "Gia hạn thêm (ngày):", Location = new Point(20, 120), AutoSize = true };
            numDays = new NumericUpDown
            {
                Location = new Point(160, 117),
                Size = new Size(80, 28),
                Minimum = 1,
                Maximum = 30,
                Value = 7
            };

            var lblNewDue = new Label
            {
                Location = new Point(20, 155),
                AutoSize = true,
                Font = new Font("Segoe UI", 10)
            };

            numDays.ValueChanged += (s, e) =>
            {
                DateTime newDue = record.DueDate.AddDays((int)numDays.Value);
                lblNewDue.Text = $"Hạn trả mới: {newDue:dd/MM/yyyy}";
            };
            numDays.Value = 7; // Trigger the event

            var btnRenew = new Button
            {
                Text = "🔄 Gia hạn",
                Location = new Point(80, 195),
                Size = new Size(100, 35),
                BackColor = Color.FromArgb(52, 152, 219),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnRenew.FlatAppearance.BorderSize = 0;
            btnRenew.Click += BtnRenew_Click;

            var btnCancel = new Button
            {
                Text = "Hủy",
                Location = new Point(200, 195),
                Size = new Size(80, 35),
                BackColor = Color.FromArgb(149, 165, 166),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click += (s, e) => this.Close();

            this.Controls.AddRange(new Control[] {
                lblBook, lblMember, lblCurrentDue, lblDays, numDays, lblNewDue, btnRenew, btnCancel
            });
        }

        private void BtnRenew_Click(object? sender, EventArgs e)
        {
            try
            {
                var borrowDAO = new BorrowRecordDAO();
                var (success, message) = borrowDAO.RenewBook(record.BorrowID, (int)numDays.Value);

                if (success)
                {
                    var logDAO = new ActivityLogDAO();
                    logDAO.Log($"Gia hạn sách: {record.BookTitle} thêm {numDays.Value} ngày", "BorrowRecords", record.BorrowID);

                    MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
