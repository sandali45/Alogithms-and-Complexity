﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public class SelectionSort
    {
        public static void selectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {

                // Assume the current position holds
                // the minimum element
                int min_idx = i;

                // Iterate through the unsorted portion
                // to find the actual minimum
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {

                        // Update min_idx if a smaller element
                        // is found
                        min_idx = j;
                    }
                }

                // If a new minimum is found,
                // swap it with the element at index i
                if (min_idx != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[min_idx];
                    arr[min_idx] = temp;
                }
            }
        }

        public static void printArray(int[] arr)
        {
            foreach (int val in arr)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}
