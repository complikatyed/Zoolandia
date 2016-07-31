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
            if (this.Legs > 0)
            {
                Console.WriteLine(this.IndividualName + " has " + this.Legs + " legs.");
            }
            else {
                Console.WriteLine(this.IndividualName + " has no legs.");
            }
        }
        public void Introduction(string version)
        {
            if (version == "long")
            {
                Console.WriteLine("Meet our new " + this.CommonName + ", named " + this.IndividualName + ".");
                Console.WriteLine(UppercaseFirst(this.CommonName) + "s are members of the class " + this.GenusName + ".");
                Console.WriteLine("Their species name is " + this.SpeciesName + ".");
                if (this.Legs > 0)
                {
                    Console.WriteLine(this.IndividualName + " has " + this.Legs + " legs.");
                }
                else {
                    Console.WriteLine(this.IndividualName + " has no legs.");
                }
            }
            else
            {
                Console.WriteLine("Meet our new " + this.CommonName + ", named " + this.IndividualName + ".");
            }
        }



    }
}