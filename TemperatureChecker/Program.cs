using System;
using System.ComponentModel;

namespace TemperatureChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the current temperature?");
            string val = Console.ReadLine();
            //Console.WriteLine("What is the current temperature?");
            Console.WriteLine(CheckTemp(val));
            
        }


        static string CheckTemp(string val){
            string returnVal;


            int temp;

            _ = int.TryParse(val, out temp) ?
                temp <= 15 ? returnVal = "it is too cold here" : temp >= 16 && temp <= 28 ?
               returnVal = "it is okay"
            : returnVal = "it is hot here"
            : returnVal = "Not a valid Temperature";
            return returnVal;
        }
    }
}
