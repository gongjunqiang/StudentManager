using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace StudentManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //创建登录窗体

            //Application.Run(new FrmMain());

            FrmLogin frmLogin = new FrmLogin();
            DialogResult result = frmLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }

        }
        public static SysAdmin adminLogin=null;

    }
}
