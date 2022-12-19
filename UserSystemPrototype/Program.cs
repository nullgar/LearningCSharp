using System;

namespace UserSystemPrototype
{
    internal class Program
    {
        static string userName;
        static string password;
        //private static int pid;

        static void Main(string[] args)
        {
            Console.WriteLine("To login press 1 :");
            Console.WriteLine("To register press 2 :");
            string key = Console.ReadLine();

            if (key.Equals("2")) { 
                Register();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine();
                Login();
            } else if (key.Equals("1")) {
                Login();
            }
            

        }

        private static void Register()
        {
            //Process process = null;
            Console.WriteLine("Hello, please enter your username:");
            userName = Console.ReadLine();
            Console.WriteLine("Hello, please enter your password:");
            password = Console.ReadLine();
            Console.WriteLine("Succesfully Registered!");

        }

        private static void Login() {

            Console.WriteLine("Username");
            string checkName = Console.ReadLine();
            Console.WriteLine("Password");
            string checkPass = Console.ReadLine();

            if (userName == null && password == null)
            {
                if (checkName.ToLower().Equals("admin") && checkPass.Equals("SuperPassword")) {
                    Console.WriteLine("Hello admin!");
                } else
                {
                    Console.WriteLine("Password or username is incorrect.");
                    Console.Read();
                }
            }
            else if (userName != null && password != null && userName.ToLower().Equals(checkName.ToLower()) && password.Equals(checkPass))
            {
                Console.WriteLine($"Hello {userName}!");
            }
            else
            {
                Console.WriteLine("Password or username is incorrect.");
                Console.Read();
            }

            }
    }
}
