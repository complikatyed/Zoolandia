using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Animal
    {
        public Animal() {}

        public string ClassName { get; set; }
        public string SpeciesName { get; set; }
        public string IndividualName { get; set; }
        public string Diet { get; set; }

        public virtual void Sleep(){}
        // Sleep parameters might include:  nocturnal/diurnal, standing/hanging/lying, true/false
        public virtual void Eat(){}
        // Eat parameters might include:  type of food, amount of food, frequency of eating
        public virtual void Breathe(){}
        // Breathe parameters might include:  lungs/gills/skin, quickly or slowly
        public virtual void Reproduce(){}
        // Reproduce parameters:  egg/live young/marsupial type, many offspring/single (or few)
        public virtual void Grow(){}
        // Grow parameters:  fast/slowly
        public string Die()
        {
            return "This animal has died.";
        }
        // Die parameters:  are there any for this?

       
    }

    // Properties --> add Mammal, Reptile, etc (family?)
    // Can there be conditionals in methods, like 'if family is reptile, then reproduction is egg' ?
    // Methods:  eating, sleeping, 

}