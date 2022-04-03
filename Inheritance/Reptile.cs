using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool IsDinosaur { get; set;}
        public string Noise { get; set; }
        public int LifeSpan { get; set; }
        public bool IsCarnivore { get; set; }

        public Reptile()
        {

        }

        public Reptile(string name, int age, int legs, bool actuallyExists, bool isDinosaur, string noise, int lifeSpan, bool isCarnivore)
        {
            Name = name;
            Age = age;
            Legs = legs;
            IsDinosaur = isDinosaur;
            ActuallyExists = actuallyExists;
            Noise = noise;
            LifeSpan = lifeSpan;
            IsCarnivore = isCarnivore;
        }
    }


}
