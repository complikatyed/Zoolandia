using System;

namespace Zoolandia.Genus
{
    public class Aves : Genus
    {
        public override string GenusName
        { 
            get
            {
                return "bird";
            }
        }

        public override string Diet
        {
            get
            {
                return "omnivorous";
            }
        }
        public override bool Wings
        {
            get
            {
                return true;
            }
        }

        public override bool Swim( bool swim)
        {
            return swim;
        }
        public override void Reproduce(){
            Console.WriteLine("Birds lay eggs");
        }


    }
}