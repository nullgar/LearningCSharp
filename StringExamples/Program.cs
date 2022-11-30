using System;

namespace StringExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            /// This explains functions explanation
            ///<summary>
            string mystring = "Hello, world!";
            Console.WriteLine("Famous phrase " + mystring);
            string capsMessage = mystring.ToUpper();
            Console.WriteLine(capsMessage);
            //This is a single line comment
            /*This is a 
            muliline */

        }
    }
}
