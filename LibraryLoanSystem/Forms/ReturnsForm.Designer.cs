﻿using System.Drawing;
using System.Windows.Forms;

namespace LibraryLoanSystem.Forms
{
    partial class ReturnsForm
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private TableLayoutPanel topLayout;
        private TableLayoutPanel formLayout;
        private TableLayoutPanel actionLayout;
        private Panel gridPanel;

        private Label lblLoan;
        private ComboBox cmbActiveLoans;
        private Button btnReturn;
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
            this.topLayout = new TableLayoutPanel();
            this.formLayout = new TableLayoutPanel();
            this.actionLayout = new TableLayoutPanel();
            this.gridPanel = new Panel();

            this.lblLoan = new Label();
            this.cmbActiveLoans = new ComboBox();
            this.btnReturn = new Button();
            this.dgvActiveLoans = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveLoans)).BeginInit();
            this.mainLayout.SuspendLayout();
            this.topLayout.SuspendLayout();
            this.formLayout.SuspendLayout();
            this.actionLayout.SuspendLayout();
            this.gridPanel.SuspendLayout();
            this.SuspendLayout();

            // mainLayout
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.mainLayout.Dock = DockStyle.Fill;
            this.mainLayout.Padding = new Padding(12);
            this.mainLayout.BackColor = Color.FromArgb(245, 247, 250);

            // topLayout
            this.topLayout.ColumnCount = 2;
            this.topLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            this.topLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.topLayout.RowCount = 1;
            this.topLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.topLayout.Dock = DockStyle.Top;
            this.topLayout.AutoSize = true;
            this.topLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.topLayout.Margin = new Padding(0, 0, 0, 12);

            // formLayout
            this.formLayout.ColumnCount = 2;
            this.formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            this.formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.formLayout.RowCount = 1;
            this.formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            this.formLayout.Dock = DockStyle.Fill;
            this.formLayout.Padding = new Padding(10);
            this.formLayout.BackColor = Color.White;
            this.formLayout.Margin = new Padding(0, 0, 10, 0);
            this.formLayout.AutoSize = true;
            this.formLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // lblLoan
            this.lblLoan.Text = "Aktif Ödünç:";
            this.lblLoan.TextAlign = ContentAlignment.MiddleLeft;
            this.lblLoan.Dock = DockStyle.Fill;
            this.lblLoan.Margin = new Padding(3);
            this.lblLoan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // cmbActiveLoans
            this.cmbActiveLoans.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbActiveLoans.Dock = DockStyle.Fill;
            this.cmbActiveLoans.Margin = new Padding(3);
            this.cmbActiveLoans.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.cmbActiveLoans.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // actionLayout
            this.actionLayout.ColumnCount = 1;
            this.actionLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.actionLayout.RowCount = 3;
            this.actionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.actionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            this.actionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.actionLayout.Dock = DockStyle.Fill;
            this.actionLayout.Padding = new Padding(10);
            this.actionLayout.BackColor = Color.White;
            this.actionLayout.Margin = new Padding(0);
            this.actionLayout.AutoSize = true;
            this.actionLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // btnReturn
            this.btnReturn.Text = "Teslim Al";
            this.btnReturn.Dock = DockStyle.Fill;
            this.btnReturn.Margin = new Padding(3);
            this.btnReturn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);

            // dgvActiveLoans
            this.dgvActiveLoans.AllowUserToAddRows = false;
            this.dgvActiveLoans.AllowUserToDeleteRows = false;
            this.dgvActiveLoans.AllowUserToResizeRows = false;
            this.dgvActiveLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActiveLoans.BackgroundColor = Color.White;
            this.dgvActiveLoans.BorderStyle = BorderStyle.None;
            this.dgvActiveLoans.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvActiveLoans.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvActiveLoans.ColumnHeadersHeight = 40;
            this.dgvActiveLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvActiveLoans.Dock = DockStyle.Fill;
            this.dgvActiveLoans.EnableHeadersVisualStyles = false;
            this.dgvActiveLoans.MultiSelect = false;
            this.dgvActiveLoans.Name = "dgvActiveLoans";
            this.dgvActiveLoans.ReadOnly = true;
            this.dgvActiveLoans.RowHeadersVisible = false;
            this.dgvActiveLoans.RowTemplate.Height = 34;
            this.dgvActiveLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvActiveLoans.CellClick += new DataGridViewCellEventHandler(this.dgvActiveLoans_CellClick);
// gridPanel
            this.gridPanel.Dock = DockStyle.Fill;
            this.gridPanel.Padding = new Padding(0);
            this.gridPanel.BackColor = Color.White;
            this.gridPanel.BorderStyle = BorderStyle.FixedSingle;
            this.gridPanel.Margin = new Padding(0);
            this.gridPanel.Controls.Add(this.dgvActiveLoans);

            // formLayout controls
            this.formLayout.Controls.Add(this.lblLoan, 0, 0);
            this.formLayout.Controls.Add(this.cmbActiveLoans, 1, 0);

            // actionLayout controls
            this.actionLayout.Controls.Add(this.btnReturn, 0, 1);

            // topLayout controls
            this.topLayout.Controls.Add(this.formLayout, 0, 0);
            this.topLayout.Controls.Add(this.actionLayout, 1, 0);

            // mainLayout controls
            this.mainLayout.Controls.Add(this.topLayout, 0, 0);
            this.mainLayout.Controls.Add(this.gridPanel, 0, 1);

            // ReturnsForm
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 600);
            this.MinimumSize = new Size(760, 460);
            this.Controls.Add(this.mainLayout);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Kitap Teslim Al";
            this.BackColor = Color.FromArgb(245, 247, 250);

            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveLoans)).EndInit();
            this.gridPanel.ResumeLayout(false);
            this.actionLayout.ResumeLayout(false);
            this.formLayout.ResumeLayout(false);
            this.topLayout.ResumeLayout(false);
            this.topLayout.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}