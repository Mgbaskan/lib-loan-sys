﻿using System.Drawing;
using System.Windows.Forms;

namespace LibraryLoanSystem.Forms
{
    partial class ActiveLoansForm
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private Panel contentPanel;
        private DataGridView dgvActiveLoans;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainLayout = new TableLayoutPanel();
            this.contentPanel = new Panel();
            this.dgvActiveLoans = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveLoans)).BeginInit();
            this.mainLayout.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();

            // mainLayout
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.mainLayout.Dock = DockStyle.Fill;
            this.mainLayout.Padding = new Padding(12);
            this.mainLayout.BackColor = Color.FromArgb(245, 247, 250);

            // contentPanel
            this.contentPanel.Dock = DockStyle.Fill;
            this.contentPanel.Padding = new Padding(0);
            this.contentPanel.BackColor = Color.White;
            this.contentPanel.BorderStyle = BorderStyle.FixedSingle;

            // dgvActiveLoans
            this.dgvActiveLoans.AllowUserToAddRows = false;
            this.dgvActiveLoans.AllowUserToDeleteRows = false;
            this.dgvActiveLoans.AllowUserToResizeRows = false;
            this.dgvActiveLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActiveLoans.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvActiveLoans.BackgroundColor = Color.White;
            this.dgvActiveLoans.BorderStyle = BorderStyle.None;
            this.dgvActiveLoans.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvActiveLoans.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvActiveLoans.ColumnHeadersHeight = 42;
            this.dgvActiveLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvActiveLoans.Dock = DockStyle.Fill;
            this.dgvActiveLoans.EnableHeadersVisualStyles = false;
            this.dgvActiveLoans.MultiSelect = false;
            this.dgvActiveLoans.ReadOnly = true;
            this.dgvActiveLoans.RowHeadersVisible = false;
            this.dgvActiveLoans.RowTemplate.Height = 36;
            this.dgvActiveLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
// contentPanel controls
            this.contentPanel.Controls.Add(this.dgvActiveLoans);

            // mainLayout controls
            this.mainLayout.Controls.Add(this.contentPanel, 0, 0);

            // ActiveLoansForm
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 600);
            this.MinimumSize = new Size(700, 400);
            this.Controls.Add(this.mainLayout);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Aktif Ödünçler";
            this.BackColor = Color.FromArgb(245, 247, 250);

            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveLoans)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.mainLayout.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}