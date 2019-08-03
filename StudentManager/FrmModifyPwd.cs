using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DAL;

namespace StudentManager
{
    public partial class FrmModifyPwd : Form
    {
        private SysAdminService adminService = new SysAdminService();
        public FrmModifyPwd()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FrmMain.frmModifyPwd = null;
            this.Close();
        }

        private void FrmModifyPwd_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.frmModifyPwd = null;
        }

        /// <summary>
        /// 确认修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModify_Click(object sender, EventArgs e)
        {
            #region 数据校验
            if (this.txtOldPwd.Text != Program.adminLogin.LoginPwd)
            {
                MessageBox.Show("原密码错误!", "提示信息");
                this.txtOldPwd.Focus();
                this.txtOldPwd.SelectAll();
                return;
            }
            if (this.txtNewPwd.Text.Trim().Length <6)
            {
                MessageBox.Show("新密码不能小于6位!", "提示信息");
                this.txtNewPwd.Focus();
                return;
            }

            if (this.txtNewPwdConfirm.Text.Trim().Length == 0)
            {
                MessageBox.Show("确认密码不能为空!", "提示信息");
                this.txtNewPwdConfirm.Focus();
                return;
            }

            if (this.txtNewPwd.Text.Trim() != this.txtNewPwdConfirm.Text.Trim())
            {
                MessageBox.Show("两次输入的新密码不一致!", "提示信息");
                this.txtNewPwdConfirm.Focus();
                this.txtNewPwdConfirm.SelectAll();
                return;
            }
            #endregion

            #region 数据组装
            SysAdmin sysAdmin = new SysAdmin
            {
                LoginId = Program.adminLogin.LoginId,
                AdminName = Program.adminLogin.AdminName,
                LoginPwd = this.txtNewPwd.Text.Trim(),
            };

            #endregion

            #region 调用后台
            try
            {
                var result = adminService.ModifyPwd(sysAdmin);

                if (result == 1)
                {
                    MessageBox.Show("密码修改成功!", "提示信息");
                    //保存密码到Program.adminLogin对象
                    Program.adminLogin = sysAdmin;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            #endregion
        }
    }
}
