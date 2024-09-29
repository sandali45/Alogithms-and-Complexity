using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogithms_and_Complexity
{
    public  class BinaryRecursive
    {
        public static int binarySearch(int[] arr, int low, int high, int x)
        {
            if (high >= low)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == x)
                    return mid;

                if (arr[mid] > x)
                    return binarySearch(arr, low, mid - 1, x);

                return binarySearch(arr, mid + 1, high, x);
            }

            return -1;
        }

    }
}
