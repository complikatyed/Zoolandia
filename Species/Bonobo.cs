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

        public virtual void Introduction()
        {
            Console.WriteLine("Meet our new " + this.CommonName + ", named " + this.IndividualName + ".");
            Console.WriteLine(this.CommonName + "s are members of the class " + this.GenusName + ".");
            Console.WriteLine("Their species name is " + this.SpeciesName + ".");
        }


    }
}