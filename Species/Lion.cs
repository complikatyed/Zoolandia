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
            Console.WriteLine("Lions sleep lying down");
        }

        public virtual void Introduction()
        {
            Console.WriteLine("Meet our new " + this.CommonName + ", named " + this.IndividualName + ".");
            Console.WriteLine(this.CommonName + "s are members of the class " + this.GenusName + ".");
            Console.WriteLine("Their species name is " + this.SpeciesName + ".");
        }



    }
}
       