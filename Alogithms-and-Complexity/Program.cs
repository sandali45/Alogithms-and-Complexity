namespace Alogithms_and_Complexity
{
    class Program
    {
        public static void Main(string[] args)
        {
            linear();
            binary();
            binary2();


        }
        public static void linear()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int x = 10;

            // Function call
            int result = Linear.search(arr, arr.Length, x);
            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element in Linear search is present at index " + result);

            Console.WriteLine("......................................................................");
        }

        public static void binary()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int x = 10;

            // Call the BinarySearch method from the BinaryIterative class
            int result = BinaryIterative.BinarySearch(arr, x);

            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element in Binary Iterative search is present at index " + result);

            Console.WriteLine("......................................................................");
        }

        public static void binary2()
        {
            int[] arr = { 2, 3, 4, 10, 40 };

            int n = arr.Length;
            int x = 10;

            int result = BinaryRecursive.binarySearch(arr, 0, n - 1, x);

            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element in Binary Recursive present at index " + result);
            Console.WriteLine("......................................................................");

        }
    }
}