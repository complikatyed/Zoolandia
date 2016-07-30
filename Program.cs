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
            
            Giraffe giraffe = new Giraffe("Raffi");
            giraffe.Introduction();
            giraffe.Sleep();
            giraffe.Eat();
            Console.WriteLine(" ");
            
            Python python = new Python("Slinky");
            python.Introduction();
            Console.WriteLine(python.GenusName);
            python.Sleep();
            python.Eat();
            Console.WriteLine(" ");
            
            Bonobo bonobo = new Bonobo("Dave");
            bonobo.Introduction();
            bonobo.Sleep();
            bonobo.Eat();
            Console.WriteLine(" ");
            
            Console.WriteLine(bonobo.Die());
            Console.WriteLine(giraffe.Die());




        }
    }
}
