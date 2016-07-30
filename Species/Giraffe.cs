using System;
using Zoolandia;

namespace Zoolandia.Species
{
    public class Giraffe : Animal
    {

        public Giraffe(string nickname)
        {
           this.ClassName = "Mammalia";
           this.SpeciesName = "Giraffa camelopardalis";
           this.CommonName = "giraffe";
           this.IndividualName = nickname;
        }

        public override void Sleep()
        {
            Console.WriteLine("Giraffes sleep standing up");
        }
        public override void Eat()
        {
            Console.WriteLine("Giraffes are herbivorous");
        }


    }
}