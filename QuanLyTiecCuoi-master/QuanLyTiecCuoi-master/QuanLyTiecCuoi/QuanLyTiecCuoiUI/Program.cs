using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using QuanLyTiecCuoiUI.FormFeature.ConfigDatabase;
using QuanLyTiecCuoiUI.FormFeature.QuyDinh;

namespace QuanLyTiecCuoiUI
{
    static class Program
    {
        public static frmMain manhinhchinh;
        public static frmLoginForm dangnhapform;
        public static void KhoiTaoForm()
        {
            manhinhchinh = new frmMain();
            dangnhapform = new frmLoginForm();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseHelper.CONNECTION_STRING = QuanLyTiecCuoiUI.Properties.Settings.Default.ConnectionString;
            Console.WriteLine(DatabaseHelper.CONNECTION_STRING);
            bool openSuscess = DatabaseHelper.OpenConnection();
            DatabaseHelper.CloseConnection();
            if (!openSuscess)
            {
                Application.Run(new frmConfigDatabase());
                //if (openSuscess)
                //{
                //    KhoiTaoForm();
                //    Application.Run(dangnhapform);
                //    //Console.WriteLine("aaaaaaaaa");
                //}
            }
            else
            {
                KhoiTaoForm();
                Application.Run(manhinhchinh);
            }
        }

    }
}