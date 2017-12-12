using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class FlyNoWay : IFlyBehavior // Implements the IFlyBehavior interface
    {
        public void Fly() => Console.WriteLine("I can't fly!"); // Method can be called by Duck objects that instantiate FlyNoWay
    }
}
