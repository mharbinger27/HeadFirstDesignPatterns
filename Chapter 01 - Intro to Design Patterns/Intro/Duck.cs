using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    abstract class Duck
    {
        public virtual void quack()
        {
            Console.WriteLine("quack(): Quack Quack!");
        }

        public void swim()
        {
            Console.WriteLine("swim(): Splashes everywhere.");
        }

        public void fly()
        {
            Console.WriteLine("fly(): To the skies!");
        }

        public abstract void Display();

        public void DuckingAround()
        {
            quack();
            swim();
            Display();
            fly();
            Console.WriteLine();
        }
    }
}
