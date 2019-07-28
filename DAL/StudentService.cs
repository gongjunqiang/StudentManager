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


    }
}
