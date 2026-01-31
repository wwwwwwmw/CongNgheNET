using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    /// <summary>
    /// Form quản lý độc giả / thành viên
    /// </summary>
    public partial class FormMemberManagement : Form
    {
        private MemberDAO memberDAO = new MemberDAO();
        private Member? currentMember;

        public FormMemberManagement()
        {
            InitializeComponent();
            SetupForm();
            SetupEvents();
            LoadData();
        }

        private void SetupForm()
        {
            // Setup DataGridView header style
            dgvMembers.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(52, 73, 94),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            // Setup ComboBox items
            cboMemberType.Items.Clear();
            cboMemberType.Items.AddRange(new object[] { "-- Tất cả --", Member.TYPE_NORMAL, Member.TYPE_VIP, Member.TYPE_STUDENT, Member.TYPE_TEACHER });
            cboMemberType.SelectedIndex = 0;

            cboGender.Items.Clear();
            cboGender.Items.AddRange(new object[] { Member.GENDER_MALE, Member.GENDER_FEMALE, Member.GENDER_OTHER });

            cboMemberTypeDetail.Items.Clear();
            cboMemberTypeDetail.Items.AddRange(new object[] { Member.TYPE_NORMAL, Member.TYPE_VIP, Member.TYPE_STUDENT, Member.TYPE_TEACHER });
        }

        private void SetupEvents()
        {
            // Search events
            txtSearch.TextChanged += (s, e) => SearchMembers();
            cboMemberType.SelectedIndexChanged += (s, e) => SearchMembers();
            chkActiveOnly.CheckedChanged += (s, e) => SearchMembers();
            btnSearch.Click += (s, e) => SearchMembers();

            // DataGridView events
            dgvMembers.SelectionChanged += DgvMembers_SelectionChanged;
            dgvMembers.CellDoubleClick += (s, e) => EditMember();

            // Button events
            btnAdd.Click += (s, e) => AddMember();
            btnEdit.Click += (s, e) => EditMember();
            btnDelete.Click += (s, e) => DeleteMember();
            btnHistory.Click += (s, e) => ShowBorrowHistory();
            btnPayFine.Click += (s, e) => PayFine();
            btnRefresh.Click += (s, e) => LoadData();

            // Detail panel buttons
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => ClearDetailForm();
        }

        private void LoadData()
        {
            SearchMembers();
        }

        private void SearchMembers()
        {
            try
            {
                string? keyword = string.IsNullOrWhiteSpace(txtSearch.Text) ? null : txtSearch.Text.Trim();
                string? memberType = cboMemberType.SelectedIndex > 0 ? cboMemberType.SelectedItem?.ToString() : null;

                var members = memberDAO.Search(keyword, memberType, chkActiveOnly.Checked);

                dgvMembers.Rows.Clear();
                foreach (var member in members)
                {
                    var row = dgvMembers.Rows.Add(
                        member.MemberID,
                        member.MemberCode,
                        member.FullName,
                        member.Gender,
                        member.Phone,
                        member.MemberType,
                        member.ExpiryDate?.ToString("dd/MM/yyyy"),
                        member.TotalFine.ToString("N0") + " đ",
                        member.StatusDisplay
                    );

                    // Highlight if has fine or expired
                    if (member.HasFine || member.IsExpired)
                    {
                        dgvMembers.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvMembers_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null) return;

            int memberId = Convert.ToInt32(dgvMembers.CurrentRow.Cells["colMemberID"].Value);
            currentMember = memberDAO.GetById(memberId);

            if (currentMember != null)
            {
                txtMemberCode.Text = currentMember.MemberCode;
                txtFullName.Text = currentMember.FullName;
                cboGender.SelectedItem = currentMember.Gender;
                if (currentMember.DateOfBirth.HasValue)
                    dtpDateOfBirth.Value = currentMember.DateOfBirth.Value;
                txtPhone.Text = currentMember.Phone;
                txtEmail.Text = currentMember.Email;
                txtIdentityCard.Text = currentMember.IdentityCard;
                txtAddress.Text = currentMember.Address;
                cboMemberTypeDetail.SelectedItem = currentMember.MemberType;
                if (currentMember.ExpiryDate.HasValue)
                    dtpExpiryDate.Value = currentMember.ExpiryDate.Value;
                txtNotes.Text = currentMember.Notes;
                lblTotalFine.Text = currentMember.TotalFine.ToString("N0") + " đ";
            }
        }

        private void AddMember()
        {
            currentMember = null;
            ClearDetailForm();

            // Generate new member code
            txtMemberCode.Text = memberDAO.GenerateMemberCode();
            dtpExpiryDate.Value = DateTime.Now.AddYears(1);
            cboMemberTypeDetail.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;

            txtFullName.Focus();
        }

        private void EditMember()
        {
            if (dgvMembers.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtFullName.Focus();
        }

        private void DeleteMember()
        {
            if (dgvMembers.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc muốn xóa độc giả này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int memberId = Convert.ToInt32(dgvMembers.CurrentRow.Cells["colMemberID"].Value);
                    if (memberDAO.Delete(memberId))
                    {
                        MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SearchMembers();
                        ClearDetailForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowBorrowHistory()
        {
            if (currentMember == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var historyForm = new FormBorrowHistory(currentMember))
            {
                historyForm.ShowDialog();
            }
        }

        private void PayFine()
        {
            if (currentMember == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (currentMember.TotalFine <= 0)
            {
                MessageBox.Show("Độc giả này không có nợ phạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var payForm = new FormPayFine(currentMember))
            {
                if (payForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh data
                    currentMember = memberDAO.GetById(currentMember.MemberID);
                    lblTotalFine.Text = currentMember?.TotalFine.ToString("N0") + " đ";
                    SearchMembers();
                }
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            try
            {
                var member = currentMember ?? new Member();
                member.MemberCode = txtMemberCode.Text.Trim();
                member.FullName = txtFullName.Text.Trim();
                member.Gender = cboGender.SelectedItem?.ToString();
                member.DateOfBirth = dtpDateOfBirth.Value;
                member.Phone = txtPhone.Text.Trim();
                member.Email = txtEmail.Text.Trim();
                member.IdentityCard = txtIdentityCard.Text.Trim();
                member.Address = txtAddress.Text.Trim();
                member.MemberType = cboMemberTypeDetail.SelectedItem?.ToString() ?? Member.TYPE_NORMAL;
                member.ExpiryDate = dtpExpiryDate.Value;
                member.Notes = txtNotes.Text.Trim();

                if (currentMember == null)
                {
                    memberDAO.Insert(member);
                    MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    memberDAO.Update(member);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                SearchMembers();
                ClearDetailForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearDetailForm()
        {
            currentMember = null;
            txtMemberCode.Clear();
            txtFullName.Clear();
            cboGender.SelectedIndex = -1;
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-20);
            txtPhone.Clear();
            txtEmail.Clear();
            txtIdentityCard.Clear();
            txtAddress.Clear();
            cboMemberTypeDetail.SelectedIndex = -1;
            dtpExpiryDate.Value = DateTime.Now.AddYears(1);
            txtNotes.Clear();
            lblTotalFine.Text = "0 đ";
        }
    }

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

    /// <summary>
    /// Form đóng tiền phạt
    /// </summary>
    public class FormPayFine : Form
    {
        private Member member;
        private NumericUpDown numAmount = null!;
        private ComboBox cboMethod = null!;
        private TextBox txtNotes = null!;

        public FormPayFine(Member member)
        {
            this.member = member;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Đóng tiền phạt";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            var lblMember = new Label
            {
                Text = $"Độc giả: {member.FullName} ({member.MemberCode})",
                Location = new Point(20, 20),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            var lblCurrentFine = new Label
            {
                Text = $"Số tiền nợ: {member.TotalFine:N0} VNĐ",
                Location = new Point(20, 50),
                AutoSize = true,
                ForeColor = Color.FromArgb(192, 57, 43)
            };

            var lblAmount = new Label { Text = "Số tiền đóng:", Location = new Point(20, 90), AutoSize = true };
            numAmount = new NumericUpDown
            {
                Location = new Point(120, 87),
                Size = new Size(150, 28),
                Maximum = member.TotalFine,
                Value = member.TotalFine,
                ThousandsSeparator = true
            };

            var lblMethod = new Label { Text = "Hình thức:", Location = new Point(20, 125), AutoSize = true };
            cboMethod = new ComboBox
            {
                Location = new Point(120, 122),
                Size = new Size(150, 28),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboMethod.Items.AddRange(new object[] { FinePayment.METHOD_CASH, FinePayment.METHOD_TRANSFER });
            cboMethod.SelectedIndex = 0;

            var lblNotes = new Label { Text = "Ghi chú:", Location = new Point(20, 160), AutoSize = true };
            txtNotes = new TextBox
            {
                Location = new Point(120, 157),
                Size = new Size(230, 50),
                Multiline = true
            };

            var btnPay = new Button
            {
                Text = "💰 Thanh toán",
                Location = new Point(120, 220),
                Size = new Size(100, 35),
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.Click += BtnPay_Click;

            var btnCancel = new Button
            {
                Text = "Hủy",
                Location = new Point(230, 220),
                Size = new Size(80, 35),
                BackColor = Color.FromArgb(149, 165, 166),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click += (s, e) => this.Close();

            this.Controls.AddRange(new Control[] {
                lblMember, lblCurrentFine, lblAmount, numAmount,
                lblMethod, cboMethod, lblNotes, txtNotes, btnPay, btnCancel
            });
        }

        private void BtnPay_Click(object? sender, EventArgs e)
        {
            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var payment = new FinePayment
                {
                    MemberID = member.MemberID,
                    Amount = numAmount.Value,
                    PaymentMethod = cboMethod.SelectedItem?.ToString() ?? FinePayment.METHOD_CASH,
                    Notes = txtNotes.Text.Trim(),
                    StaffID = CurrentUser.User?.UserID
                };

                var paymentDAO = new FinePaymentDAO();
                paymentDAO.Insert(payment);

                MessageBox.Show($"Đã thanh toán {numAmount.Value:N0} VNĐ thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
