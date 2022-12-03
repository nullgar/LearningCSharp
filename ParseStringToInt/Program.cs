using System;

namespace ParseStringToInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "12";
            string myStting2 = "10";
            string result = myString + myStting2;

            //Pasre will only work if the characthers of a variables value are numbers.
            int num = Int32.Parse(myString) + Int32.Parse(myStting2);
            

            //You can also user Int16, Int64, Double, and Decimal to convert numbered strings to whole numbers or decimals
            Console.WriteLine(num);

            string stringForFloat = "0.85"; // datatype should be float
            float myFloat = float.Parse(stringForFloat);

            Console.WriteLine(myFloat);

            string stringForInt = "12345"; // datatype should be int
            int myInt = Int32.Parse(stringForInt);
            Console.WriteLine(myInt);
        }
    }
}
