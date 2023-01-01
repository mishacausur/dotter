using System;

namespace CSLight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int health;
            int armor;
            int damage;
            int percentConverter = 100;

            Console.Write("Enter the value of health: ");
            health = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of armor: ");
            armor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of damage: ");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= damage * armor / percentConverter;

            Console.WriteLine($"You hittes by {damage}, now you have {health}");
            Console.ReadKey();
        }
    }
}