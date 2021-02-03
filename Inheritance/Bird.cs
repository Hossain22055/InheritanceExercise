using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird:Animal
    {
     // Create a class Bird
     // give this class 4 members that are specific to Bird
     // Set this class to inherit from your Animal Class
        public Bird()
        {

        }
        public bool haveWings { get; set; }
        public bool haveEggs { get; set; }
        public bool haveFeathers { get; set; }
        public bool canFly { get; set; }



    }
}
