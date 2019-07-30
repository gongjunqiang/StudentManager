using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    /// <summary>
    /// 学员信息访问类
    /// </summary>
    public class StudentService
    {
        #region 添加学员
        public int AddStudent(Students student)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into Students(StudentName,Gender,Birthday,Age,StudentIdNo,PhoneNumber,CardNo,ClassId)");
            sql.Append(" values (@StudentName,@Gender,@Birthday,@Age,@StudentIdNo,@PhoneNumber,@CardNo,@ClassId)");
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@StudentName",student.StudentName),
                new SqlParameter("@Gender",student.Gender),
                new SqlParameter("@Birthday",student.Birthday),
                new SqlParameter("@Age",student.Age),
                new SqlParameter("@StudentIdNo",student.StudentIdNo),
                new SqlParameter("@PhoneNumber",student.PhoneNumber),
                new SqlParameter("@CardNo",student.CardNo),
                new SqlParameter("@ClassId",student.ClassId),
            };
            try
            {
                int addCount = SQLHelper.Update(sql.ToString(), sqlParameters);
                return addCount;
            }
            catch (SqlException ex)
            {
                throw new Exception("数据库操作异常，详细信息："+ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// 判断身份证号码是否已经存在
        /// </summary>
        /// <param name="studentIdNo"></param>
        /// <returns></returns>
        public bool IsIdNoExisten(string studentIdNo)
        {
            string sql = "select count(1) from Students where StudentIdNo='{0}'";
            sql = string.Format(sql, studentIdNo);
            int count = Convert.ToInt32(SQLHelper.GetSingalResulrt(sql));
            //if (count == 1)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return count == 1 ? true:false;
        }
        #endregion

        #region 根基学员id查询学员信息

        /// <summary>
        /// 根基学员id查询学员信息
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public StudentExt QueryStudentByStudengtId(int studentId)
        {
            string sql = "select StudentId,StudentName,Gender,Birthday,StudentIdNo,Age,PhoneNumber,StudentAddress,CardNo,b.ClassId,ClassName from";
            sql += " Students a inner join StudentClass b on a.ClassId=b.ClassId where StudentId={0}";
            sql = string.Format(sql,studentId);
            StudentExt studentExt = null;
            SqlDataReader reader = SQLHelper.GetReader(sql);
            if (reader.Read())
            {
                studentExt= new StudentExt
                {
                    StudentId = Convert.ToInt32(reader["StudentId"]),
                    StudentName = reader["StudentName"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    StudentIdNo = reader["StudentIdNo"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    PhoneNumber = reader["PhoneNumber"].ToString(),
                    StudentAddress = reader["StudentAddress"].ToString(),
                    CardNo = reader["CardNo"].ToString(),
                    ClassId = Convert.ToInt32(reader["ClassId"]),
                    ClassName = reader["ClassName"].ToString(),
                };
            }
            return studentExt;
        }
        #endregion

        #region 修改学员信息
        public int ModifyStudent(Students student)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update Students set StudentName=@StudentName,Gender=@Gender,Birthday=@Birthday,Age=@Age,");
            sql.Append($"StudentIdNo=@StudentIdNo,PhoneNumber=@PhoneNumber,CardNo=@CardNo,ClassId=@ClassId where StudentId={student.StudentId}") ;
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@StudentName",student.StudentName),
                new SqlParameter("@Gender",student.Gender),
                new SqlParameter("@Birthday",student.Birthday),
                new SqlParameter("@Age",student.Age),
                new SqlParameter("@StudentIdNo",student.StudentIdNo),
                new SqlParameter("@PhoneNumber",student.PhoneNumber),
                new SqlParameter("@CardNo",student.CardNo),
                new SqlParameter("@ClassId",student.ClassId),
            };
            try
            {
                return SQLHelper.Update(sql.ToString(), sqlParameters);
    
            }
            catch (SqlException ex)
            {
                throw new Exception("数据库操作异常，详细信息：" + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 判断身份证号码是否已经存在
        /// </summary>
        /// <param name="studentIdNo"></param>
        /// <returns></returns>
        public bool IsIdNoExisten(string studentIdNo,int studentId)
        {
            string sql = "select count(1) from Students where StudentIdNo='{0}' and StudentId={1}";
            sql = string.Format(sql, studentIdNo, studentId);
            int count = Convert.ToInt32(SQLHelper.GetSingalResulrt(sql));
            //if (count == 1)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return count == 1 ? true : false;
        }

        #endregion
    }
}
