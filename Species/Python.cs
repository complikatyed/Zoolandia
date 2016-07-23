using System;
using Zoolandia;

namespace Zoolandia.Species
{
    public class Python : Animal
    {

        public Python(string nickname)
        {
           this.ClassName = "Reptilia";
           this.SpeciesName = "Python anchietae";
           this.IndividualName = nickname;
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Pythons sleep with their eyes open.");
            Console.WriteLine("Pythons are diurnal");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Pythons are carnivorous.");
        }
        public string Die()
        {
            return "This animal has died.";
        }

    }
}