using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.lblCurrentUser.Text = Program.adminLogin.AdminName+"]";
        }

        private void TmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        #region 菜单栏事件
        public static FrmAddStudent frmAddStudent = null;

        //添加学员
        private void TsmiAddStudent_Click(object sender, EventArgs e)
        {
            if (frmAddStudent == null)
            {
                frmAddStudent = new FrmAddStudent();
                frmAddStudent.Show();
            }
            else
            {
                frmAddStudent.Activate();//激活只能在最小化的时候起作用
                frmAddStudent.WindowState = FormWindowState.Normal;
            }
        }
        #endregion

        #region 工具栏事件
        //添加学员
        private void TsbAddStudent_Click(object sender, EventArgs e)
        {
            TsmiAddStudent_Click(null,null);
        }
        #endregion


        #region 关闭主窗体
        private void TsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出吗？", "退出询问！", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        #endregion

    }
}
