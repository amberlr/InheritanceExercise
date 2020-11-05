using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            ModeOfMove = "stomp";
            Reproduce = true;
            Breathe = true;
            Age = 7;
        }

        public bool ColdBlood { get; set; }
        public bool Scales { get; set; }
        public bool Tail { get; set; }
        public string Color { get; set; }
    }
}
