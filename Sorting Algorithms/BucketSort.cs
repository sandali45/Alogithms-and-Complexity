using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public  class BucketSort
    {
        public static void bucketSort(int[] arr, int n)
        {
            if (n <= 0)
                return;

            // Step 1: Find the maximum value in the array to determine the number of buckets
            int maxValue = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }

            // Step 2: Create empty buckets
            List<int>[] buckets = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<int>();
            }

            // Step 3: Add elements into the appropriate bucket
            for (int i = 0; i < n; i++)
            {
                int bucketIndex = (arr[i] * n) / (maxValue + 1); // Determine bucket index
                buckets[bucketIndex].Add(arr[i]);
            }

            // Step 4: Sort individual buckets using built-in sort
            for (int i = 0; i < n; i++)
            {
                buckets[i].Sort();
            }

            // Step 5: Concatenate all sorted buckets into the original array
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                foreach (int value in buckets[i])
                {
                    arr[index++] = value;
                }
            }
        }

        // Utility function to print array
        public static void printArray(int[] arr)
        {
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }


    }
}
