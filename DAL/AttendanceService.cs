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
    /// 学员打卡数据类
    /// </summary>
    public class AttendanceService
    {
        public string CardRecode(Attendance attendance)
        {
            string sql = "insert into Attendance (CardNo,DTime) values(@CardNo,@DTime)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@CardNo",attendance.CardNo),
                new SqlParameter("@DTime",attendance.DTime)
            };
            try
            {
                SQLHelper.Update(sql, sqlParameters);
                return "success";
            }
            catch (Exception ex)
            {
                throw new Exception("打卡失败！系统出现问题，请联系管理员！" + ex.Message);
            }
        }

    }
}
