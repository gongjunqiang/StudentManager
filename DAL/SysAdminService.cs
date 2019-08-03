using System;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 管理员数据访问类
    /// </summary>
    public class SysAdminService
    {
        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin admin)
        {
            var sql = "select LoginId,AdminName,LoginPwd from Admins where AdminName='{0}' and LoginPwd='{1}'";
            sql = string.Format(sql, admin.AdminName, admin.LoginPwd);
            SqlDataReader reader = SQLHelper.GetReader(sql);
            if (reader.Read())
            {
                admin.LoginId = Convert.ToInt32(reader["LoginId"]);
                admin.AdminName = reader["AdminName"].ToString();
                admin.LoginPwd = reader["LoginPwd"].ToString();
            }
            else
            {
                admin = null;
            }
            return admin;
        }

        public int ModifyPwd(SysAdmin admin)
        {
            var sql = "update Admins set LoginPwd={0} where LoginId={1}";
            sql = string.Format(sql, admin.LoginPwd, admin.LoginId);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("数据异常，异常信息："+ex.Message);
            }
        }
    }
}
