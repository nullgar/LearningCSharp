﻿using System;

namespace ImplicitExplicitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 13.37;
            int myInt;

            //Explicit Conversion
            //cast double to int
            myInt = (int)myDouble;
            //       This is what does the explicit conversion the ()
            Console.WriteLine(myInt);
            Console.Read();
            //You will notice that myInts value is not rounded but just cut to be a whole number

            //Implicit Conversion can convert smaller types to larger types
            int num = 1222;
            long newNum = num;

            float myFloat = 12.22f;
            double myDoubleExample = myFloat;


            //type conversion
            string myString = myDoubleExample.ToString();
            string secondString = myFloat.ToString();
            //you can also do this with booleans
        }
    }
}
