using System.Drawing;
using System.Windows.Forms;

namespace LibraryLoanSystem.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private TableLayoutPanel contentLayout;
        private TableLayoutPanel headerLayout;
        private Panel menuCard;
        private TableLayoutPanel menuLayout;

        private Label lblTitle;
        private PictureBox picLogo;
        private Panel panelMenu;
        private Button btnBooks;
        private Button btnMembers;
        private Button btnAuthors;
        private Button btnCategories;
        private Button btnLoans;
        private Button btnReturns;
        private Button btnActiveLoans;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                if (picLogo != null && picLogo.Image != null)
                    picLogo.Image.Dispose();

                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.contentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.menuCard = new System.Windows.Forms.Panel();
            this.menuLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnLoans = new System.Windows.Forms.Button();
            this.btnReturns = new System.Windows.Forms.Button();
            this.btnActiveLoans = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.mainLayout.SuspendLayout();
            this.headerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.contentLayout.SuspendLayout();
            this.menuCard.SuspendLayout();
            this.menuLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.headerLayout, 0, 0);
            this.mainLayout.Controls.Add(this.contentLayout, 0, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(12, 12);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(23, 21, 23, 21);
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(1119, 669);
            this.mainLayout.TabIndex = 0;
            // 
            // headerLayout
            // 
            this.headerLayout.BackColor = System.Drawing.Color.Transparent;
            this.headerLayout.ColumnCount = 1;
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.Controls.Add(this.picLogo, 0, 0);
            this.headerLayout.Controls.Add(this.lblTitle, 0, 1);
            this.headerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLayout.Location = new System.Drawing.Point(26, 24);
            this.headerLayout.Name = "headerLayout";
            this.headerLayout.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.headerLayout.RowCount = 2;
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.Size = new System.Drawing.Size(1067, 214);
            this.headerLayout.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Location = new System.Drawing.Point(0, 10);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(1067, 112);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 130);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(1067, 84);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "KÜTÜPHANE OTOMASYONU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentLayout
            // 
            this.contentLayout.BackColor = System.Drawing.Color.Transparent;
            this.contentLayout.ColumnCount = 3;
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.contentLayout.Controls.Add(this.menuCard, 1, 1);
            this.contentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLayout.Location = new System.Drawing.Point(26, 244);
            this.contentLayout.Name = "contentLayout";
            this.contentLayout.RowCount = 3;
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.contentLayout.Size = new System.Drawing.Size(1067, 401);
            this.contentLayout.TabIndex = 1;
            // 
            // menuCard
            // 
            this.menuCard.BackColor = System.Drawing.Color.White;
            this.menuCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuCard.Controls.Add(this.menuLayout);
            this.menuCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuCard.Location = new System.Drawing.Point(266, 60);
            this.menuCard.Margin = new System.Windows.Forms.Padding(0);
            this.menuCard.Name = "menuCard";
            this.menuCard.Padding = new System.Windows.Forms.Padding(21, 19, 21, 19);
            this.menuCard.Size = new System.Drawing.Size(533, 280);
            this.menuCard.TabIndex = 0;
            // 
            // menuLayout
            // 
            this.menuLayout.BackColor = System.Drawing.Color.White;
            this.menuLayout.ColumnCount = 1;
            this.menuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuLayout.Controls.Add(this.btnBooks, 0, 0);
            this.menuLayout.Controls.Add(this.btnMembers, 0, 1);
            this.menuLayout.Controls.Add(this.btnAuthors, 0, 2);
            this.menuLayout.Controls.Add(this.btnCategories, 0, 3);
            this.menuLayout.Controls.Add(this.btnLoans, 0, 4);
            this.menuLayout.Controls.Add(this.btnReturns, 0, 5);
            this.menuLayout.Controls.Add(this.btnActiveLoans, 0, 6);
            this.menuLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuLayout.Location = new System.Drawing.Point(21, 19);
            this.menuLayout.Name = "menuLayout";
            this.menuLayout.Padding = new System.Windows.Forms.Padding(11);
            this.menuLayout.RowCount = 7;
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.menuLayout.Size = new System.Drawing.Size(489, 240);
            this.menuLayout.TabIndex = 0;
            // 
            // btnBooks
            // 
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBooks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBooks.Location = new System.Drawing.Point(22, 22);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(11);
            this.btnBooks.MinimumSize = new System.Drawing.Size(206, 35);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(445, 35);
            this.btnBooks.TabIndex = 0;
            this.btnBooks.Text = "Kitap Yönetimi";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMembers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMembers.Location = new System.Drawing.Point(22, 53);
            this.btnMembers.Margin = new System.Windows.Forms.Padding(11);
            this.btnMembers.MinimumSize = new System.Drawing.Size(206, 35);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(445, 35);
            this.btnMembers.TabIndex = 1;
            this.btnMembers.Text = "Üye Yönetimi";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnAuthors
            // 
            this.btnAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAuthors.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAuthors.Location = new System.Drawing.Point(22, 84);
            this.btnAuthors.Margin = new System.Windows.Forms.Padding(11);
            this.btnAuthors.MinimumSize = new System.Drawing.Size(206, 35);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(445, 35);
            this.btnAuthors.TabIndex = 2;
            this.btnAuthors.Text = "Yazar Yönetimi";
            this.btnAuthors.UseVisualStyleBackColor = true;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCategories.Location = new System.Drawing.Point(22, 115);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(11);
            this.btnCategories.MinimumSize = new System.Drawing.Size(206, 35);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(445, 35);
            this.btnCategories.TabIndex = 3;
            this.btnCategories.Text = "Kategori Yönetimi";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnLoans
            // 
            this.btnLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoans.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLoans.Location = new System.Drawing.Point(22, 146);
            this.btnLoans.Margin = new System.Windows.Forms.Padding(11);
            this.btnLoans.MinimumSize = new System.Drawing.Size(206, 35);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Size = new System.Drawing.Size(445, 35);
            this.btnLoans.TabIndex = 4;
            this.btnLoans.Text = "Kitap Ödünç Ver";
            this.btnLoans.UseVisualStyleBackColor = true;
            this.btnLoans.Click += new System.EventHandler(this.btnLoans_Click);
            // 
            // btnReturns
            // 
            this.btnReturns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturns.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReturns.Location = new System.Drawing.Point(22, 177);
            this.btnReturns.Margin = new System.Windows.Forms.Padding(11);
            this.btnReturns.MinimumSize = new System.Drawing.Size(206, 35);
            this.btnReturns.Name = "btnReturns";
            this.btnReturns.Size = new System.Drawing.Size(445, 35);
            this.btnReturns.TabIndex = 5;
            this.btnReturns.Text = "Kitap Teslim Al";
            this.btnReturns.UseVisualStyleBackColor = true;
            this.btnReturns.Click += new System.EventHandler(this.btnReturns_Click);
            // 
            // btnActiveLoans
            // 
            this.btnActiveLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActiveLoans.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnActiveLoans.Location = new System.Drawing.Point(22, 208);
            this.btnActiveLoans.Margin = new System.Windows.Forms.Padding(11);
            this.btnActiveLoans.MinimumSize = new System.Drawing.Size(206, 35);
            this.btnActiveLoans.Name = "btnActiveLoans";
            this.btnActiveLoans.Size = new System.Drawing.Size(445, 35);
            this.btnActiveLoans.TabIndex = 6;
            this.btnActiveLoans.Text = "Aktif Ödünçler";
            this.btnActiveLoans.UseVisualStyleBackColor = true;
            this.btnActiveLoans.Click += new System.EventHandler(this.btnActiveLoans_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 100);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1143, 693);
            this.Controls.Add(this.mainLayout);
            this.MinimumSize = new System.Drawing.Size(912, 584);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyonu";
            this.mainLayout.ResumeLayout(false);
            this.headerLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.contentLayout.ResumeLayout(false);
            this.menuCard.ResumeLayout(false);
            this.menuLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
