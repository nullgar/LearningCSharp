using System;

namespace Classes___Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an object of the Human Class
            //and instance of Human
            Human nullgar = new Human();
            //Access public variable from outside, and even change it
            nullgar.firstName = "Nullgar";
            nullgar.lastName = "Nully";
            //Call methods of the class
            nullgar.introduceMyself();


            Human frugalPhoenix = new Human();
            frugalPhoenix.firstName = "Frugal Phoenix";
            frugalPhoenix.lastName = "Nully";
            frugalPhoenix.introduceMyself();

            Console.ReadKey();
        }
    }
}
