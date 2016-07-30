using System;
using Zoolandia;

namespace Zoolandia.Species
{
    public class Bonobo : Animal
    {

        public Bonobo(string nickname)
        {
           this.ClassName = "Mammalia";
           this.SpeciesName = "Pan paniscus";
           this.CommonName = "bonobo";
           this.IndividualName = nickname;
        }


        public override void Sleep()
        {
            Console.WriteLine("Bonobos typically sleep in trees and are diurnal.");
        }
        public override void Eat()
        {
            Console.WriteLine("Bonobos are omnivorous");
        }


    }
}