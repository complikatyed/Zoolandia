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

        public virtual void Introduction()
        {
            Console.WriteLine("Meet our new " + this.CommonName + ", named " + this.IndividualName + ".");
            Console.WriteLine(this.CommonName + "s are members of the class " + this.GenusName + ".");
            Console.WriteLine("Their species name is " + this.SpeciesName + ".");
        }



    }
}