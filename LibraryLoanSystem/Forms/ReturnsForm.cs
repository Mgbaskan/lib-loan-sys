﻿using System;
using System.Data;
using System.Windows.Forms;
using LibraryLoanSystem.DataAccess;
using Microsoft.Data.SqlClient;

namespace LibraryLoanSystem.Forms
{
    public partial class ReturnsForm : BaseForm
    {
        public ReturnsForm()
        {
            InitializeComponent();

            if (IsDesignTime)
            {
                return;
            }

            LoadActiveLoans();
            cmbActiveLoans.Validating += (s, e) => { cmbActiveLoans.Text = cmbActiveLoans.Text.Trim(); };
        }

        private void LoadActiveLoans()
        {
            DataTable activeLoans = DbHelper.GetDataTable(@"
                SELECT
                    L.LoanId,
                    B.Title + ' | ' + M.FullName + ' | ' + CONVERT(NVARCHAR(10), L.LoanDate, 104) AS DisplayText
                FROM Loans L
                INNER JOIN Books B ON B.BookId = L.BookId
                INNER JOIN Members M ON M.MemberId = L.MemberId
                WHERE L.IsReturned = 0
                ORDER BY L.LoanId DESC");

            cmbActiveLoans.DataSource = activeLoans;
            cmbActiveLoans.DisplayMember = "DisplayText";
            cmbActiveLoans.ValueMember = "LoanId";
            cmbActiveLoans.SelectedIndex = activeLoans.Rows.Count > 0 ? 0 : -1;

            dgvActiveLoans.DataSource = DbHelper.GetDataTable(@"
                SELECT
                    L.LoanId,
                    B.Title AS Book,
                    M.FullName AS Member,
                    L.LoanDate
                FROM Loans L
                INNER JOIN Books B ON B.BookId = L.BookId
                INNER JOIN Members M ON M.MemberId = L.MemberId
                WHERE L.IsReturned = 0
                ORDER BY L.LoanId DESC");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (cmbActiveLoans.SelectedIndex == -1)
            {
                MessageBox.Show("Teslim alınacak aktif ödünç kaydı yok.");
                return;
            }

            int loanId = Convert.ToInt32(cmbActiveLoans.SelectedValue);

            object bookIdObj = DbHelper.ExecuteScalar(
                "SELECT BookId FROM Loans WHERE LoanId = @LoanId AND IsReturned = 0",
                new SqlParameter("@LoanId", loanId)
            );

            if (bookIdObj == null)
            {
                MessageBox.Show("Kayıt bulunamadı.");
                LoadActiveLoans();
                return;
            }

            int bookId = Convert.ToInt32(bookIdObj);

            DbHelper.ExecuteNonQuery(@"
                UPDATE Loans
                SET ReturnDate = @ReturnDate,
                    IsReturned = 1
                WHERE LoanId = @LoanId AND IsReturned = 0;

                UPDATE Books
                SET Stock = Stock + 1
                WHERE BookId = @BookId;",
                new SqlParameter("@ReturnDate", DateTime.Now.Date),
                new SqlParameter("@LoanId", loanId),
                new SqlParameter("@BookId", bookId)
            );

            LoadActiveLoans();
            MessageBox.Show("Kitap teslim alındı.");
        }

        private void dgvActiveLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int loanId = Convert.ToInt32(dgvActiveLoans.Rows[e.RowIndex].Cells["LoanId"].Value);
            cmbActiveLoans.SelectedValue = loanId;
        }
    }
}