using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMethods
{
    public static class Greetings
    {
        public static void SayHi()
        {
            Console.WriteLine("Hello user, welcome to my application.");
        }

        public static string GetName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        public static void Greeting(string name)
        {
            Console.WriteLine($"Nice to meet you {name}. Hope you have a wonderful day");
        }
    }
}
