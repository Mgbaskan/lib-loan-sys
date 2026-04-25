using System;
using System.Windows.Forms;
using LibraryLoanSystem.DataAccess;
using Microsoft.Data.SqlClient;

namespace LibraryLoanSystem.Forms
{
    public partial class AuthorsForm : BaseForm
    {
        private int _selectedAuthorId = 0;

        public AuthorsForm()
        {
            InitializeComponent();

            if (IsDesignTime)
            {
                return;
            }

            LoadAuthors();
            InputValidationHelper.AttachText(txtName, 200);
        }

        private void LoadAuthors()
        {
            dgvAuthors.DataSource = DbHelper.GetDataTable(
                "SELECT AuthorId, Name FROM Authors ORDER BY AuthorId DESC");
        }

        private void ClearForm()
        {
            _selectedAuthorId = 0;
            txtName.Clear();
            txtName.Focus();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("İsim boş olamaz.");
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            DbHelper.ExecuteNonQuery(
                "INSERT INTO Authors (Name) VALUES (@Name)",
                new SqlParameter("@Name", txtName.Text.Trim())
            );

            LoadAuthors();
            ClearForm();
            MessageBox.Show("Yazar eklendi.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedAuthorId == 0)
            {
                MessageBox.Show("Güncellenecek yazar seç.");
                return;
            }

            if (!ValidateForm()) return;

            DbHelper.ExecuteNonQuery(
                "UPDATE Authors SET Name = @Name WHERE AuthorId = @AuthorId",
                new SqlParameter("@Name", txtName.Text.Trim()),
                new SqlParameter("@AuthorId", _selectedAuthorId)
            );

            LoadAuthors();
            ClearForm();
            MessageBox.Show("Yazar güncellendi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedAuthorId == 0)
            {
                MessageBox.Show("Silinecek yazar seç.");
                return;
            }

            object bookCount = DbHelper.ExecuteScalar(
                "SELECT COUNT(*) FROM Books WHERE AuthorId = @AuthorId",
                new SqlParameter("@AuthorId", _selectedAuthorId)
            );

            if (Convert.ToInt32(bookCount) > 0)
            {
                MessageBox.Show("Bu yazara ait kitaplar var. Önce kitapları silin veya yazarını değiştirin.");
                return;
            }

            DbHelper.ExecuteNonQuery(
                "DELETE FROM Authors WHERE AuthorId = @AuthorId",
                new SqlParameter("@AuthorId", _selectedAuthorId)
            );

            LoadAuthors();
            ClearForm();
            MessageBox.Show("Yazar silindi.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvAuthors.Rows[e.RowIndex];
            _selectedAuthorId = Convert.ToInt32(row.Cells["AuthorId"].Value);
            txtName.Text = row.Cells["Name"].Value.ToString();
        }
    }
}
