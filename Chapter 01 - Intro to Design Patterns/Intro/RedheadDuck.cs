﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class RedheadDuck : Duck
    {
        public override void Display() => Console.WriteLine("I'm a real redhead duck!");

        public RedheadDuck()
        {
            setFlyBehavior(new FlyNoWay());
            setQuackBehavior(new Squeak());
        }
    }
}
