using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogithms_and_Complexity
{
    public class Linear
    {
        public static int search(int[] arr, int N, int x)
        {
            for (int i = 0; i < N; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

    }
}
