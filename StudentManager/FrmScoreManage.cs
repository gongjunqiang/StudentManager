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
    public partial class FrmScoreManage : Form
    {
        private StudentClassService studentClassService = new StudentClassService();
        private ScoreListService scoreListService = new ScoreListService();
        public FrmScoreManage()
        {
            InitializeComponent();
            this.cbbClass.DataSource = studentClassService.GetStudentClass();
            this.cbbClass.DisplayMember = "ClassName";
            this.cbbClass.ValueMember = "ClassId";
            this.cbbClass.SelectedIndex = -1;

            this.dgvScoreList.AutoGenerateColumns = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmScoreManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.frmScoreManage = null;
        }


        /// <summary>
        /// 统计全校学员考试信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.gbInfo.Text = "全校考试成绩统计";
            var scoreList = scoreListService.QueryStudentScore();
            if (scoreList.Count == 0)
            {
                MessageBox.Show("成绩查询结果为空！","提示信息");
                return;
            }
            this.dgvScoreList.DataSource = null;
            this.dgvScoreList.DataSource = scoreList;

            //总信息展示
            var scoureInfo = scoreListService.GetScoureInfo();
            this.lblCount.Text = scoureInfo["absentCount"];
            this.LblCSharpAvg.Text = scoureInfo["avgCsharp"];
            this.LblDBAvg.Text = scoureInfo["avgDB"];           
            this.lblAttendCount.Text = scoureInfo["stuCount"];

            //缺考人员展示
            var absentStudeltList = scoreListService.GetAbsentStudentName();
            this.lblList.Items.Clear();
            this.lblList.Items.AddRange(absentStudeltList.ToArray());


        }
    }
}
