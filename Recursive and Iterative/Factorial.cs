using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_and_Iterative
{
    public class Factorial
    {

        public long factorialRecursive(int number)
        {


            if (number <= 1)
            {
                return 1L;
            }
            return number * factorialRecursive(number - 1);
        }
        public long factorialIterative(long number)
        {
            long result = 1;
            for (long i = number; i > 1; i--)
            {
                result = result * 1;
            }
            return result;
        }
        }
    }
