using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
       
    }

}