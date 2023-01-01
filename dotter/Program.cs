using System;

namespace CSLight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Currencies();
            Console.ReadKey(true);

        }

        static void Currencies()
        {
            string rub = "RUB";
            string usd = "USD";
            float rubles, dollars;
            int rubToUsd = 64;
            int usdToRub = 66;

            float exchangeCurrencyCount;
            string desiredOperation;

            Console.WriteLine("Welcome to the exchange store");
            Console.Write($"Write your amount {rub} balance ");
            rubles = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Write your amount {usd} balance ");
            dollars = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Choose the operation");
            Console.WriteLine($"1 - for {rub} to {usd}");
            Console.WriteLine($"2 - for {usd} to {rub}");
            Console.Write("Your choice: ");
            desiredOperation = Console.ReadLine();

            switch (desiredOperation)
            {
                case "1":
                    Console.WriteLine($"{rub} to {usd}");
                    Console.Write($"How much {rub} do you want to exchange? ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if(rubles >= exchangeCurrencyCount)
                    {
                        rubles -= exchangeCurrencyCount;
                        dollars += exchangeCurrencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect value has been entered");
                    }
                    break;
                case "2":
                    Console.WriteLine($"{usd} to {rub}");
                    Console.Write($"How much {usd} do you want to exchange? ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if(dollars >= exchangeCurrencyCount)
                    {
                        dollars -= exchangeCurrencyCount;
                        rubles += exchangeCurrencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect value has been entered");
                    }
                    break;
                default:
                    Console.WriteLine("Undefined operation has been choosen");
                    break;
            }
            Console.WriteLine($"Your amount is: {rubles} {rub} and {dollars} {usd}");
        }

        static void PasswordChecker()
        {
            string password = "password";

            Console.Write("Enter password: ");

            string userInput = Console.ReadLine();

            if (userInput == password)
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("Invalid password\nAccess denied");
            }


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
                default:
                    Console.WriteLine("undefined day");
                    break;
            }
        }
    }
}