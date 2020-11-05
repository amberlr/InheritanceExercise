using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            ModeOfMove = "Fly";
            Breathe = true;
            Reproduce = true;
            Age = 40;
        }

        public bool CanFly { get; set; }
        public string FeatherColor { get; set; }
        public bool Beak { get; set; }
        public string Speak { get; set; }
    }
}
