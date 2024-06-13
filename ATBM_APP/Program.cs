using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_APP
{
    public static class Account 
    {
        //thông tin kết nối đến cơ sở dữ liệu
        public static string username = "";
        public static string password = "";
        public static string connectString = "";
        public static string host = "localhost";
        public static int port = 1521;
        public static string sid = "xe";
        public static string service = "pdbqldlnb";

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
            Application.Run(new LoginForm());
        }
    }
}
