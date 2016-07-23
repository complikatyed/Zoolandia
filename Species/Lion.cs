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
           this.IndividualName = nickname;
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Lions sleep lying down");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Lions are carnivorous");
        }
        public string Die()
        {
            return "This animal has died.";
        }
        // Die parameters:  are there any for this?

    }
}
       