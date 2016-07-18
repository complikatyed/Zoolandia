using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("We're making a groovy zoo!");

            Alligator alligator = new Alligator("Jo-Bob");
            Console.WriteLine("Meet our new alligator, named " + alligator.Name);
            Console.WriteLine("The alligator weighs " + alligator.Weight + " pounds.");








        }
    }
}
