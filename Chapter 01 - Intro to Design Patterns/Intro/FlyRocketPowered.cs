using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class FlyRocketPowered : IFlyBehavior // Implements the IFlyBehavior interface
    {
        public void Fly() => Console.WriteLine("I'm flying with a rocket!"); // Method can be called by Duck objects that instantiate FlyRocketPowered
    }
}
