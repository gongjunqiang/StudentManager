using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 学员打卡实体类
    /// </summary>
    public class Attendance
    {
        public int Id { get; set; }
        public string CardNo { get; set; }
        public DateTime DTime { get; set; }
    }
}
