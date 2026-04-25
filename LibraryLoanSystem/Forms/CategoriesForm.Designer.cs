using System.Drawing;
using System.Windows.Forms;

namespace LibraryLoanSystem.Forms
{
    partial class CategoriesForm
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private TableLayoutPanel topLayout;
        private TableLayoutPanel formLayout;
        private TableLayoutPanel buttonLayout;
        private Panel gridPanel;

        private Label lblName;
        private TextBox txtName;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        private DataGridView dgvCategories;

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
            this.buttonLayout = new TableLayoutPanel();
            this.gridPanel = new Panel();

            this.lblName = new Label();
            this.txtName = new TextBox();

            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();

            this.dgvCategories = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.mainLayout.SuspendLayout();
            this.topLayout.SuspendLayout();
            this.formLayout.SuspendLayout();
            this.buttonLayout.SuspendLayout();
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
            this.topLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            this.topLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.topLayout.RowCount = 1;
            this.topLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.topLayout.Dock = DockStyle.Top;
            this.topLayout.AutoSize = true;
            this.topLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.topLayout.Margin = new Padding(0, 0, 0, 12);

            // formLayout
            this.formLayout.ColumnCount = 2;
            // use a fixed narrow first column to reduce space between label and input
            this.formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            this.formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.formLayout.RowCount = 1;
            this.formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            this.formLayout.Dock = DockStyle.Fill;
            this.formLayout.Padding = new Padding(10);
            this.formLayout.BackColor = Color.White;
            this.formLayout.Margin = new Padding(0, 0, 10, 0);
            this.formLayout.AutoSize = true;
            this.formLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // lblName
            this.lblName.Text = "İsim:";
            this.lblName.TextAlign = ContentAlignment.MiddleLeft;
            this.lblName.Dock = DockStyle.Fill;
            this.lblName.Margin = new Padding(3);
            this.lblName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // txtName
            this.txtName.Dock = DockStyle.Fill;
            this.txtName.Margin = new Padding(3);
            this.txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // buttonLayout
            this.buttonLayout.ColumnCount = 2;
            this.buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.buttonLayout.RowCount = 2;
            this.buttonLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            this.buttonLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            this.buttonLayout.Dock = DockStyle.Fill;
            this.buttonLayout.Padding = new Padding(10);
            this.buttonLayout.BackColor = Color.White;
            this.buttonLayout.Margin = new Padding(0);
            this.buttonLayout.AutoSize = true;
            this.buttonLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // btnAdd
            this.btnAdd.Text = "Ekle";
            this.btnAdd.Dock = DockStyle.Fill;
            this.btnAdd.Margin = new Padding(3);
            this.btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Dock = DockStyle.Fill;
            this.btnUpdate.Margin = new Padding(3);
            this.btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Text = "Sil";
            this.btnDelete.Dock = DockStyle.Fill;
            this.btnDelete.Margin = new Padding(3);
            this.btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.Text = "Temizle";
            this.btnClear.Dock = DockStyle.Fill;
            this.btnClear.Margin = new Padding(3);
            this.btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // dgvCategories
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AllowUserToResizeRows = false;
            this.dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.BackgroundColor = Color.White;
            this.dgvCategories.BorderStyle = BorderStyle.None;
            this.dgvCategories.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategories.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvCategories.ColumnHeadersHeight = 40;
            this.dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategories.Dock = DockStyle.Fill;
            this.dgvCategories.EnableHeadersVisualStyles = false;
            this.dgvCategories.MultiSelect = false;
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.RowTemplate.Height = 34;
            this.dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.CellClick += new DataGridViewCellEventHandler(this.dgvCategories_CellClick);
// gridPanel
            this.gridPanel.Dock = DockStyle.Fill;
            this.gridPanel.Padding = new Padding(0);
            this.gridPanel.BackColor = Color.White;
            this.gridPanel.BorderStyle = BorderStyle.FixedSingle;
            this.gridPanel.Margin = new Padding(0);
            this.gridPanel.Controls.Add(this.dgvCategories);

            // formLayout controls
            this.formLayout.Controls.Add(this.lblName, 0, 0);
            this.formLayout.Controls.Add(this.txtName, 1, 0);

            // buttonLayout controls
            this.buttonLayout.Controls.Add(this.btnAdd, 0, 0);
            this.buttonLayout.Controls.Add(this.btnUpdate, 1, 0);
            this.buttonLayout.Controls.Add(this.btnDelete, 0, 1);
            this.buttonLayout.Controls.Add(this.btnClear, 1, 1);

            // topLayout controls
            this.topLayout.Controls.Add(this.formLayout, 0, 0);
            this.topLayout.Controls.Add(this.buttonLayout, 1, 0);

            // mainLayout controls
            this.mainLayout.Controls.Add(this.topLayout, 0, 0);
            this.mainLayout.Controls.Add(this.gridPanel, 0, 1);

            // CategoriesForm
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 500);
            this.MinimumSize = new Size(760, 460);
            this.Controls.Add(this.mainLayout);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Kategori Yönetimi";
            this.BackColor = Color.FromArgb(245, 247, 250);

            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.gridPanel.ResumeLayout(false);
            this.buttonLayout.ResumeLayout(false);
            this.formLayout.ResumeLayout(false);
            this.topLayout.ResumeLayout(false);
            this.topLayout.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}