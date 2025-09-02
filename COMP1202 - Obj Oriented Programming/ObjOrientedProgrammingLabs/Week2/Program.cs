namespace ObjOrientedProgramming.Week1
{
    internal class Program()
    {
        /* Change this code that the program collects 3 integers and finds the average
         * Make sure the program is error free and does not crash */
        static void Main(string[] args)
        {

            int a = 45;
            double b = 3.4;
            char c = 'T';
            bool b2 = false;
            string lastName = "House";

            try
            {
                Console.WriteLine("Enter the first integer : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second integer : ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the third integer : ");
                int num3 = Convert.ToInt32(Console.ReadLine());

                float average = num1 / 3F + num2 / 3F + num3 / 3F;

                Console.WriteLine($"the result is {average}");
            }
            catch (FormatException f)
            {
                Console.WriteLine($"Input must be an integer: {f.Message}");
            }
            catch (OverflowException o)
            {
                Console.WriteLine($"The number is too big: {o.Message}");
            }
            catch (ArgumentException arg)
            {
                Console.WriteLine(arg.Message);
            }
            catch (ArithmeticException arth)
            {
                Console.WriteLine(arth.Message);
            }
        }
    }
}
