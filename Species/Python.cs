using System;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Python : Reptilia
    {
        public Python(string nickname)
        {
           this.SpeciesName = "Python anchietae";
           this.CommonName = "python";
           this.IndividualName = nickname;
        }

        public override void Sleep()
        {
            Console.WriteLine("Pythons sleep with their eyes open.");
            Console.WriteLine("Pythons are diurnal");
        }

    }
}