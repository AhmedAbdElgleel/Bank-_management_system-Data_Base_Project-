using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TProject
{
    internal static class Program
    {
        public static SIGNIN si = new SIGNIN();
        public static Client cl = new Client();
        public static Deposit dp = new Deposit();
        public static Employee em = new Employee();
        public static Send se = new Send();
        public static Update up = new Update();
        public static Withdraw wd = new Withdraw();
        public static QOC qc = new QOC();
        public static Find_Remove fr = new Find_Remove();
        public static Add_client ac = new Add_client();
        public static Update_cl uc = new Update_cl();
        public static Issues iu = new Issues();
        public static QOE qe = new QOE();
        public static string conistring = "Data Source=NEW;Initial Catalog=PDB;Integrated Security=True";
        public static string usern, rps, acctype, id_emp, bal;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new SIGNIN());
            Application.Run(si);
        }
    }
}