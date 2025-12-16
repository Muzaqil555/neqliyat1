using System;
using System.Windows.Forms;

namespace IctimaiNeqliyyatSistemi_WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
