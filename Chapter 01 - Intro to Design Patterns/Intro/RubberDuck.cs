using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class RubberDuck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("quack(): Squeak squeak!");
        }

        public RubberDuck()
        {
            Console.WriteLine("RubberDuck(): A RubberDuck is born...");
        }

        public override void Display()
        {
            Console.WriteLine("Display(): That's a rubber duck!");
        }
    }
}
