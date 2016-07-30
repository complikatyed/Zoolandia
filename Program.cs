using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("We're making a groovy zoo!");

            Lion lion = new Lion("Jo-Bob");
            Console.WriteLine("Meet our new lion, named " + lion.IndividualName);
            Console.WriteLine("Lions are members of the class " + lion.ClassName);
            Console.WriteLine("Their species name is " + lion.SpeciesName);
            lion.Sleep();
            lion.Eat();
            Console.WriteLine(" ");
            Giraffe giraffe = new Giraffe("Raffi");
            Console.WriteLine("Meet our new giraffe, named " + giraffe.IndividualName);
            Console.WriteLine("Giraffes are members of the class " + giraffe.ClassName);
            Console.WriteLine("Their species name is " + giraffe.SpeciesName);
            giraffe.Sleep();
            giraffe.Eat();
            Console.WriteLine(" ");
            Python python = new Python("Slinky");
            Console.WriteLine("Our new python is named " + python.IndividualName);
            Console.WriteLine("Pythons are members of the class " + python.ClassName);
            Console.WriteLine("Their species name is " + python.SpeciesName);
            python.Sleep();
            python.Eat();
            Console.WriteLine(" ");
            Bonobo bonobo = new Bonobo("Dave");
            Console.WriteLine("Our new bonobo is named " + bonobo.IndividualName);
            Console.WriteLine("Bonobos are members of the class " + bonobo.ClassName);
            Console.WriteLine("Their species name is " + bonobo.SpeciesName);
            bonobo.Sleep();
            bonobo.Eat();
            Console.WriteLine(" ");
            Console.WriteLine(bonobo.Die());
            Console.WriteLine(giraffe.Die());




        }
    }
}
