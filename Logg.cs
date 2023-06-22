using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_XUnit_Acceptans
{
    public class Logg
    {
        public string Num1 { get; set; }
        public string Num2 { get; set; }
        public string Output { get; set; }
        public string Operate { get; set; }

        public Logg(string num1, string num2, string output, string operate)
        {
            Num1 = num1;
            Num2 = num2;
            Output = output;
            Operate = operate;
        }
    }
}
