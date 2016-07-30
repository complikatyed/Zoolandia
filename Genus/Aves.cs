using System;
using Zoolandia;

namespace Zoolandia.Genus
{
    public class Aves : Animal
    {
        
        public Aves() : base()
        {}
        public string ClassName
        { 
            get
            {
                return this.ClassName;
            }
            set
            {
                this.ClassName = "bird";
            }
        }
        public bool Wings
        {
            get
            {
                return this.Wings;
            }
            set
            {
                this.Wings = true;
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