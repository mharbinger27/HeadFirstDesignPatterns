using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class FlyWithWings : IFlyBehavior // implements IFlyBehavior interface
    {
        public void Fly() => Console.WriteLine("I'm flying!"); // Method can be called by Duck objects that instantiate FlyWithWings
    }
}
