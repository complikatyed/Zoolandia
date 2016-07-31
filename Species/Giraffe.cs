using System;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Giraffe : Mammalia
    {

        public Giraffe(string nickname, int optionalint = 4)
        {
           this.SpeciesName = "Giraffa camelopardalis";
           this.CommonName = "giraffe";
           this.IndividualName = nickname;
           this.Diet = "herbivorous";
           this.Wings = false;
           this.Legs = optionalint;
           this.Sound = "yawn";
        }

        public override void Sleep()
        {
            Console.WriteLine("Giraffes sleep standing up");
        }

    }
}