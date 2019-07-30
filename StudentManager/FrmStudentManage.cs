using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;

namespace StudentManager
{
    public partial class FrmStudentManage : Form
    {
        private StudentClassService studentClassService = new StudentClassService();
        public FrmStudentManage()
        {
            InitializeComponent();
            this.cboClass.DataSource = studentClassService.GetStudentClass();
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";
            this.cboClass.SelectedIndex = -1;

            this.dgvStudentList.AutoGenerateColumns = false;
        }

        private void FrmStudentManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.frmStudentManage = null;
        }

        /// <summary>
        /// 根据班级查询学生列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            if (this.cboClass.SelectedIndex == -1)
            {
                MessageBox.Show("请选择班级", "提示信息");
                return;
            }

            var studentClassId = Convert.ToInt32(this.cboClass.SelectedValue);
            StudentClass studentClass = new StudentClass(){ClassId = studentClassId };

            var studentsList = studentClassService.QueryStudentsByClassId(studentClass);
            if (studentsList.Count == 0)
            {
                this.dgvStudentList.DataSource = null;
                MessageBox.Show("查询结果为空！", "提示信息");
                return;
            }
            this.dgvStudentList.DataSource = null;
            this.dgvStudentList.DataSource = studentsList;
        }

        /// <summary>
        /// 修改学员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 删除学员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 根据学号精确查找学员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQueryById_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
