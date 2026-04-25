using System.Drawing;
using System.Windows.Forms;

namespace LibraryLoanSystem.Forms
{
    internal static class Theme
    {
        public static Font DefaultFont { get; } = new Font("Segoe UI", 10F);
        public static Padding DefaultPadding { get; } = new Padding(12);
        public static Color BackgroundColor { get; } = Color.FromArgb(245, 247, 250);
        public static Color CardBackground { get; } = Color.White;
        public static Color PrimaryColor { get; } = Color.FromArgb(32, 136, 203);
        public static Color TextColor { get; } = Color.FromArgb(33, 37, 41);
    }
}
