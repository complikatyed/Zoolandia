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
            Giraffe giraffe1 = new Giraffe("Raffi");
            Giraffe giraffe2 = new Giraffe("Barb", 3);
            Python python = new Python("Slinky");            
            Bonobo bonobo = new Bonobo("Dave");
            Penguin penguin = new Penguin("Pogo");
            


        }
    }
}
