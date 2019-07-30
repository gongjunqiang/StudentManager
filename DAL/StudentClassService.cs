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
    /// 班级数据访问类
    /// </summary>
    public class StudentClassService
    {
        /// <summary>
        /// 获取学生班级列表
        /// </summary>
        /// <returns></returns>
        public List<StudentClass> GetStudentClass()
        {
            string sql = "select ClassId,ClassName from StudentClass";
            List<StudentClass> studentClassList = new List<StudentClass>();
            SqlDataReader reader = SQLHelper.GetReader(sql);
            try
            {
                while (reader.Read())
                {
                    studentClassList.Add(new StudentClass
                    {
                        ClassId = Convert.ToInt32(reader["ClassId"]),
                        ClassName = reader["ClassName"].ToString()
                    });
                }
                reader.Close();
                return studentClassList;

            }
            catch (SqlException ex)
            {
                throw new Exception("数据库访问错误，详细信息："+ex.Message);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Students> QueryStudentsByClassId(StudentClass studentClass)
        {
            string sql = "select StudentId,StudentName,Gender,Birthday,b.ClassId,ClassName from";
            sql+= " Students a inner join StudentClass b on a.ClassId=b.ClassId where b.ClassId={0}";
            sql = string.Format(sql, studentClass.ClassId);
            List<Students> studentList = new List<Students>();
            SqlDataReader reader = SQLHelper.GetReader(sql);
            while (reader.Read())
            {
                studentList.Add( new Students
                {
                    StudentId=Convert.ToInt32(reader["StudentId"]),
                    StudentName = reader["StudentName"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    ClassId = Convert.ToInt32(reader["StudentId"]),
                    ClassName = reader["ClassName"].ToString(),
                });
            }
            reader.Close();
            return studentList;
        }

    }
}
