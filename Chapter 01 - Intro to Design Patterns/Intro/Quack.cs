using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Quack : IQuackBehavior // Implements the IQuackBehavior interface
    {
        void IQuackBehavior.Quack() => Console.WriteLine("Quack"); // Method can be called by any Duck object that instantiates Quack
    }
}
