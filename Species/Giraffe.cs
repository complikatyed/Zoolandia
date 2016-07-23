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
           this.IndividualName = nickname;
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Giraffes sleep standing up");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Giraffes are herbivorous");
        }
        public string Die()
        {
            return "This animal has died.";
        }
        // Die parameters:  are there any for this?

    }
}