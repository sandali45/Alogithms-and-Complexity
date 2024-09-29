namespace Sorting_Algorithms
{
    class Pogram
    {
       public  static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            Console.WriteLine("Original Array:");
            SelectionSort.printArray(arr);

            SelectionSort.selectionSort(arr);
            Console.WriteLine("Sorted Array:");
            SelectionSort.printArray(arr);
        }
    }
}