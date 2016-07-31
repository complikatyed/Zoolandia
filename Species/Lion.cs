using System;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Lion : Mammalia
    {

        public Lion(string nickname, int optionalint = 4)
        {
           this.SpeciesName = "Panthera leo";
           this.CommonName = "lion";
           this.IndividualName = nickname;
           this.Diet = "carnivorous";
           this.Wings = false;
           this.Legs = optionalint;
        }


        public override void Sleep()
        {
            Console.WriteLine("Lions sleep lying down.");
        }


    }
}
       