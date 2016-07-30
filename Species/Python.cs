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
           this.CommonName = "python";
           this.IndividualName = nickname;
        }

        public override void Sleep()
        {
            Console.WriteLine("Pythons sleep with their eyes open.");
            Console.WriteLine("Pythons are diurnal");
        }
        public override void Eat()
        {
            Console.WriteLine("Pythons are carnivorous.");
        }


    }
}