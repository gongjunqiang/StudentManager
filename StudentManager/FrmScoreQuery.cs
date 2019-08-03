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
    public partial class FrmScoreQuery : Form
    {
        private StudentClassService studentClassService = new StudentClassService();
        private ScoreListService scoreListService = new ScoreListService();

        private DataTable dtScore = null;

        public FrmScoreQuery()
        {
            InitializeComponent();

            //初始化:显示班级下拉框
            //DataTable dt = studentClassService.GetAllClass().Tables["classInfo"];
            DataTable dt = studentClassService.GetAllClass().Tables[0];
            this.cbbClass.DataSource = dt;
            this.cbbClass.DisplayMember = "ClassName";
            this.cbbClass.ValueMember = "ClassId";

            dtScore = scoreListService.GetScore().Tables[0];
            this.dgvScoreList.AutoGenerateColumns = false;
            this.dgvScoreList.DataSource = null;
            this.dgvScoreList.DataSource = dtScore;

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmScoreQuery_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.frmScoreQuery = null;
        }

        /// <summary>
        /// 根据班级名称动态筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.dtScore == null)
            {
                return;
            }

            this.dtScore.DefaultView.RowFilter = string.Format("ClassName='{0}'", this.cbbClass.Text.Trim());
        }

        /// <summary>
        /// 根据成绩动态筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtScore_TextChanged(object sender, EventArgs e)
        {
            if (this.dtScore == null)
            {
                return;
            }
            if (this.txtScore.Text.Trim().Length == 0) return;

            if (!Common.DataValidate.IsInteger(this.txtScore.Text.Trim()))
            {
                this.txtScore.Text = "";
                return;
            }

            this.dtScore.DefaultView.RowFilter = string.Format("CSharp>{0}", this.txtScore.Text.Trim()) ;

        }

        //显示全部成绩
        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            if (this.dtScore == null)
            {
                return;
            }
            this.dtScore.DefaultView.RowFilter = "ClassName like '%%'";
        }
    }
}
