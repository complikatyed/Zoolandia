using System;

namespace Zoolandia
{
    public class Animal
    {
        public string UppercaseFirst(string s)
        {
            // Check for empty string.
	        if (string.IsNullOrEmpty(s))
	        {
	            return string.Empty;
	        }
	        // Return char and concat substring.
	        return char.ToUpper(s[0]) + s.Substring(1);
        }
        public virtual string GenusName { get; set; }
        public string CommonName { get; set; }
        public string IndividualName { get; set; }
        public virtual string Diet { get; set; }

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

        public virtual bool Swim( bool swim)
        {
            return swim;
        }
        public virtual bool Fly( bool fly)
        {
            return fly;
        }
        public virtual bool Sound( bool sound)
        {
            return sound;
        }
        public virtual string Die()
        {
            return "Oh no! " + this.IndividualName + " has died.";
        }
       
    }

}