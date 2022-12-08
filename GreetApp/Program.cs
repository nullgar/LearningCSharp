using System;

namespace GreetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
            //Console.Read();
        }
        public static string LowUpper(string word)
        {
           return $"{word.ToLower()}{word.ToUpper()}";
        }

        public static void Count(string count)
        {
             Console.WriteLine($"The amount of characthers is {count.Length}");
        }
        public static void Run()
        {
            // We encourage you to test your code with different strings,
            // but don't forget to put the default string back at the end of your testing.
            string s = "HeY ThErE !";

            /// Change nothing down here 
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);

        }
    }
}

