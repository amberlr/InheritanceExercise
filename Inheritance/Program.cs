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
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */


            var parrot = new Bird();
            
            parrot.Beak = true;
            parrot.CanFly = true;
            parrot.FeatherColor = "purple and blue";
            parrot.Speak = "Hello! Give me a cracker!";

            Console.WriteLine($"Does it have a beak?: {parrot.Beak}");
            Console.WriteLine($"Can it fly?: {parrot.CanFly}");
            Console.WriteLine($"Can reproduce?: {parrot.Reproduce}");
            Console.WriteLine($"Its feathers are {parrot.FeatherColor}, it is {parrot.Age} years old, and it likes to shout ");
            Console.WriteLine($"'{parrot.Speak}'. It must be a parrot!");
            Console.WriteLine();

            var komodoDragon = new Reptile()
            {
                ColdBlood = true,
                Color = "green and brown",
                Scales = true,
                Tail = true,
            }; //this is an example of where we use commas and semicolon after curly brace.. I still don't understand this well

            Console.WriteLine($"Cold blooded?: {komodoDragon.ColdBlood}");
            Console.WriteLine($"Scales?: {komodoDragon.Scales}");
            Console.WriteLine($"Tail?: {komodoDragon.Tail}");
            Console.WriteLine($"Can reproduce?: {komodoDragon.Reproduce}");
            Console.WriteLine($"Came across a komodo dragon today. A huge lizard which likes to {komodoDragon.ModeOfMove} around. It is also {komodoDragon.Color}.");
        }
    }
}
