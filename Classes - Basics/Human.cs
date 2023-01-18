using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Basics
{
    internal class Human
    {
        //members - Part of this specifice class
        public string firstName; //This needs to be public if you are accessing this outside the class
        public string lastName;
        //member method
        public void introduceMyself()
        {
            Console.WriteLine($"Hello I'm {firstName} {lastName}");
        }
    }
}
