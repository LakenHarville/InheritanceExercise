using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common



            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class



            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Bird kiwi = new Bird()
            {
                Name = "Kiwi",
                Age = 3,
                Legs = 2,
                ActuallyExists = true,
                Wings = 2,
                Type = "stupid dumb bird",
                HasFeathers = true,
                CanFly = true,
            };

            Console.WriteLine($"{kiwi.Name} is a {kiwi.Type} that is {kiwi.Age} years old and has {kiwi.Legs} legs and {kiwi.Wings} wings.");
            Console.WriteLine($"Does {kiwi.Name} even fly? Does he/she actually exist? Are there feathers on this bird that is spoken of?");
            Console.WriteLine($"{kiwi.ActuallyExists}, {kiwi.HasFeathers}, and {kiwi.CanFly}");

            Console.WriteLine("----------------------");

            Reptile tony = new Reptile()
            {
                Name = "Tony",
                Age = 42,
                Legs = 2,
                IsDinosaur = true,
                ActuallyExists = false,
                Noise = "roar",
                LifeSpan = 50,
                IsCarnivore = true,
            };

            Console.WriteLine($"{tony.Name} is {tony.Age} years old with {tony.Legs} legs. He can {tony.Noise} loudly and is expected to die at {tony.LifeSpan} years old.");
            Console.WriteLine($"Does {tony.Name} exist these days? I'm guessing he's a dinosaur? Wasn't he a carnivore?");
            Console.WriteLine($"{tony.ActuallyExists}, {tony.IsDinosaur}, and {tony.IsCarnivore}");

        }


    }
}
