using System;

namespace CSLight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int money;
            int food;
            int foodUnitPrice = 10;
            bool isAbleToPay;

            Console.WriteLine($"Welcome to our bakery! Today all of the food cost only {foodUnitPrice} coins");
            Console.Write("How much money do you have? ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many food do you need? ");
            food = Convert.ToInt16(Console.ReadLine());
            isAbleToPay = money >= food * foodUnitPrice;
            food *= Convert.ToInt32(isAbleToPay);
            money -= food * foodUnitPrice;
            Console.WriteLine($"Now you have {food} food and still {money} coins");
            Console.ReadKey();
        }
    }
}