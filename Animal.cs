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
        public virtual bool Wings { get; set; }
        public virtual int Legs { get; set; }

        public virtual bool Flying { get; set; }

        public virtual string Sound { get; set; }

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
        public virtual string Fly()
        {
            if (this.Flying) {
                return "Look, I'm flying!";
            }
            else
            {
                return "Uh-oh!  I am not flying!  I am crashing!";
            }
        }
        public void DoSound()
        {
            Console.WriteLine(this.Sound);
        }
        public void DoSound(string specialsound)
        {
            Console.WriteLine(specialsound);
        }
        public void DoSound(int soundnumber)
        {
            for(int i = soundnumber; i > 1; i--) 
            {
            Console.Write(this.Sound + "-");
            }
            Console.Write(this.Sound);
            Console.Write(System.Environment.NewLine);
        }
        public void DoSound(int soundnumber, string specialsound)
        {
            for(int i = soundnumber; i > 1; i--) 
            {
            Console.Write(specialsound + "-");
            }
            Console.Write(specialsound);
            Console.Write(System.Environment.NewLine);
        }

        public virtual string Die()
        {
            return "Oh no! " + this.IndividualName + " the " + this.CommonName + " has died.";
        }
       
    }

}