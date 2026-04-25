using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryLoanSystem.Forms
{
    internal static class InputValidationHelper
    {
        public static void AttachNumeric(TextBox tb, int maxLength = 9)
        {
            if (tb == null) return;
            tb.MaxLength = maxLength;
            tb.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            };

            tb.Validating += (s, e) => { tb.Text = tb.Text.Trim(); };
        }

        public static void AttachPhone(TextBox tb, int maxLength = 20)
        {
            if (tb == null) return;
            tb.MaxLength = maxLength;
            tb.KeyPress += (s, e) =>
            {
                // allow digits, space, +, -, (, ), and control chars
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && " +-()".IndexOf(e.KeyChar) < 0)
                    e.Handled = true;
            };

            tb.Validating += (s, e) => { tb.Text = tb.Text.Trim(); };
        }

        public static void AttachText(TextBox tb, int maxLength = 200)
        {
            if (tb == null) return;
            tb.MaxLength = maxLength;
            tb.Validating += (s, e) => { tb.Text = tb.Text.Trim(); };
        }

        public static bool IsPhoneValid(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return true; // optional
            // simple phone validation: allow digits and common formatting chars
            return Regex.IsMatch(phone, "^[0-9 +\\-()]{6,20}$");
        }
    }
}
