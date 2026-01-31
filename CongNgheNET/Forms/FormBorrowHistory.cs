using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    /// <summary>
    /// Form hiển thị lịch sử mượn sách của độc giả
    /// </summary>
    public class FormBorrowHistory : Form
    {
        private Member member;

        public FormBorrowHistory(Member member)
        {
            this.member = member;
            InitializeComponent();
            LoadHistory();
        }

        private void InitializeComponent()
        {
            this.Text = $"Lịch sử mượn sách - {member.FullName}";
            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void LoadHistory()
        {
            var borrowDAO = new BorrowRecordDAO();
            var history = borrowDAO.GetMemberHistory(member.MemberID);

            var dgv = new DataGridView
            {
                Location = new Point(20, 20),
                Size = new Size(740, 400),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            dgv.Columns.Add("BorrowCode", "Mã phiếu");
            dgv.Columns.Add("BookTitle", "Tên sách");
            dgv.Columns.Add("BorrowDate", "Ngày mượn");
            dgv.Columns.Add("DueDate", "Hạn trả");
            dgv.Columns.Add("ReturnDate", "Ngày trả");
            dgv.Columns.Add("Status", "Trạng thái");
            dgv.Columns.Add("FineAmount", "Tiền phạt");

            dgv.Columns["BorrowCode"]!.Width = 100;
            dgv.Columns["BookTitle"]!.Width = 250;
            dgv.Columns["BorrowDate"]!.Width = 90;
            dgv.Columns["DueDate"]!.Width = 90;
            dgv.Columns["ReturnDate"]!.Width = 90;
            dgv.Columns["Status"]!.Width = 90;
            dgv.Columns["FineAmount"]!.Width = 90;

            foreach (var record in history)
            {
                dgv.Rows.Add(
                    record.BorrowCode,
                    record.BookTitle,
                    record.BorrowDate.ToString("dd/MM/yyyy"),
                    record.DueDate.ToString("dd/MM/yyyy"),
                    record.ReturnDate?.ToString("dd/MM/yyyy"),
                    record.Status,
                    record.FineAmount.ToString("N0") + " đ"
                );
            }

            this.Controls.Add(dgv);

            var btnClose = new Button
            {
                Text = "Đóng",
                Location = new Point(680, 430),
                Size = new Size(80, 30)
            };
            btnClose.Click += (s, e) => this.Close();
            this.Controls.Add(btnClose);
        }
    }
}
