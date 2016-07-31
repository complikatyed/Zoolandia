using System;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Penguin : Aves
    {

        public Penguin(string nickname)
        {
           this.SpeciesName = "Aptenodytes forsteri";
           this.CommonName = "Emperor penguin";
           this.IndividualName = nickname;
           this.Diet = "omnivorous";
           this.Wings = true;
           this.Legs = 2;
           this.Flying = false;
           this.Sound = "gak";
        }


        public override void Sleep()
        {
            Console.WriteLine("Penguins sleep standing up.");
        }


    }
}