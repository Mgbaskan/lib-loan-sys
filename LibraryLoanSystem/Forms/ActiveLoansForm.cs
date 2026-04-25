﻿using System.Windows.Forms;
using LibraryLoanSystem.DataAccess;

namespace LibraryLoanSystem.Forms
{
    public partial class ActiveLoansForm : BaseForm
    {
        public ActiveLoansForm()
        {
            InitializeComponent();

            if (IsDesignTime)
            {
                return;
            }

            LoadActiveLoans();
        }

        private void LoadActiveLoans()
        {
            dgvActiveLoans.DataSource = DbHelper.GetDataTable(@"
                SELECT
                    L.LoanId,
                    B.Title AS Book,
                    A.Name AS Author,
                    C.Name AS Category,
                    M.FullName AS Member,
                    L.LoanDate
                FROM Loans L
                INNER JOIN Books B ON B.BookId = L.BookId
                INNER JOIN Authors A ON A.AuthorId = B.AuthorId
                INNER JOIN Categories C ON C.CategoryId = B.CategoryId
                INNER JOIN Members M ON M.MemberId = L.MemberId
                WHERE L.IsReturned = 0
                ORDER BY L.LoanId DESC");
        }
    }
}