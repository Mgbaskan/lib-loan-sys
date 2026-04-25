﻿using System.Drawing;
using System.Windows.Forms;

namespace LibraryLoanSystem.Forms
{
    partial class LoansForm
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private TableLayoutPanel topLayout;
        private TableLayoutPanel formLayout;
        private TableLayoutPanel actionLayout;
        private Panel gridPanel;

        private Label lblBook;
        private Label lblMember;
        private Label lblLoanDate;
        private Label lblReturnDate;

        private ComboBox cmbBooks;
        private ComboBox cmbMembers;
        private DateTimePicker dtpLoanDate;
        private DateTimePicker dtpReturnDate;

        private Button btnLoan;
        private DataGridView dgvRecentLoans;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.topLayout = new System.Windows.Forms.TableLayoutPanel();
            this.formLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblBook = new System.Windows.Forms.Label();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.lblMember = new System.Windows.Forms.Label();
            this.cmbMembers = new System.Windows.Forms.ComboBox();
            this.lblLoanDate = new System.Windows.Forms.Label();
            this.dtpLoanDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.actionLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoan = new System.Windows.Forms.Button();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.dgvRecentLoans = new System.Windows.Forms.DataGridView();
            this.mainLayout.SuspendLayout();
            this.topLayout.SuspendLayout();
            this.formLayout.SuspendLayout();
            this.actionLayout.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.topLayout, 0, 0);
            this.mainLayout.Controls.Add(this.gridPanel, 0, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(15, 18);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(15, 18, 15, 18);
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(1256, 915);
            this.mainLayout.TabIndex = 0;
            // 
            // topLayout
            // 
            this.topLayout.AutoSize = true;
            this.topLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topLayout.ColumnCount = 2;
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.topLayout.Controls.Add(this.formLayout, 0, 0);
            this.topLayout.Controls.Add(this.actionLayout, 1, 0);
            this.topLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayout.Location = new System.Drawing.Point(15, 18);
            this.topLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.topLayout.Name = "topLayout";
            this.topLayout.RowCount = 1;
            this.topLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLayout.Size = new System.Drawing.Size(1226, 298);
            this.topLayout.TabIndex = 0;
            // 
            // formLayout
            // 
            this.formLayout.AutoSize = true;
            this.formLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.formLayout.BackColor = System.Drawing.Color.White;
            this.formLayout.ColumnCount = 2;
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formLayout.Controls.Add(this.lblBook, 0, 0);
            this.formLayout.Controls.Add(this.cmbBooks, 1, 0);
            this.formLayout.Controls.Add(this.lblMember, 0, 1);
            this.formLayout.Controls.Add(this.cmbMembers, 1, 1);
            this.formLayout.Controls.Add(this.lblLoanDate, 0, 2);
            this.formLayout.Controls.Add(this.dtpLoanDate, 1, 2);
            this.formLayout.Controls.Add(this.lblReturnDate, 0, 3);
            this.formLayout.Controls.Add(this.dtpReturnDate, 1, 3);
            this.formLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formLayout.Location = new System.Drawing.Point(0, 0);
            this.formLayout.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.formLayout.Name = "formLayout";
            this.formLayout.Padding = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.formLayout.RowCount = 4;
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.formLayout.Size = new System.Drawing.Size(869, 298);
            this.formLayout.TabIndex = 0;
            // 
            // lblBook
            // 
            this.lblBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBook.Location = new System.Drawing.Point(17, 15);
            this.lblBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(146, 67);
            this.lblBook.TabIndex = 0;
            this.lblBook.Text = "Kitap:";
            this.lblBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbBooks
            // 
            this.cmbBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBooks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBooks.Location = new System.Drawing.Point(171, 24);
            this.cmbBooks.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(681, 31);
            this.cmbBooks.TabIndex = 1;
            // 
            // lblMember
            // 
            this.lblMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMember.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMember.Location = new System.Drawing.Point(17, 82);
            this.lblMember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(146, 67);
            this.lblMember.TabIndex = 2;
            this.lblMember.Text = "Üye:";
            this.lblMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMembers
            // 
            this.cmbMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMembers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMembers.Location = new System.Drawing.Point(171, 91);
            this.cmbMembers.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.cmbMembers.Name = "cmbMembers";
            this.cmbMembers.Size = new System.Drawing.Size(681, 31);
            this.cmbMembers.TabIndex = 3;
            // 
            // lblLoanDate
            // 
            this.lblLoanDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoanDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLoanDate.Location = new System.Drawing.Point(17, 149);
            this.lblLoanDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanDate.Name = "lblLoanDate";
            this.lblLoanDate.Size = new System.Drawing.Size(146, 67);
            this.lblLoanDate.TabIndex = 4;
            this.lblLoanDate.Text = "Ödünç Tarihi:";
            this.lblLoanDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpLoanDate
            // 
            this.dtpLoanDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpLoanDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLoanDate.Location = new System.Drawing.Point(171, 158);
            this.dtpLoanDate.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.dtpLoanDate.Name = "dtpLoanDate";
            this.dtpLoanDate.Size = new System.Drawing.Size(681, 30);
            this.dtpLoanDate.TabIndex = 5;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReturnDate.Location = new System.Drawing.Point(17, 216);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(146, 67);
            this.lblReturnDate.TabIndex = 6;
            this.lblReturnDate.Text = "Geri Alma Tarihi:";
            this.lblReturnDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpReturnDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(171, 225);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(681, 30);
            this.dtpReturnDate.TabIndex = 7;
            // 
            // actionLayout
            // 
            this.actionLayout.BackColor = System.Drawing.Color.White;
            this.actionLayout.ColumnCount = 1;
            this.actionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.actionLayout.Controls.Add(this.btnLoan, 0, 1);
            this.actionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionLayout.Location = new System.Drawing.Point(882, 0);
            this.actionLayout.Margin = new System.Windows.Forms.Padding(0);
            this.actionLayout.Name = "actionLayout";
            this.actionLayout.Padding = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.actionLayout.RowCount = 3;
            this.actionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.actionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.actionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.actionLayout.Size = new System.Drawing.Size(344, 298);
            this.actionLayout.TabIndex = 1;
            // 
            // btnLoan
            // 
            this.btnLoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLoan.Location = new System.Drawing.Point(17, 114);
            this.btnLoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(310, 70);
            this.btnLoan.TabIndex = 0;
            this.btnLoan.Text = "Ödünç Ver";
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // gridPanel
            // 
            this.gridPanel.BackColor = System.Drawing.Color.White;
            this.gridPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridPanel.Controls.Add(this.dgvRecentLoans);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(19, 339);
            this.gridPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(1218, 553);
            this.gridPanel.TabIndex = 1;
            // 
            // dgvRecentLoans
            // 
            this.dgvRecentLoans.AllowUserToAddRows = false;
            this.dgvRecentLoans.AllowUserToDeleteRows = false;
            this.dgvRecentLoans.AllowUserToResizeRows = false;
            this.dgvRecentLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentLoans.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentLoans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentLoans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentLoans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecentLoans.ColumnHeadersHeight = 40;
            this.dgvRecentLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecentLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentLoans.EnableHeadersVisualStyles = false;
            this.dgvRecentLoans.Location = new System.Drawing.Point(0, 0);
            this.dgvRecentLoans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRecentLoans.MultiSelect = false;
            this.dgvRecentLoans.Name = "dgvRecentLoans";
            this.dgvRecentLoans.ReadOnly = true;
            this.dgvRecentLoans.RowHeadersVisible = false;
            this.dgvRecentLoans.RowHeadersWidth = 51;
            this.dgvRecentLoans.RowTemplate.Height = 34;
            this.dgvRecentLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentLoans.Size = new System.Drawing.Size(1216, 551);
            this.dgvRecentLoans.TabIndex = 0;
            // 
            // LoansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1286, 951);
            this.Controls.Add(this.mainLayout);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(972, 742);
            this.Name = "LoansForm";
            this.Padding = new System.Windows.Forms.Padding(15, 18, 15, 18);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kitap Ödünç Ver";
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.topLayout.ResumeLayout(false);
            this.topLayout.PerformLayout();
            this.formLayout.ResumeLayout(false);
            this.actionLayout.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentLoans)).EndInit();
            this.ResumeLayout(false);

        }
    }
}