using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
    
            Console.WriteLine("We're making a groovy zoo!" + System.Environment.NewLine);


            Penguin penguin = new Penguin("Pogo");

            Herpetology.Herpetology habitatOne = new Herpetology.Herpetology();
            Komodo komodoMale = new Komodo("Buster");
            Komodo komodoFemale = new Komodo("Angie");
            Python pythonTwo = new Python("Killer");
            Python pythonOne = new Python("Slinky");

            
            habitatOne.inhabitants.Add(komodoFemale);
            habitatOne.inhabitants.Add(komodoMale);
            habitatOne.inhabitants.Add(pythonOne);
            habitatOne.inhabitants.Add(pythonTwo);

            Console.WriteLine ("Habitat: " + habitatOne.public_name);
            foreach (Animal item in habitatOne.inhabitants)
            {
                  Console.WriteLine("\t" + item.IndividualName + ", a " + item.CommonName );
            }
            Console.WriteLine("");

            PenguinHouse.PenguinHouse habitatTwo = new PenguinHouse.PenguinHouse();
            habitatTwo.inhabitants.Add(penguin);
            Console.WriteLine ("Habitat: " + habitatTwo.public_name);
            foreach (Animal item in habitatTwo.inhabitants)
            { 
                Console.WriteLine("\t" + item.IndividualName + ", an " + item.CommonName );
            }
            if (habitatTwo.inhabitants.Count == 1) {
                Console.WriteLine("\t" + habitatTwo.inhabitants[0].IndividualName + " is lonely.");
            }
            Console.WriteLine("");
            Savannah.Savannah habitatThree = new Savannah.Savannah();
            Lion lion = new Lion("Jo-Bob");
            Giraffe giraffe1 = new Giraffe("Raffi");
            Giraffe giraffe2 = new Giraffe("Barb", 3);
            Bonobo bonobo = new Bonobo("Dave");

            habitatThree.inhabitants.Add(lion);
            habitatThree.inhabitants.Add(giraffe1);
            habitatThree.inhabitants.Add(giraffe2);
            habitatThree.inhabitants.Add(bonobo);

            Console.WriteLine ("Habitat: " + habitatThree.public_name);
            foreach (Animal item in habitatThree.inhabitants)
            { 
                Console.WriteLine("\t" + item.IndividualName + ", a " + item.CommonName );
            }

            Console.WriteLine("It's possible that we didn't put enough thought into the design of habitat number three.");

        }
    }
}
