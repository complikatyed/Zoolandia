using System;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Bonobo : Mammalia
    {

        public Bonobo(string nickname, int optionalint = 4)
        {
           this.SpeciesName = "Pan paniscus";
           this.CommonName = "bonobo";
           this.IndividualName = nickname;
           this.Diet = "omnivorous";
           this.Wings = false;
           this.Legs = optionalint;
           this.Flying = false;
           this.Sound = "eek";
        }


        public override void Sleep()
        {
            Console.WriteLine("Bonobos typically sleep in trees and are diurnal.");
        }


    }
}