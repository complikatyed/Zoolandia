using System;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Lion : Mammalia
    {

        public Lion(string nickname)
        {
           this.SpeciesName = "Panthera leo";
           this.CommonName = "lion";
           this.IndividualName = nickname;
           this.Diet = "carnivorous";
        }


        public override void Sleep()
        {
            Console.WriteLine("Lions sleep lying down.");
        }


    }
}
       