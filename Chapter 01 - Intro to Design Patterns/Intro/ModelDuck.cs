using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            setFlyBehavior(new FlyNoWay());
            setQuackBehavior(new Quack());
        }

        public override void Display() => Console.WriteLine("I'm a model duck");
    }
}
