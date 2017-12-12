using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class RedheadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Display(): That's a redhead duck!");
        }

        public RedheadDuck()
        {
            Console.WriteLine("RedheadDuck(): A RedheadDuck is born...");
        }
    }
}
