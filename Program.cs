using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
    
            Console.WriteLine("We're making a groovy zoo!" + System.Environment.NewLine);

            Lion lion = new Lion("Jo-Bob");
            lion.Introduction();
            lion.Sleep();
            lion.Eat();
            Console.WriteLine(" ");
            
            Giraffe giraffe1 = new Giraffe("Raffi");
            Giraffe giraffe2 = new Giraffe("Barb", 3);
            giraffe1.Introduction();
            giraffe2.Introduction();
            giraffe1.Sleep();
            giraffe2.Sleep();
            giraffe1.Eat();
            giraffe2.Eat();
            Console.WriteLine(" ");
            
            Python python = new Python("Slinky");
            python.Introduction();
            python.Sleep();
            python.Eat();
            Console.WriteLine(" ");
            
            Bonobo bonobo = new Bonobo("Dave");
            bonobo.Introduction();
            bonobo.Sleep();
            bonobo.Eat();
            Console.WriteLine(" ");
            
            Console.WriteLine(bonobo.Die());
            Console.WriteLine(giraffe1.Die());

        }
    }
}
