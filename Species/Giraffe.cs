using System;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Giraffe : Mammalia
    {

        public Giraffe(string nickname)
        {
           this.SpeciesName = "Giraffa camelopardalis";
           this.CommonName = "giraffe";
           this.IndividualName = nickname;
           this.Diet = "herbivorous";
        }

        public override void Sleep()
        {
            Console.WriteLine("Giraffes sleep standing up");
        }

        public virtual void Introduction()
        {
            Console.WriteLine("Meet our new " + this.CommonName + ", named " + this.IndividualName + ".");
            Console.WriteLine(this.CommonName + "s are members of the class " + this.GenusName + ".");
            Console.WriteLine("Their species name is " + this.SpeciesName + ".");
        }

    }
}