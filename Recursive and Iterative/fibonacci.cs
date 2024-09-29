using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_and_Iterative
{
    public class fibonacci
    {
        public long fibonacciRecursive(long number)
        {
            if (number <= 1)
            {
                return number;
            }
            return fibonacciRecursive(number - 1) + fibonacciRecursive(number - 2);
        }

        public long fibonacciIterative(long number)
        {
            if (number <= 1)
            {
                return number;
            }
            int currentFI = 1;
            int previousFI = 1;

            for (int i = 2; i < number; i++)
            {
                int temp = currentFI;
                currentFI = currentFI + previousFI;
                previousFI = temp;
            }
            return currentFI;
        }


    }
}
