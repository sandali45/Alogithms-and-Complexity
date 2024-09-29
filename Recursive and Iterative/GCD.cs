using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_and_Iterative
{
    public class GCD
    {
        public long GCDRecursive(int num1, int num2)
        {
            if (num2 == 0)
            {
                return num1;
            }
            return GCDRecursive(num2, num1 % num2);
        }
        public long GCDIterative(int num1, int num2)
        {
            if (num2 != 0)
            {
                int temp = num1 % num2;
                num1 = num2;
                num2 = temp;
            }
            return num1;
        }

    }
}
