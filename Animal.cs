using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Animal
    {
        static string UppercaseFirst(string s)
        {
	        // Check for empty string.
	        if (string.IsNullOrEmpty(s))
	        {
	            return string.Empty;
	        }
	        // Return char and concat substring.
	        return char.ToUpper(s[0]) + s.Substring(1);
        }
        public Animal() {}

        public string ClassName { get; set; }
        public string SpeciesName { get; set; }
        public string CommonName { get; set; }
        public string IndividualName { get; set; }
        public string Diet { get; set; }

        public virtual void Introduction()
        {
            Console.WriteLine("Meet our new " + this.CommonName + ", named " + this.IndividualName + ".");
            Console.WriteLine(UppercaseFirst(this.CommonName) + "s are members of the class " + this.ClassName + ".");
            Console.WriteLine("Their species name is " + this.SpeciesName + ".");
        }
        public virtual void Sleep(){}
        // Sleep parameters might include:  nocturnal/diurnal, standing/hanging/lying, true/false
        
        public virtual void Eat()
        {
            Console.WriteLine(UppercaseFirst(this.CommonName) + "s are " + this.Diet + ".");
        }

        // Eat parameters might include:  type of food, amount of food, frequency of eating
        public virtual void Breathe(){}
        
        // Breathe parameters might include:  lungs/gills/skin, quickly or slowly
        public virtual void Reproduce(){}
        // Reproduce parameters:  egg/live young/marsupial type, many offspring/single (or few)
        public virtual void Grow(){}
        // Grow parameters:  fast/slowly
        public virtual string Die()
        {
            return "Oh no! " + this.IndividualName + " has died.";
        }
        // Die parameters:  are there any for this?

       
    }

    // Properties --> add Mammal, Reptile, etc (family?)
    // Can there be conditionals in methods, like 'if family is reptile, then reproduction is egg' ?
    // Methods:  eating, sleeping, 

}