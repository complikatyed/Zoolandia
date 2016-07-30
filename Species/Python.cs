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
           this.Diet = "carnivorous";
        }

        public override void Sleep()
        {
            Console.WriteLine("Pythons sleep with their eyes open.");
            Console.WriteLine("Pythons are diurnal");
        }


    }
}