using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Display(): That's a mallard duck!");
        }

        public MallardDuck()
        {
            Console.WriteLine("MallardDuck(): A MallardDuck is born...");
        }
    }
}
