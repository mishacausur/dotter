using System;

namespace CSLight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            MultiCondition();
            Console.ReadKey(true);
           
        }

        static void Condition()
        {
            int age;
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Welcome to the club");
                Console.WriteLine("What you'd like to drink?");
            }
            else
            {
                Console.WriteLine("I'm sorry\nbut you're too young for this place");
                Console.WriteLine($"return here in {18 - age} years");
            }
            Console.ReadKey();
        }

        static void MultiCondition()
        {
            string weekDay;
            Console.Write("Enter week day: ");
            weekDay = Console.ReadLine();

            switch (weekDay)
            {
                case "monday":
                    Console.WriteLine("go to the cinema");
                    break;
                case "tuesday":
                    Console.WriteLine("learning");
                    break;
                case "wednesday":
                    Console.WriteLine("do homework");
                    break;
                case "thursday":
                    Console.WriteLine("do homework");
                    break;
                case "friday":
                    Console.WriteLine("cooking cookie");
                    break;
                case "saturday":
                    Console.WriteLine("resting");
                    break;
                case "sunday":
                    Console.WriteLine("walking");
                    break;
            }
        }
    }
}