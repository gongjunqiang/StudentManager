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
    public partial class FrmAttendance : Form
    {
        private StudentService studentService = new StudentService();
        private AttendanceService attendanceService = new AttendanceService();
        public FrmAttendance()
        {
            InitializeComponent();
            Timer_Click_Tick(null, null);
        }

        private void FrmAttendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.frmAttendance = null;
        }

        private string GetWeekName()
        {
            string weekName = "";
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    weekName = "一";
                    break;
                case DayOfWeek.Tuesday:
                    weekName = "二";
                    break;
                case DayOfWeek.Wednesday:
                    weekName = "三";
                    break;
                case DayOfWeek.Thursday:
                    weekName = "四";
                    break;
                case DayOfWeek.Friday:
                    weekName = "五";
                    break;
                case DayOfWeek.Saturday:
                    weekName = "六";
                    break;
                case DayOfWeek.Sunday:
                    weekName = "日";
                    break;
            }
            return weekName;
        }

        private void SkinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_Click_Tick(object sender, EventArgs e)
        {
            this.lblYear.Text = DateTime.Now.Year.ToString();
            this.lblMonth.Text = Convert.ToInt32(DateTime.Now.Month.ToString()) < 10 ? 0 + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString();
            this.lblDay.Text = Convert.ToInt32(DateTime.Now.Day.ToString()) < 10 ? 0 + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();
            this.lblTime.Text = DateTime.Now.ToLongTimeString();
            this.lblWeek.Text = GetWeekName();
        }

        /// <summary>
        /// Enter键打卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtCarNm.Text.Trim().Length == 0 && e.KeyValue == 13)
            {
                MessageBox.Show("卡号不能为空!","提示信息");
                this.txtCarNm.Focus();
                return;
            }
            //执行显示学员信息与打开操作
            try
            {
                if (e.KeyValue == 13)
                {
                    var studentInfo = studentService.GetStudentInfoByCardNo(this.txtCarNm.Text.Trim());
                    if (studentInfo == null)
                    {
                        MessageBox.Show("卡号不正确！", "信息提示");
                        this.txtCarNm.SelectAll();
                        return;
                    }
                    //显示学员信息
                    this.lblName.Text = studentInfo.StudentName;
                    this.lblStudentId.Text = studentInfo.StudentId.ToString();
                    this.lblClassName.Text = studentInfo.ClassName;
                    Attendance attendance = new Attendance { CardNo = this.txtCarNm.Text.Trim(), DTime = DateTime.Now };
                    var result = attendanceService.CardRecode(attendance);
                    if (result != "success")
                    {
                        this.lblResult.Text = "打卡失败！";
                        this.lblResult.ForeColor = Color.Red;
                        MessageBox.Show(result, "错误提示");
                    }
                    else
                    {
                        this.lblResult.Text = "打卡成功!";
                        this.lblResult.ForeColor = Color.Lime;
                    }
                    this.txtCarNm.Text = ""; //等待下一个打卡
                    this.txtCarNm.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
