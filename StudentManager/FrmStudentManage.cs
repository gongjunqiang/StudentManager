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
        private StudentService studentService = new StudentService();

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
            this.dgvStudentList.ClearSelection();
        }

        /// <summary>
        /// 修改学员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("请选择需要修改的学员！", "提示信息");
                return;
            }
            int studentId = Convert.ToInt32(this.dgvStudentList.CurrentRow.Cells["StudentId"].Value);
            StudentExt result = studentService.QueryStudentByStudengtId(studentId);
            FrmEditStudent frmEditStudent = new FrmEditStudent(result);
            frmEditStudent.ShowDialog();
            if (frmEditStudent.DialogResult == DialogResult.OK)
            {
                BtnQuery_Click(null, null);//同步刷新
            }
        }


        /// <summary>
        /// 删除学员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("请选择需要删除的学员！", "提示信息");
                return;
            }
            string studentName = this.dgvStudentList.CurrentRow.Cells["StudentName"].Value.ToString();
            int studentId = Convert.ToInt32(this.dgvStudentList.CurrentRow.Cells["StudentId"].Value);
            //删除确认
            DialogResult dialogResult = MessageBox.Show($"确认删除学员 [{studentName}] 吗？", "确认删除",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                var result = studentService.DeleteStudentById(studentId);
                if (result == 1)
                {
                    BtnQuery_Click(null, null);
                    MessageBox.Show("删除成功！", "提示信息");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("删除失败！", "提示信息");
            }
           
        }

        /// <summary>
        /// 根据学号精确查找学员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQueryById_Click(object sender, EventArgs e)
        {
            if (this.txtStudentId.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入您要查询的学号！", "提示信息");
                return;
            }
            var studentId = Convert.ToInt32(this.txtStudentId.Text.Trim());
            StudentExt result = studentService.QueryStudentByStudengtId(studentId);
      
            if (result == null)
            {
                MessageBox.Show($"没有学号为{studentId}的学生，请输入正确的学号！", "提示信息");
                return;
            }
            else
            {
                FrmStudentInfo frmStudentInfo = new FrmStudentInfo(result);
                frmStudentInfo.Show();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                BtnQueryById_Click(null, null);
            }
        }

        private void DgvStudentList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvStudentList.ClearSelection();
        }

        #region 菜单删除与修改学员事件
        private void DgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvStudentList.CurrentRow != null)
            {
                var studentId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
                this.txtStudentId.Text = studentId;
                BtnQueryById_Click(null, null);
            }
        }

        private void MenuModifyStudent_Click(object sender, EventArgs e)
        {
            BtnEdit_Click(null, null);
        }


        private void MenuDeleteStudent_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.CurrentRow != null)
            {
                BtnDelete_Click(null, null);
            }
        }
        #endregion

        /// <summary>
        /// 通过键盘Delete键出发删除学员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvStudentList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                BtnDelete_Click(null,null);
            }
        }
    }
}
