using System;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Nullgar";
            string lastName = "Developer";
            string fullName = string.Concat(" ", firstName," ", lastName, " ");
            Console.WriteLine(fullName);
            Console.WriteLine(firstName.Substring(2));
            Console.WriteLine(lastName.ToLower());
            Console.WriteLine(fullName.Trim());
            string name = "Nullgar";
            string sentence = String.Format("My name is {0}", name);
            Console.WriteLine(sentence);
            
        }
    }
}
