using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public int Wings { get; set; }
        public string Type { get; set; }
        public bool HasFeathers { get; set; }
        public bool CanFly { get; set; }

        public Bird()
        {

        }

        public Bird(string name, int age, int legs, bool actuallyExists, int wings, string type, bool hasFeathers, bool canFly)
        {
            Name = name;
            Age = age;
            Legs = legs;
            ActuallyExists = actuallyExists;
            Wings = wings;
            Type = type;
            HasFeathers = hasFeathers;
            CanFly = canFly;
        }



    }

   
}
