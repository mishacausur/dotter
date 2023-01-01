using System;

namespace CSLight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Catcher();
            Console.ReadKey(true);

        }

        static void Catcher()
        {
            int number;
            int lower, higher;
            int triesCount = 5;
            int userInput;
            Random rand = new Random();

            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            higher = rand.Next(number + 1, number + 10);

            Console.WriteLine($"Guess the number! It's lower then {lower}, but higher then {higher}");
            Console.WriteLine($"You have {triesCount} tries ");

            while(triesCount-- > 0)
            {
                Console.WriteLine("Your answer: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                if(userInput == number)
                {
                    Console.WriteLine($"You right! It was {number}.");
                    break;
                }
                else
                {
                    Console.WriteLine($"No, try again!\nYou have {triesCount} tries left");
                }
            }

            if(triesCount < 0)
            {
                Console.WriteLine($"You lost!\nIt was {number}");
            }
        }

        static void Randomizer()
        {
            Random rand = new Random();
            int value;

            while(true)
            {
                value = rand.Next(0, 9);
                Console.WriteLine(value);
                Console.ReadKey();

            }
        }

        static void Fight()
        {
            Int16 playerHealth, playerDamage, enemyHealth, enemyDamage;

            Console.Write("Player health: ");
            playerHealth = Convert.ToInt16(Console.ReadLine());

            Console.Write("Player damage: ");
            playerDamage = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enemy health: ");
            enemyHealth = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enemy damage: ");
            enemyDamage = Convert.ToInt16(Console.ReadLine());

            while (playerHealth > 0 && enemyHealth > 0)
            {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine($"{playerHealth} - player");
                Console.WriteLine($"{enemyHealth} - enemy");
            }
            if (playerHealth <= 0 && enemyHealth <= 0)
            {
                Console.WriteLine("No one wins");
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("Player wins");
            }
            else if (playerHealth <= 0)
            {
                Console.WriteLine("Enemy wins");
            }
        }

        static void Deposit()
        {
            float money;
            Int16 years, percent;

            Console.Write("Money on deposit: ");
            money = Convert.ToSingle(Console.ReadLine());
            Console.Write("How many years: ");
            years = Convert.ToInt16(Console.ReadLine());
            Console.Write("Which percent: ");
            percent = Convert.ToInt16(Console.ReadLine());

            for(int i = 0; i < years; i++)
            {
                money += money / 100 * percent;
                Console.WriteLine($"This year you earn {money}");
                Console.ReadKey(true);
            }
        }

        static void Counter()
        {
            int triesCount = 5;
            string password = "password";
            string userInput;

            for (int i = 0; i < triesCount; i++)
            {
                Console.Write("Enter password: ");
                userInput = Console.ReadLine();
                if (userInput == password)
                {
                    Console.WriteLine("Access granted");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password entered");
                    Console.WriteLine($"You have {triesCount - i - 1} tries left");
                }
            }
        }

        static void Looper()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void LooperWhile()
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            while (age-- > 0)
            {
                if (age == 8)
                {
                    continue;
                }
                Console.WriteLine($"you were {age}");

                if(age == 5)
                {
                    break;
                }
            }
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