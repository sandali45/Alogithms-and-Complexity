using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogithms_and_Complexity
{
    public  class BinaryIterative
    {
        public static int BinarySearch(int[] arr, int x)
        {
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;


                if (arr[mid] == x)
                    return mid;


                if (arr[mid] < x)
                    low = mid + 1;


                else
                    high = mid - 1;
            }

            return -1;
        }

    }
}
