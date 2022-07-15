using System;
using System.Windows.Forms;

namespace ServerTap_GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        if (!System.IO.File.Exists("server.json"))
        {
            Application.Run(new AddServer());
        }
        else
        {
            Application.Run(new panel());
        }
        }
    }
}
