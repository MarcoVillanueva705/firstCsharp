using System;
using System.Collections.Generic;
using System.Linq;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Hello CodeWorks Student");
            System.Console.WriteLine("What day of the week is it?");
            string choice =  Console.ReadLine().ToLower();
            switch(choice)
            {
                case "monday":
                System.Console.WriteLine("5 days until the weekend");
                break;
                case "tuesday":
                System.Console.WriteLine("4 days until the weekend");
                break;
                case "wednesday":
                System.Console.WriteLine("3 days until the weekend");
                break;
                case "thursday":
                System.Console.WriteLine("2 days until the weekend");
                break;
                case "friday":
                System.Console.WriteLine("1 days until the weekend");
                break;
                case "saturday":
                case "sunday":
                System.Console.WriteLine("It's the weekend");
                break;
                default:
                System.Console.WriteLine("Sorry I don't understand");
                break;
            }
            System.Console.WriteLine("Good Bye");
        }
    }
}
   


