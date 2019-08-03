using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 通用数据访问类
    /// </summary>
    public class SQLHelper
    {
        public static readonly string connString = StringSecurity.DESDecrypt(ConfigurationManager.ConnectionStrings["connString"].ToString());
        //public static readonly string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        /// <summary>
        /// 执行update、insert、delete等操作
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParameter"></param>
        /// <returns></returns>
        public static int Update(string sql, SqlParameter[] sqlParameter=null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);

            if (sqlParameter != null)
            {
                cmd.Parameters.AddRange(sqlParameter);
            }
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("方法public static int Update执行异常,异常信息："+ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行单一结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingalResulrt (string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("方法public static object GetSingalResulrt执行异常,异常信息：" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行结果集查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                conn.Close();
                throw new Exception("方法public static SqlDataReader GetReader：" + ex.Message);
            }
        }

        /// <summary>
        /// 执行查询，返回一个数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);//创建数据适配器
            DataSet ds = new DataSet();//创建一个内存数据集
            try
            {
                conn.Open();
                da.Fill(ds,"classInfo");//填充数据集
                return ds;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
