﻿using System;
using System.Data;
using System.Windows.Forms;
using LibraryLoanSystem.DataAccess;
using Microsoft.Data.SqlClient;

namespace LibraryLoanSystem.Forms
{
    public partial class LoansForm : BaseForm
    {
        public LoansForm()
        {
            InitializeComponent();

            if (IsDesignTime)
            {
                return;
            }

            dtpLoanDate.Value = DateTime.Now;

            LoadBooks();
            LoadMembers();
            LoadRecentLoans();
            // no direct TextBoxes here, but ensure combo boxes trimmed when changed
            cmbBooks.Validating += (s, e) => { cmbBooks.Text = cmbBooks.Text.Trim(); };
            cmbMembers.Validating += (s, e) => { cmbMembers.Text = cmbMembers.Text.Trim(); };

            // default return date is 14 days after loan by default
            dtpReturnDate.Value = DateTime.Now.Date.AddDays(14);
            // allow user to pick return date; minimum is loan date
            dtpReturnDate.Enabled = true;
            dtpReturnDate.MinDate = dtpLoanDate.Value.Date;
            dtpReturnDate.MaxDate = DateTime.Now.Date.AddYears(5);

            // if loan date changes, adjust minimum return date if needed
            dtpLoanDate.ValueChanged += (s, e) =>
            {
                try
                {
                    dtpReturnDate.MinDate = dtpLoanDate.Value.Date;
                    if (dtpReturnDate.Value.Date < dtpReturnDate.MinDate)
                        dtpReturnDate.Value = dtpReturnDate.MinDate.AddDays(14);
                }
                catch { }
            };

            // process overdue returns when the loan form is opened
            DbHelper.ProcessOverdueReturns();
        }

        private void LoadBooks()
        {
            DataTable books = DbHelper.GetDataTable(@"
                SELECT 
                    B.BookId,
                    B.Title + ' | ' + A.Name + ' | Stok: ' + CAST(B.Stock AS NVARCHAR(10)) AS DisplayText
                FROM Books B
                INNER JOIN Authors A ON A.AuthorId = B.AuthorId
                WHERE B.Stock > 0
                ORDER BY B.Title");

            cmbBooks.DataSource = books;
            cmbBooks.DisplayMember = "DisplayText";
            cmbBooks.ValueMember = "BookId";
            cmbBooks.SelectedIndex = books.Rows.Count > 0 ? 0 : -1;
        }

        private void LoadMembers()
        {
            DataTable members = DbHelper.GetDataTable("SELECT MemberId, FullName FROM Members ORDER BY FullName");

            cmbMembers.DataSource = members;
            cmbMembers.DisplayMember = "FullName";
            cmbMembers.ValueMember = "MemberId";
            cmbMembers.SelectedIndex = members.Rows.Count > 0 ? 0 : -1;
        }

        private void LoadRecentLoans()
        {
            dgvRecentLoans.DataSource = DbHelper.GetDataTable(@"
                SELECT TOP 25
                    L.LoanId,
                    B.Title AS Book,
                    M.FullName AS Member,
                    L.LoanDate,
                    L.ReturnDate,
                    CASE 
                        WHEN L.IsReturned = 1 THEN 'Teslim Edildi'
                        ELSE 'Aktif'
                    END AS Status
                FROM Loans L
                INNER JOIN Books B ON B.BookId = L.BookId
                INNER JOIN Members M ON M.MemberId = L.MemberId
                ORDER BY L.LoanId DESC");
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            if (cmbBooks.SelectedIndex == -1)
            {
                MessageBox.Show("Ödünç verilecek uygun stokta kitap yok.");
                return;
            }

            if (cmbMembers.SelectedIndex == -1)
            {
                MessageBox.Show("Önce üye ekle.");
                return;
            }

            int bookId = Convert.ToInt32(cmbBooks.SelectedValue);
            int memberId = Convert.ToInt32(cmbMembers.SelectedValue);

            object stockObj = DbHelper.ExecuteScalar(
                "SELECT Stock FROM Books WHERE BookId = @BookId",
                new SqlParameter("@BookId", bookId)
            );

            if (stockObj == null || Convert.ToInt32(stockObj) <= 0)
            {
                MessageBox.Show("Bu kitap için stok kalmamış.");
                LoadBooks();
                return;
            }

            DbHelper.ExecuteNonQuery(@"
                INSERT INTO Loans (BookId, MemberId, LoanDate, ReturnDate, IsReturned)
                VALUES (@BookId, @MemberId, @LoanDate, @ReturnDate, 0);

                UPDATE Books
                SET Stock = Stock - 1
                WHERE BookId = @BookId AND Stock > 0;",
                new SqlParameter("@BookId", bookId),
                new SqlParameter("@MemberId", memberId),
                new SqlParameter("@LoanDate", dtpLoanDate.Value.Date),
                new SqlParameter("@ReturnDate", dtpReturnDate.Value.Date)
            );

            LoadBooks();
            LoadRecentLoans();

            MessageBox.Show("Kitap ödünç verildi.");
        }
    }
}