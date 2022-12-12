using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let us divide. Please enter a number:");
            string num1 = Console.ReadLine();
            Console.WriteLine("Please enter a second number that is not Zero:");
            string num2 = Console.ReadLine();
            string res = "";
            try
            {
                res = $"{int.Parse(num1) / int.Parse(num2)}";
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero!");
                //throw;
            }
            catch (FormatException)
            {
                Console.WriteLine("You can only enter valid integers");
            }
            finally
            { 
                Console.WriteLine("This will always run! ----------------------------------");
            }

            if (res != "") {
                Console.WriteLine($"The resul is {res}."); 
            }
            else {
                Console.WriteLine("Please try again!");
                    }
            Console.Read();

        }
    }
}
