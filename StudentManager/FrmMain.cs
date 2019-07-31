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
            this.lblCurrentUser.Text = Program.adminLogin.AdminName + "]";
        }

        private void TmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 添加学员
        public static FrmAddStudent frmAddStudent = null;
        //菜单栏：添加学员
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
        //工具栏：添加学员
        private void TsbAddStudent_Click(object sender, EventArgs e)
        {
            TsmiAddStudent_Click(null, null);
        }
        #endregion

        #region 学员信息管理
        public static FrmStudentManage frmStudentManage = null;
        //菜单栏：学员信息管理
        private void TsmiManageStudent_Click(object sender, EventArgs e)
        {
            if (frmStudentManage == null)
            {
                frmStudentManage = new FrmStudentManage();
                frmStudentManage.Show();
            }
            else
            {
                frmStudentManage.Activate();
                frmStudentManage.WindowState = FormWindowState.Normal;
            }
        }
        //工具栏：学员信息管理
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            TsmiManageStudent_Click(null, null);
        }
        #endregion

        #region 成绩查询与分析
        public static FrmScoreManage frmScoreManage = null;
        private void TsmiQueryAndAnalysis_Click(object sender, EventArgs e)
        {
            if (frmScoreManage == null)
            {
                frmScoreManage = new FrmScoreManage();
                frmScoreManage.Show();
            }
            else
                frmScoreManage.Activate();
                frmScoreManage.WindowState = FormWindowState.Normal;
        }
        private void TsbScoreAnalysis_Click(object sender, EventArgs e)
        {
            TsmiQueryAndAnalysis_Click(null, null);
        }
    

    
        #endregion

        #region 成绩快速查询

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
    
