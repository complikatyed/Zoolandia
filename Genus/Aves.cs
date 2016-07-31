using System;
using Zoolandia;

namespace Zoolandia.Genus
{
    public class Aves : Animal
    {
        public override string GenusName
        { 
            get
            {
                return "bird";
            }
            set
            {
                this.GenusName = "bird";
            }
        }

        public override string Diet
        {
            get
            {
                return "omnivorous";
            }
            set
            {
                this.Diet = "omnivorous";
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
        public override bool Fly( bool fly)
        {
            return fly;
        }

        public override bool Sound( bool sound)
        {
            return sound;
        }
        public override void Reproduce(){
            Console.WriteLine("Birds lay eggs");
        }


    }
}