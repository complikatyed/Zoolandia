using System;
using Zoolandia;

namespace Zoolandia.Species
{
    public class Lion : Animal
    {

        public Lion(string nickname)
        {
           this.ClassName = "Mammalia";
           this.SpeciesName = "Panthera leo";
           this.CommonName = "lion";
           this.IndividualName = nickname;
        }

        public override void Sleep()
        {
            Console.WriteLine("Lions sleep lying down");
        }
        public override void Eat()
        {
            Console.WriteLine("Lions are carnivorous");
        }

    }
}
       