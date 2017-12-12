using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class RubberDuck : Duck
    {
        public override void Display() => Console.WriteLine("I'm a rubber duck!");

        public RubberDuck()
        {
            setFlyBehavior(new FlyNoWay());
            setQuackBehavior(new Squeak());
        }
    }
}
