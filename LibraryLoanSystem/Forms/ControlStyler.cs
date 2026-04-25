using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibraryLoanSystem.Forms
{
    internal static class ControlStyler
    {
        public static void Apply(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                StyleControlRecursive(c);
            }
        }

        private static void StyleControlRecursive(Control c)
        {
            if (c is Button b)
            {
                b.BackColor = Theme.PrimaryColor;
                b.ForeColor = Color.White;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Font = Theme.DefaultFont;
                b.Padding = new Padding(6, 0, 6, 0);
                b.TextAlign = ContentAlignment.MiddleCenter;
                b.AutoEllipsis = true;
            }
            else if (c is Label l)
            {
                l.ForeColor = Theme.TextColor;
                l.Font = Theme.DefaultFont;
            }
            else if (c is TextBox tb)
            {
                tb.Font = Theme.DefaultFont;
                tb.ForeColor = Theme.TextColor;
                tb.BackColor = Color.White;
            }
            else if (c is ComboBox cb)
            {
                cb.Font = Theme.DefaultFont;
                cb.ForeColor = Theme.TextColor;
            }
            else if (c is DataGridView dgv)
            {
                ApplyDataGridViewStyle(dgv);
            }

            // apply paddings for panels/cards
            if (c is Panel p || c is TableLayoutPanel)
            {
                c.BackColor = Theme.CardBackground;
            }

            foreach (Control child in c.Controls)
            {
                StyleControlRecursive(child);
            }
        }

        private static void ApplyDataGridViewStyle(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            if (dgv.ColumnHeadersHeight < 40)
            {
                dgv.ColumnHeadersHeight = 40;
            }

            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.GridColor = Color.FromArgb(230, 230, 230);
            dgv.RowTemplate.Height = 34;
            dgv.EnableHeadersVisualStyles = false;

            dgv.DefaultCellStyle.Font = Theme.DefaultFont;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Theme.TextColor;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Theme.PrimaryColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
        }
    }
}
