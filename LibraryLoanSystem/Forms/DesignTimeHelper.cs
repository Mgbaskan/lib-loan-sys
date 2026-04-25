using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace LibraryLoanSystem.Forms
{
    internal static class DesignTimeHelper
    {
        public static bool IsInDesigner(Control control)
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime
                || (control != null && control.Site != null && control.Site.DesignMode)
                || IsVisualStudioDesignerProcess();
        }

        private static bool IsVisualStudioDesignerProcess()
        {
            string processName = Process.GetCurrentProcess().ProcessName;
            return string.Equals(processName, "devenv", StringComparison.OrdinalIgnoreCase)
                || string.Equals(processName, "XDesProc", StringComparison.OrdinalIgnoreCase)
                || string.Equals(processName, "DesignToolsServer", StringComparison.OrdinalIgnoreCase);
        }
    }
}
