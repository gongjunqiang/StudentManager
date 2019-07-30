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

namespace StudentManager
{
    public partial class FrmStudentInfo : Form
    {
        public FrmStudentInfo()
        {
            InitializeComponent();
        }

        public FrmStudentInfo(StudentExt student)
            :this()
        {
            //显示学员信息
            this.lblStudentName.Text = student.StudentName;
            this.lblGender.Text = student.Gender;
            this.lblBirthday.Text = student.Birthday.ToShortDateString();
            this.lblClass.Text = student.ClassName;
            this.lblStudentIdNo.Text = student.StudentIdNo;
            this.lblCardNo.Text = student.CardNo;
            this.lblPhoneNumber.Text = student.PhoneNumber;
            this.lblAddress.Text = student.StudentAddress;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
