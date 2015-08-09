using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FirebirdSql.Data.FirebirdClient;

namespace Cursa4_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static FbConnectionStringBuilder CS;
        public static Company Company;
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!File.Exists("base.fdb"))
            {
                MessageBox.Show("Dtabase not found. Please fix me :P");
            }
            else
            {
                Application.Run(new MainForm());
            }
            
        }
    }
}
