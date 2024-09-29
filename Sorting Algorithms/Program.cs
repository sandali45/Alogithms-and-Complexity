namespace Sorting_Algorithms
{
    class Pogram
    {
       public  static void Main(string[] args)
        {
            selectionsort();
            bubblesort();
            Mergesort();
        }

        public static void selectionsort()
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            Console.WriteLine("Original Array:");
            SelectionSort.printArray(arr);

            SelectionSort.selectionSort(arr);
            Console.WriteLine("Selection sorted - Sorted Array:");
            SelectionSort.printArray(arr);
            Console.WriteLine("...................................................................");
        }

        public static void bubblesort()
        {
            int[] arr = { 5,1,3,6 };
            int n = arr.Length;

            Console.WriteLine("Original Array:");
            BubbleSort.printArray(arr, n);

            BubbleSort.bubbleSort(arr, n);
            Console.WriteLine("Bubble sorted - Sorted Array:");
            BubbleSort.printArray(arr, n);
            Console.WriteLine("...................................................................");
        }

        public static void Mergesort()
        {

            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Given array is:");
            Merge.printArray(arr);

            Merge.mergeSort(arr, 0, arr.Length - 1);

            Console.WriteLine("\nMerge -Sorted array is:");
            Merge.printArray(arr);
        }
    }
}