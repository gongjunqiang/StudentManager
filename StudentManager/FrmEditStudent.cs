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
    public partial class FrmEditStudent : Form
    {
        private StudentClassService studentClassService = new StudentClassService();
        private StudentService studentService = new StudentService();

        public FrmEditStudent()
        {
            InitializeComponent();
            this.cboClassName.DataSource = studentClassService.GetStudentClass();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
        }

        public FrmEditStudent(StudentExt student) :this()
        {
            this.txtStudentId.Text = student.StudentId.ToString();
            this.txtStudentName.Text = student.StudentName;
            this.cboClassName.SelectedValue = student.ClassId;
            //this.t.Text = student.Birthday.ToShortDateString();
  
            this.txtStudentIdNo.Text = student.StudentIdNo;
            this.txtCardNo.Text = student.CardNo;
            this.txtPhoneNumber.Text = student.PhoneNumber;
            this.txtAddress.Text = student.StudentAddress;

            if (student.Gender == "男")
            {
                this.rdoMale.Checked = true;
                this.rdoFemale.Checked = false;
            }
            else
            {
                this.rdoMale.Checked = false;
                this.rdoFemale.Checked = true;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Students student = new Students
            {
                StudentId = Convert.ToInt32(this.txtStudentId.Text),
                StudentName = this.txtStudentName.Text.Trim(),
                Gender = this.rdoMale.Text,
                Birthday = this.dtpBirthday.Value,
                StudentIdNo = this.txtStudentIdNo.Text.Trim(),
                Age = DateTime.Now.Year - this.dtpBirthday.Value.Year,
                PhoneNumber = this.txtPhoneNumber.Text.Trim(),
                StudentAddress = this.txtAddress.Text.Trim(),
                CardNo = this.txtCardNo.Text.Trim(),
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
            };


            var isIdNoExisten = studentService.IsIdNoExisten(student.StudentIdNo, student.StudentId);

            if (isIdNoExisten)
            {
                MessageBox.Show("身份证号重复!", "提示信息");
                return;
            }
            var result = studentService.ModifyStudent(student);

            if (result == 1)
            {
                MessageBox.Show("学员信息修改成功!", "提示信息");
            }
            else
            {
                MessageBox.Show("学员信息修改失败!", "提示信息");

            }

        }
    }
}
