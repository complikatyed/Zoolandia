using System;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Bonobo : Mammalia
    {

        public Bonobo(string nickname) : base()
        {
           this.SpeciesName = "Pan paniscus";
           this.CommonName = "bonobo";
           this.IndividualName = nickname;
           this.Diet = "omnivorous";
        }


        public override void Sleep()
        {
            Console.WriteLine("Bonobos typically sleep in trees and are diurnal.");
        }


    }
}