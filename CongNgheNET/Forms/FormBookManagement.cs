using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Forms
{
    public partial class FormBookManagement : Form
    {
        private BookDAO bookDAO = new BookDAO();
        private Book? selectedBook;

        public FormBookManagement()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
<<<<<<< HEAD
            var books = bookDAO.GetAll();
        }
=======
            try
            {
                // Load categories
                var categories = categoryDAO.GetAll();
                cboCategory.Items.Clear();
                cboCategory.Items.Add(new Category { CategoryID = 0, CategoryName = "-- Tất cả --" });
                cboCategory.Items.AddRange(categories.ToArray());
                cboCategory.DisplayMember = "CategoryName";
                cboCategory.ValueMember = "CategoryID";
                cboCategory.SelectedIndex = 0;

                cboCategoryDetail.Items.Clear();
                cboCategoryDetail.Items.AddRange(categories.ToArray());
                cboCategoryDetail.DisplayMember = "CategoryName";
                cboCategoryDetail.ValueMember = "CategoryID";

                // Load authors
                var authors = authorDAO.GetAll();
                cboAuthor.Items.Clear();
                cboAuthor.Items.Add(new Author { AuthorID = 0, AuthorName = "-- Tất cả --" });
                cboAuthor.Items.AddRange(authors.ToArray());
                cboAuthor.DisplayMember = "AuthorName";
                cboAuthor.ValueMember = "AuthorID";
                cboAuthor.SelectedIndex = 0;

                cboAuthorDetail.Items.Clear();
                cboAuthorDetail.Items.AddRange(authors.ToArray());
                cboAuthorDetail.DisplayMember = "AuthorName";
                cboAuthorDetail.ValueMember = "AuthorID";

                // Load publishers
                var publishers = publisherDAO.GetAll();
                cboPublisher.Items.Clear();
                cboPublisher.Items.AddRange(publishers.ToArray());
                cboPublisher.DisplayMember = "PublisherName";
                cboPublisher.ValueMember = "PublisherID";

                // Load books
                SearchBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchBooks()
        {
            try
            {
                string? keyword = string.IsNullOrWhiteSpace(txtSearch.Text) ? null : txtSearch.Text.Trim();
                int? categoryId = (cboCategory.SelectedItem as Category)?.CategoryID;
                if (categoryId == 0) categoryId = null;
                int? authorId = (cboAuthor.SelectedItem as Author)?.AuthorID;
                if (authorId == 0) authorId = null;

                var books = bookDAO.Search(keyword, categoryId, authorId, chkAvailableOnly.Checked);

                dgvBooks.Rows.Clear();
                foreach (var book in books)
                {
                    dgvBooks.Rows.Add(
                        book.BookID, book.ISBN, book.Title, book.CategoryName,
                        book.AuthorName, book.TotalCopies, book.AvailableCopies, book.Location
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvBooks_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null) return;

            int bookId = Convert.ToInt32(dgvBooks.CurrentRow.Cells["BookID"].Value);
            currentBook = bookDAO.GetById(bookId);

            if (currentBook != null)
            {
                txtISBN.Text = currentBook.ISBN;
                txtBookTitle.Text = currentBook.Title;

                for (int i = 0; i < cboCategoryDetail.Items.Count; i++)
                {
                    if (((Category)cboCategoryDetail.Items[i]!).CategoryID == currentBook.CategoryID)
                    {
                        cboCategoryDetail.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < cboAuthorDetail.Items.Count; i++)
                {
                    if (((Author)cboAuthorDetail.Items[i]!).AuthorID == currentBook.AuthorID)
                    {
                        cboAuthorDetail.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < cboPublisher.Items.Count; i++)
                {
                    if (((Publisher)cboPublisher.Items[i]!).PublisherID == currentBook.PublisherID)
                    {
                        cboPublisher.SelectedIndex = i;
                        break;
                    }
                }

                numYear.Value = currentBook.PublishYear ?? DateTime.Now.Year;
                numPrice.Value = currentBook.Price;
                numTotalCopies.Value = currentBook.TotalCopies;
                txtLocation.Text = currentBook.Location;
                txtDescription.Text = currentBook.Description;

                // Load book image
                LoadBookImage(currentBook.ImagePath);
                currentImagePath = currentBook.ImagePath;
            }
        }

        private void AddBook()
        {
            currentBook = null;
            ClearDetailForm();
            txtISBN.Focus();
        }

        private void EditBook()
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtBookTitle.Focus();
        }

        private void DeleteBook()
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc muốn xóa sách này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int bookId = Convert.ToInt32(dgvBooks.CurrentRow.Cells["BookID"].Value);
                    if (bookDAO.Delete(bookId))
                    {
                        MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SearchBooks();
                        ClearDetailForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi xóa sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookTitle.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookTitle.Focus();
                return;
            }

            try
            {
                var book = currentBook ?? new Book();
                book.ISBN = txtISBN.Text.Trim();
                book.Title = txtBookTitle.Text.Trim();
                book.CategoryID = (cboCategoryDetail.SelectedItem as Category)?.CategoryID;
                book.AuthorID = (cboAuthorDetail.SelectedItem as Author)?.AuthorID;
                book.PublisherID = (cboPublisher.SelectedItem as Publisher)?.PublisherID;
                book.PublishYear = (int)numYear.Value;
                book.Price = numPrice.Value;
                book.TotalCopies = (int)numTotalCopies.Value;
                book.Location = txtLocation.Text.Trim();
                book.Description = txtDescription.Text.Trim();
                book.ImagePath = currentImagePath;

                if (currentBook == null)
                {
                    // Add new
                    book.AvailableCopies = book.TotalCopies;
                    bookDAO.Insert(book);
                    MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Update
                    // Adjust available copies if total changed
                    int diff = book.TotalCopies - currentBook.TotalCopies;
                    book.AvailableCopies = Math.Max(0, currentBook.AvailableCopies + diff);
                    bookDAO.Update(book);
                    MessageBox.Show("Cập nhật sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                SearchBooks();
                ClearDetailForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearDetailForm()
        {
            currentBook = null;
            txtISBN.Clear();
            txtBookTitle.Clear();
            cboCategoryDetail.SelectedIndex = -1;
            cboAuthorDetail.SelectedIndex = -1;
            cboPublisher.SelectedIndex = -1;
            numYear.Value = DateTime.Now.Year;
            numPrice.Value = 0;
            numTotalCopies.Value = 1;
            txtLocation.Clear();
            txtDescription.Clear();

            // Clear image
            currentImagePath = null;
            if (picBookImage.Image != null)
            {
                picBookImage.Image.Dispose();
                picBookImage.Image = null;
            }
            picBookImage.Invalidate();
        }

        #region Image Handling Methods

        private void PicBookImage_Paint(object? sender, PaintEventArgs e)
        {
            if (picBookImage.Image == null)
            {
                // Draw placeholder
                var rect = picBookImage.ClientRectangle;
                using (var brush = new SolidBrush(Color.FromArgb(200, 200, 200)))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    // Draw book icon
                    var font = new Font("Segoe UI", 24);
                    var text = "📖";
                    var textSize = e.Graphics.MeasureString(text, font);
                    var x = (rect.Width - textSize.Width) / 2;
                    var y = (rect.Height - textSize.Height) / 2 - 15;
                    e.Graphics.DrawString(text, font, brush, x, y);

                    // Draw hint text
                    var hintFont = new Font("Segoe UI", 8);
                    var hint = "Nhấn để chọn ảnh";
                    var hintSize = e.Graphics.MeasureString(hint, hintFont);
                    var hx = (rect.Width - hintSize.Width) / 2;
                    var hy = y + textSize.Height + 5;
                    e.Graphics.DrawString(hint, hintFont, brush, hx, hy);
                }
            }
        }

        private void LoadBookImage(string? imagePath)
        {
            // Dispose old image
            if (picBookImage.Image != null)
            {
                picBookImage.Image.Dispose();
                picBookImage.Image = null;
            }

            if (string.IsNullOrEmpty(imagePath))
            {
                picBookImage.Invalidate();
                return;
            }

            try
            {
                string fullPath = imagePath;
                if (!Path.IsPathRooted(imagePath))
                {
                    fullPath = Path.Combine(imagesFolder, imagePath);
                }

                if (File.Exists(fullPath))
                {
                    using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        picBookImage.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    picBookImage.Invalidate();
                }
            }
            catch
            {
                picBookImage.Invalidate();
            }
        }

        private void BrowseImage()
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn hình ảnh sách";
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
                dialog.FilterIndex = 1;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Generate new filename
                        string ext = Path.GetExtension(dialog.FileName);
                        string newFileName = $"book_{DateTime.Now:yyyyMMddHHmmss}_{Guid.NewGuid().ToString().Substring(0, 8)}{ext}";
                        string destPath = Path.Combine(imagesFolder, newFileName);

                        // Copy file to images folder
                        File.Copy(dialog.FileName, destPath, true);

                        // Update current image path
                        currentImagePath = newFileName;

                        // Load and display image
                        LoadBookImage(newFileName);

                        MessageBox.Show("Đã tải hình ảnh thành công!\n\n⚠️ Nhớ nhấn nút [💾 Lưu] để lưu thay đổi vào database.",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi tải hình ảnh: {ex.Message}", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RemoveImage()
        {
            if (string.IsNullOrEmpty(currentImagePath))
            {
                MessageBox.Show("Không có hình ảnh để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc muốn xóa hình ảnh này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Dispose and clear image
                if (picBookImage.Image != null)
                {
                    picBookImage.Image.Dispose();
                    picBookImage.Image = null;
                }
                currentImagePath = null;
                picBookImage.Invalidate();
            }
        }

        private void ShowBookDetail()
        {
            if (currentBook == null)
            {
                MessageBox.Show("Vui lòng chọn sách để xem chi tiết!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var form = new FormBookDetail(currentBook, imagesFolder))
            {
                form.ShowDialog(this);
            }
        }

        #endregion
>>>>>>> 77bc298e1021a5b93a6e7eb4ee94010f8084bd40
    }
}
