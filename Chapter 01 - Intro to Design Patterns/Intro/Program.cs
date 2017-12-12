using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.DuckingAround();

            Duck redhead = new RedheadDuck();
            redhead.DuckingAround();

            Duck rubber = new RubberDuck();
            rubber.DuckingAround();
        }
    }
}
