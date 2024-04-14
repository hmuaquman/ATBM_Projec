using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_APP
{
    public static class Account
    {
        public static string username = "";
        public static string password = "";
        public static string connectString = "";
        public static string host = "192.168.174.1";
        public static int port = 1522;
        public static string sid = "xe";

    }
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
            Application.Run(new AdminForm());
        }
    }
}
