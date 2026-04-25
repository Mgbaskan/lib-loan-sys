using System;
using System.Windows.Forms;
using LibraryLoanSystem.Forms;

namespace LibraryLoanSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}