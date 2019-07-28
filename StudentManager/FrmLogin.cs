using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using DAL;
using Model;

namespace StudentManager
{
    public partial class FrmLogin : Form
    {
        private SysAdminService adminService = new SysAdminService();

        public FrmLogin()
        {
            InitializeComponent();
           
        }

        #region 窗体移动代码
        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//鼠标是否为左键
        private void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);//获取移动变量的值
                leftFlag = true;//点击左键按下时标注为true
            }
        }

        private void Frm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后leftFalg为false
            }
        }

        private void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);//设置移动的位置
                Location = mouseSet;
            }
        }


        #endregion

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtLoginAccount.Text.Trim().Length == 0)
            {
                MessageBox.Show("登录账号不能为空!", "提示信息!");
                this.txtLoginAccount.Focus();
                return;
            }

            if (this.txtLoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("登录密码不能为空!", "提示信息!");
                this.txtLoginPwd.Focus();
                return;
            }

            SysAdmin admin = new SysAdmin
            {
                LoginPwd = this.txtLoginPwd.Text,
                AdminName = this.txtLoginAccount.Text
            };
            admin = adminService.AdminLogin(admin);
            try
            {
                if (admin == null)
                {
                    MessageBox.Show("账号或密码错误!", "提示信息!");
                    return;
                }
                else
                {
                    Program.adminLogin = admin;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据访问出现异常，具体原因:"+ ex.Message);
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 改善用户体验
        private void TxtLoginAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (this.txtLoginAccount.Text.Trim().Length != 0)
                {
                    this.txtLoginPwd.Focus();

                }

            }
        }
      
        private void TxtLoginPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(null, null);
            }
        }
        #endregion
    }
}
