using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class MuteQuack : IQuackBehavior // implements the IQuackBehavior interface
    {
        void IQuackBehavior.Quack() => Console.WriteLine("<< Silence >>"); // Method can be called by any Duck object that instantiates MuteQuack
    }
}
