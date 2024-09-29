namespace Recursive_and_Iterative
{
    class Program
    {
        public static void Main(string[] args)
        {
            Handle(args);
        }
        public static void Handle(string[] args)
        {
            Console.WriteLine("Enter which one Do You need to find out:");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Enter 1: Factorial of a Number");
            Console.WriteLine("Enter 2: Fibonacci of a number");
            Console.WriteLine("Enter 3:OR IF YOU WOULD LIKE TO FIND OUT BOTH");
            Console.WriteLine("Enter 4:OR would you like to find out GCDIterative/Greater common Divisor");
            Console.WriteLine("Enter 5:Traverse Directory using (Recursive)");
            Console.WriteLine("Enter 6:Traverse Directory using (Iterative and stack)");

            Console.WriteLine("------------------------------------------------------------------------");

            string inputnum = Console.ReadLine();

            switch (inputnum)
            {
                case "1":
                    Factorial();
                    break;

                case "2":
                    Fibonacci();
                    break;

                case "3":
                    AllMethod();
                    break;
                case "4":
                    GCDFinder();
                    break;


                case "5":
                    DirectoryR();
                    break;
                case "6":
                    DirectoryI();
                    break;

            }


        }
        public static void Factorial()
        {
            Console.WriteLine("Enter the number - (please enter a integer)");
            string inputfromUsers = Console.ReadLine();

            Factorial obj1 = new Factorial();
            long result1 = obj1.factorialRecursive(int.Parse(inputfromUsers));
            Console.WriteLine("factorial Recursive {0} is {1}", inputfromUsers, result1);


            Factorial obj2 = new Factorial();
            long result2 = obj2.factorialIterative(int.Parse(inputfromUsers));
            Console.WriteLine("factorial Iterative {0} is {1}", inputfromUsers, result2);

        }
        public static void Fibonacci()
        {
            Console.WriteLine("Enter a number- (please enter a integer)");
            string inputfromUsers1 = Console.ReadLine();

            fibonacci obj3 = new fibonacci();
            long result3 = obj3.fibonacciRecursive(int.Parse(inputfromUsers1));
            Console.WriteLine("fibonacci Recursive {0} is {1}", inputfromUsers1, result3);

            fibonacci obj4 = new fibonacci();
            long result4 = obj4.fibonacciIterative(int.Parse(inputfromUsers1));
            Console.WriteLine("fibonacci Iterative {0} is {1}", inputfromUsers1, result4);
        }
        public static void AllMethod()
        {

            Console.WriteLine("Enter a number- (please enter a integer)");
            string inputfromUsers = Console.ReadLine();


            Console.WriteLine("-------------------------------------------------------------");

            Factorial obj1 = new Factorial();
            long result1 = obj1.factorialRecursive(int.Parse(inputfromUsers));
            Console.WriteLine("factorial Recursive {0} is {1}", inputfromUsers, result1);


            Factorial obj2 = new Factorial();
            long result2 = obj2.factorialIterative(int.Parse(inputfromUsers));
            Console.WriteLine("factorial Iterative {0} is {1}", inputfromUsers, result2);


            Console.WriteLine("-------------------------------------------------------------");

            fibonacci obj3 = new fibonacci();
            long result3 = obj3.fibonacciRecursive(int.Parse(inputfromUsers));
            Console.WriteLine("fibonacci Recursive {0} is {1}", inputfromUsers, result3);

            fibonacci obj4 = new fibonacci();
            long result4 = obj4.fibonacciIterative(int.Parse(inputfromUsers));
            Console.WriteLine("fibonacci Iterative {0} is {1}", inputfromUsers, result4);


        }

        public static void GCDFinder()
        {

            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Enter the number 01- (please enter a integer:)");
            string inputfromUsers1 = Console.ReadLine();
            Console.WriteLine("Enter the number 02 - (please enter a integer:)");
            string inputfromUsers2 = Console.ReadLine();

            Console.WriteLine("------------------------------------------------------------------------");
            GCD obj5 = new GCD();
            long result5 = obj5.GCDRecursive(int.Parse(inputfromUsers1), int.Parse(inputfromUsers2));
            Console.WriteLine($"Greatest Common Divisor of GCDRecursive{inputfromUsers1} and {inputfromUsers2} is: {result5}");

            GCD obj6 = new GCD();
            long result6 = obj5.GCDIterative(int.Parse(inputfromUsers1), int.Parse(inputfromUsers2));
            Console.WriteLine($"Greatest Common Divisor of GCDIterative {inputfromUsers1} and {inputfromUsers2} is: {result6}");


        }
        public static void DirectoryR()
        {
            TraverseDirectory traverser = new TraverseDirectory();
            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\DELL\\source\\repos\\29165_ALGO1");
            traverser.TraverseDirectoryRecursive(dir);
        }
        public static void DirectoryI()
        {
            TraverseDirectory traverser = new TraverseDirectory();
            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\DELL\\source\\repos\\29165_ALGO1");
            traverser.TraverseDirectoryIterative(dir);
        }


    }
}