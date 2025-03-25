/* Week 4 Lab, COMP1202
 * Elizabeth House
 * 2025/01/28
 */

namespace WeekFour
{
    class Math
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static double? Divide(int x, int y)
        {
            try
            {
                return (double)x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by 0!");
                return null;
            }
        }
    }

    internal class Program
    {
        // Global Scope
        static int x, y;

        public static void Collect2Int()
        {
            Console.WriteLine("\nEnter integer x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer y: ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Average(int x, int y)
        {
            return (x + y) / 2.0;
        }

        public static void PrintResult(int sum, double avg)
        {
            Console.WriteLine($"The sum of {x} and {y} is {sum}, and avg is {avg:F2}");
        }

        public static string? Menu()
        {
            Console.WriteLine("--------- Calculation -------------");
            Console.WriteLine(" 1 - Add two numbers :");
            Console.WriteLine(" 2 - Subtract two numbers: ");
            Console.WriteLine(" 3 - Multiply two numbers: ");
            Console.WriteLine(" 4 - Divide two numbers: ");
            Console.WriteLine(" 5 - Exit the program");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter 1, 2, 3, 4, or 5: ");

            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            /* Decomposition : breaking down the task into smaller more manageable subprocesses (module) 
             collect 2 integers and find the sum and avg of it! (modularization methods)
            1) Collect two integers
            2) Add two integers
            3) Find the average of two integers 
            4) Show the result 
            */

            /*int x, y;

            Console.WriteLine("Enter an integer x");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an integer y");
            y = Convert.ToInt32(Console.ReadLine());*/

            /*Collect2Int();
            var sum = Add(x, y);
            var avg = Average(x, y);
            PrintResult(sum, avg);*/

            while (true) // Infinite loop to keep running until user exits
            {
                var choice = Menu();

                switch (choice)
                {
                    case "1":
                        Collect2Int();
                        Console.WriteLine($"The sum of {x} and {y} is {Math.Add(x, y)}\n");
                        break;
                    case "2":
                        Collect2Int();
                        Console.WriteLine($"The difference of {x} and {y} is {Math.Subtract(x, y)}\n");
                        break;
                    case "3":
                        Collect2Int();
                        Console.WriteLine($"The product of {x} and {y} is {Math.Multiply(x, y)}\n");
                        break;
                    case "4":
                        Collect2Int();
                        Console.WriteLine($"The quotient of {x} and {y} is {Math.Divide(x, y)}\n");
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid input.\n");
                        break;
                }
            }
        }
    }
}
