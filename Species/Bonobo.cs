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
           this.IndividualName = nickname;
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Bonobos typically sleep in trees and are diurnal.");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Bonobos are omnivorous");
        }
        public string Die()
        {
            return "This animal has died.";
        }
        // Die parameters:  are there any for this?

    }
}