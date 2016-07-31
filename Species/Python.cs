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
           this.Wings = false;
           this.Legs = 0;
           this.Sound = "hiss";
        }

        public override void Sleep()
        {
            Console.WriteLine("Pythons sleep with their eyes open.");
            Console.WriteLine("Pythons are diurnal");
        }

        public void wriggle()
        {
            Console.WriteLine("Pythons move by wriggling their bodies from side to side.");
        }

        public void writhe()
        {
            Console.WriteLine("Writhe is another word for wriggle.");
        }

    }
}