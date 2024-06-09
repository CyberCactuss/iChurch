using System;
using System.Windows.Forms;

namespace ChurchSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LogIn loginForm = new LogIn();
            Application.Run(loginForm); 
        }
    }
}
