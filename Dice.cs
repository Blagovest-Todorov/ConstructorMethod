using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsAndClasses
{
    class Dice
    {
                       // Constructor is a special method that creates the object of the class
        public Dice()   // kind a default contructor, gives the initial values of the object
        {
            this.Sides = 6;
        }
        public Dice(int sides)   // this is defined by us consructor. /creates an instance object 
        {                        // sets the start state of the object/
            Sides = sides;
        }

        public int Sides { get; set; }
        public string Type { get; set; }

        public int Roll() 
        {
            Random rnd = new Random();
            return rnd.Next(1, this.Sides + 1); // till 6+1 till 6 inclusive, if we say just side we can not have ever 6;
        }
    }
}
