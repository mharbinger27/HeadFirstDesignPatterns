using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MallardDuck : Duck
    {
        public override void Display() => Console.WriteLine("I'm a real mallard duck!");

        public MallardDuck()
        {
            setFlyBehavior(new FlyWithWings()); // creates new FlyWithWings object
            setQuackBehavior(new Quack()); // creates new Quack object
        }
    }
}
