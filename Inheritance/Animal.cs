using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        // Create a class Animal
        // give this class 4 members that all Animals have in common
        public Animal() 
        {
         
        }
        public string ModeOfMove { get; set; }
        public bool Breathe { get; set; }
        public bool Reproduce { get; set; }
        public int Age { get; set; }
    }
}
