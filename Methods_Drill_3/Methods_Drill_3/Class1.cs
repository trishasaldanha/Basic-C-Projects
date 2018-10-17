using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Drill_3
{
    class Class1
    {
        public static int SomeMethod(int num1, int num2 =5)
        {
            int tempValue = num1 * num2;
            return tempValue;
        }
    }
}
