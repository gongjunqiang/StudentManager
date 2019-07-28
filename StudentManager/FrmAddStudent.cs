using StudentManager.Common;
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
    public partial class FrmAddStudent : Form
    {
        private StudentService studentService = new StudentService();
        private StudentClassService studentClassService = new StudentClassService();
        public FrmAddStudent()
        {
            InitializeComponent();
            this.cboClassName.DataSource = studentClassService.GetStudentClass();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
            this.cboClassName.SelectedIndex = -1;
        }

        //关闭窗体
        private void FrmAddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.frmAddStudent = null;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确认添加学员
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            #region 数据验证
            if (this.txtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("姓名不能为空!", "提示信息");
                this.txtStudentName.Focus();
                return;
            }

            string gender = string.Empty;
            if (this.rdoMale.Checked == true)
            {
                gender = this.rdoMale.Text;
            }

            if (this.rdoFemale.Checked == true)
            {
                gender = this.rdoFemale.Text;
            }

            if (this.cboClassName.SelectedIndex==-1)
            {
                MessageBox.Show("请选择班级!", "提示信息");
                return;
            }


            if (this.dtpBirthday.Value> DateTime.Now)
            {
                MessageBox.Show("出生日期不能大于当前时间!", "提示信息");
                return;
            }

            //年龄验证

            //身份证日期与出生日期比较

            if (!DataValidate.IsIdentityCard(this.txtStudentIdNo.Text))
            {
                MessageBox.Show("身份证号格式错误!","提示信息");
                this.txtStudentIdNo.Focus();
                return;
            }

            if (this.txtCardNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("考勤卡号不能为空!", "提示信息");
                this.txtStudentName.Focus();
                return;
            }


            if (this.txtPhoneNumber.Text.Trim().Length != 11)
            {
                MessageBox.Show("电话号码格式错误!", "提示信息");
                this.txtPhoneNumber.Focus();
                return;
            }

            //验证身份证号是否重复
            if (studentService.IsIdNoExisten(this.txtStudentIdNo.Text))
            {
                MessageBox.Show("身份证号码重复，请确认!", "提示信息");
                this.txtStudentIdNo.Focus();
                this.txtStudentIdNo.SelectAll();
                return;
            }

            #endregion

            #region 封装数据
            Students student = new Students
            {
                StudentName = this.txtStudentName.Text.Trim(),
                Gender = gender,
                Birthday = this.dtpBirthday.Value,
                StudentIdNo = this.txtStudentIdNo.Text.Trim(),
                Age = DateTime.Now.Year - this.dtpBirthday.Value.Year,
                PhoneNumber = this.txtPhoneNumber.Text.Trim(),
                StudentAddress = this.txtAddress.Text.Trim(),
                CardNo = this.txtCardNo.Text.Trim(),
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
            };
            #endregion

            #region 调用后台
            try
            {
                var result = studentService.AddStudent(student);
                if (result == 1)
                {
                    DialogResult dialogResult = MessageBox.Show("学员添加成功,是否继续添加？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.cboClassName.SelectedIndex = -1;
                        this.rdoFemale.Checked = false;
                        this.rdoMale.Checked = false;
                        //清空所有文本框
                        foreach (Control item in this.Controls)
                        {
                            if (item is TextBox)
                            {
                                item.Text = "";
                            }
                        }
                        this.txtStudentName.Focus();
                    }
                }
                else
                {
                    this.Close();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        #region 用户体验
        private void TxtStudentIdNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (this.txtStudentIdNo.Text.Length != 0)
                {
                    this.txtCardNo.Focus();
                }
                
            }
        }
        #endregion

    }
}
