using System;

namespace Zoolandia
{
    public class Animal
    {
        public string species { get; set; }
        public static void sleep()
        {
            Console.WriteLine("Animal is now sleeping");
        }
        public static void eat()
        {
            Console.WriteLine("Animal is now eating");
        }
    }



}