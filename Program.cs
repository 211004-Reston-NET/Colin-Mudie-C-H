using System;
using HouseFunction;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            House house = new House();
            house.MiceName = "Jerry";
            Console.WriteLine(house.MiceName);

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Your name is " + userName + "!");
        }
    }
}
