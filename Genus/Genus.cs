using System;

namespace Zoolandia.Genus
{
    public class Genus : Animal
    {
        public string SpeciesName { get; set;}
        public void Introduction()
        {
            Console.WriteLine("Meet our new " + this.CommonName + ", named " + this.IndividualName + ".");
            Console.WriteLine(UppercaseFirst(this.CommonName) + "s are members of the class " + this.GenusName + ".");
            Console.WriteLine("Their species name is " + this.SpeciesName + ".");
        }



    }
}