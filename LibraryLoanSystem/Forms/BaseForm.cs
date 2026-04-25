using System.ComponentModel;
using System;
using System.Windows.Forms;

namespace LibraryLoanSystem.Forms
{
    public class BaseForm : Form
    {
        protected ErrorProvider ErrorProvider { get; private set; }

        public BaseForm()
        {
        }

        protected bool IsDesignTime
        {
            get
            {
                return DesignTimeHelper.IsInDesigner(this);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (IsDesignTime)
            {
                return;
            }

            EnsureErrorProvider();
            // apply runtime styling to child controls after they have been initialized
            ControlStyler.Apply(this);
        }

        protected void SetError(Control control, string message)
        {
            if (control == null) return;
            EnsureErrorProvider();
            ErrorProvider.SetError(control, message ?? string.Empty);
        }

        protected void ClearErrors()
        {
            if (ErrorProvider == null)
            {
                return;
            }

            ErrorProvider.Clear();
        }

        private void EnsureErrorProvider()
        {
            if (ErrorProvider != null)
            {
                return;
            }

            ErrorProvider = new ErrorProvider();
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

    }
}
