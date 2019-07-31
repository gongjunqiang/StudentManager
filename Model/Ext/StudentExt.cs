using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StudentExt:Students
    {
        //扩展属性
        public string ClassName { get; set; }
        public int CSharp { get; set; }
        public int SQLServerDB { get; set; }
    }
}
