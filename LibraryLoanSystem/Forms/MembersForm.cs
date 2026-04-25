﻿using System;
using System.Windows.Forms;
using LibraryLoanSystem.DataAccess;
using Microsoft.Data.SqlClient;

namespace LibraryLoanSystem.Forms
{
    public partial class MembersForm : Form
    {
        private int _selectedMemberId = 0;

        public MembersForm()
        {
            InitializeComponent();

            if (DesignTimeHelper.IsInDesigner(this))
            {
                return;
            }

            LoadMembers();
            InputValidationHelper.AttachText(txtFullName, 200);
            InputValidationHelper.AttachPhone(txtPhone, 30);
            // initialize button states
            ClearForm();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignTimeHelper.IsInDesigner(this))
            {
                return;
            }

            ControlStyler.Apply(this);
        }

        private void LoadMembers()
        {
            dgvMembers.DataSource = DbHelper.GetDataTable(
                "SELECT MemberId, FullName, Phone FROM Members ORDER BY MemberId DESC");
        }

        private void ClearForm()
        {
            _selectedMemberId = 0;
            txtFullName.Clear();
            txtPhone.Clear();
            txtFullName.Focus();
            // reset action buttons: allow adding, disable update/delete when no selection
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Ad Soyad boş olamaz.");
                return false;
            }

            string phone = txtPhone.Text.Trim();

            // check phone format
            if (!InputValidationHelper.IsPhoneValid(phone))
            {
                MessageBox.Show("Telefon numarası geçersiz.");
                return false;
            }

            if (!string.IsNullOrEmpty(phone))
            {
                object existing = null;
                if (_selectedMemberId == 0)
                {
                    existing = DbHelper.ExecuteScalar(
                        "SELECT COUNT(*) FROM Members WHERE Phone = @Phone",
                        new Microsoft.Data.SqlClient.SqlParameter("@Phone", phone)
                    );
                }
                else
                {
                    existing = DbHelper.ExecuteScalar(
                        "SELECT COUNT(*) FROM Members WHERE Phone = @Phone AND MemberId <> @MemberId",
                        new Microsoft.Data.SqlClient.SqlParameter("@Phone", phone),
                        new Microsoft.Data.SqlClient.SqlParameter("@MemberId", _selectedMemberId)
                    );
                }

                if (existing != null && Convert.ToInt32(existing) > 0)
                {
                    MessageBox.Show("Bu telefon numarası zaten başka bir üyede kayıtlı.");
                    return false;
                }
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            DbHelper.ExecuteNonQuery(
                "INSERT INTO Members (FullName, Phone) VALUES (@FullName, @Phone)",
                new SqlParameter("@FullName", txtFullName.Text.Trim()),
                new SqlParameter("@Phone", txtPhone.Text.Trim())
            );

            LoadMembers();
            ClearForm();
            MessageBox.Show("Üye eklendi.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedMemberId == 0)
            {
                MessageBox.Show("Güncellenecek üye seç.");
                return;
            }

            if (!ValidateForm()) return;

            DbHelper.ExecuteNonQuery(
                "UPDATE Members SET FullName = @FullName, Phone = @Phone WHERE MemberId = @MemberId",
                new SqlParameter("@FullName", txtFullName.Text.Trim()),
                new SqlParameter("@Phone", txtPhone.Text.Trim()),
                new SqlParameter("@MemberId", _selectedMemberId)
            );

            LoadMembers();
            ClearForm();
            MessageBox.Show("Üye güncellendi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedMemberId == 0)
            {
                MessageBox.Show("Silinecek üye seç.");
                return;
            }

            object activeLoanCount = DbHelper.ExecuteScalar(
                "SELECT COUNT(*) FROM Loans WHERE MemberId = @MemberId AND IsReturned = 0",
                new SqlParameter("@MemberId", _selectedMemberId)
            );

            if (Convert.ToInt32(activeLoanCount) > 0)
            {
                MessageBox.Show("Bu üyenin aktif ödünç kaydı var. Silemezsin.");
                return;
            }

            DbHelper.ExecuteNonQuery(
                "DELETE FROM Members WHERE MemberId = @MemberId",
                new SqlParameter("@MemberId", _selectedMemberId)
            );

            LoadMembers();
            ClearForm();
            MessageBox.Show("Üye silindi.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvMembers.Rows[e.RowIndex];
            _selectedMemberId = Convert.ToInt32(row.Cells["MemberId"].Value);
            txtFullName.Text = row.Cells["FullName"].Value.ToString();
            txtPhone.Text = row.Cells["Phone"].Value.ToString();
            // when a member is selected, disable Add to prevent accidental duplicate insert
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
