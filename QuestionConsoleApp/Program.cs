using System;

namespace QuestionConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ans;
            Console.WriteLine("What is your name?");
            ans = Console.ReadLine();
            Console.WriteLine(String.Format("Hello {0}!",ans));
            //Console.WriteLine(ans.ToLower());
            //Console.WriteLine(ans.ToUpper());
            //Console.WriteLine(ans.Trim());
            //Console.WriteLine(ans.Substring(1));
            Console.WriteLine("Let try something cool. I can let you know where the first occurence of a character in a word is.");
            Console.WriteLine("Enter the word, and press enter!");
            string word = Console.ReadLine();
            Console.WriteLine("What character do you want me to search for? Press enter after you choose!");
            string look = Console.ReadLine();

            Console.WriteLine($"{look} is at the index of {word.IndexOf(look)}");
        }
    }
}
