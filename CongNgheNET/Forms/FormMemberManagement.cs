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
}
