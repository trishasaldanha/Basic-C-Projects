using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Drill_2
{
    class Class1
    {
        static public int MultiplyMe(int num1)
        {
            int tempValue = num1 * 72;
            return tempValue;
        }

        static public decimal MultiplyMe(decimal num1)
        {
            int tempValue = Convert.ToInt32(num1 * 1000);
            return tempValue;
        } 

        static public string MultiplyMe(string num1)
        {
            int tempValue = Convert.ToInt32(num1) * 17;
            return Convert.ToString(tempValue);
        }
    }
}
