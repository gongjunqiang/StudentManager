using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 成绩扩展实体
    /// </summary>
    public class ScoreListExt:ScoreList
    {
        public string StudentName { get; set; }
        public string ClassName { get; set; }

        public int ClassId { get; set; }
    }
}
