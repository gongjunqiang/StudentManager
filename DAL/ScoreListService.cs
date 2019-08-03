using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    /// <summary>
    /// 成绩表数据访问类
    /// </summary>
    public class ScoreListService
    {
        #region 查询成绩
        /// <summary>
        /// 查询学员成绩
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        public List<StudentExt> QueryStudentScore(int classId=-1)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select Students.StudentId, Students.StudentName, StudentClass.ClassName, StudentClass.ClassId,");
            sql.Append("ScoreList.CSharp,ScoreList.SQLServerDB from StudentClass inner join Students");
            sql.Append(" on StudentClass.ClassId=Students.ClassId inner join ScoreList on Students.StudentId=ScoreList.StudentId");
            if (classId != -1)
            {
                sql.Append($" where StudentClass.ClassId={classId}");
            }
            SqlDataReader reader = SQLHelper.GetReader(sql.ToString());
            List<StudentExt> scoreLists = new List<StudentExt>();
            while (reader.Read())
            {
                scoreLists.Add(new StudentExt
                {
                    StudentId = Convert.ToInt32(reader["StudentId"]),
                    StudentName = reader["StudentName"].ToString(),
                    ClassName = reader["ClassName"].ToString(),
                    ClassId = Convert.ToInt32(reader["ClassId"]),
                    CSharp = Convert.ToInt32(reader["CSharp"]),
                    SQLServerDB = Convert.ToInt32(reader["SQLServerDB"])
                }); 
            }
            return scoreLists;
        }

        /// <summary>
        /// 获取全部考试成绩信息
        /// </summary>
        /// <returns></returns>
        public Dictionary<string,string> GetScoureInfo()
        {
            string sql = "select stuCount=count(*),avgCsharp=avg(CSharp),avgDB=avg(SQLServerDB) from ScoreList;";
            sql += "select absentCount=count(*) from Students where StudentId not in (select StudentId from ScoreList)";
            Dictionary<string, string> scoreInfo = null;
            SqlDataReader reader = SQLHelper.GetReader(sql);

            if(reader.Read())
            {
                scoreInfo = new Dictionary<string, string>();
                scoreInfo.Add("stuCount",$"{reader["stuCount"].ToString()}");
                scoreInfo.Add("avgCsharp", $"{reader["avgCsharp"].ToString()}");
                scoreInfo.Add("avgDB", $"{reader["avgDB"].ToString()}");
            }

            if (reader.NextResult())
            {
                if (reader.Read())
                {
                    scoreInfo.Add("absentCount", $"{reader["absentCount"].ToString()}");
                }
            }
            reader.Close();
            return scoreInfo;
        }

        /// <summary>
        /// 获取缺考人员列表
        /// </summary>
        /// <returns></returns>
        public List<string> GetAbsentStudentName()
        {
            string sql = "select StudentId,StudentName from Students where StudentId not in (select StudentId from ScoreList)";
 
            SqlDataReader reader = SQLHelper.GetReader(sql);
            List<string> absentStudentNameList = new List<string>();
            while (reader.Read())
            {
                absentStudentNameList.Add(reader["StudentName"].ToString());
            }
            return absentStudentNameList;
        }
        #endregion

        #region 基于数据集查询成绩
        /// <summary>
        /// 获取所有的考试成绩（存储再DataSet中）
        /// </summary>
        /// <returns></returns>
        public DataSet GetScore()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select Students.StudentId, Students.StudentName, StudentClass.ClassName, StudentClass.ClassId,");
            sql.Append("ScoreList.CSharp,ScoreList.SQLServerDB from StudentClass inner join Students");
            sql.Append(" on StudentClass.ClassId=Students.ClassId inner join ScoreList on Students.StudentId=ScoreList.StudentId");
            return SQLHelper.GetDataSet(sql.ToString());

        }

        #endregion
    }
}
