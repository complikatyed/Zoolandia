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

    }
}