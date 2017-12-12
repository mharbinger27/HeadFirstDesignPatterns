using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Duck
    {
        IQuackBehavior quackBehavior; // interface instance variables
        IFlyBehavior flyBehavior;

        public virtual void performFly() => this.flyBehavior.Fly(); // Duck's performFly calls subclass's Fly method

        public void performQuack() => this.quackBehavior.Quack(); // Duck's performQuack calls subclass's Quack method

        public void setFlyBehavior(IFlyBehavior fb) => this.flyBehavior = fb; // Requires an instance of a class that implements IFlyBehavior

        public void setQuackBehavior(IQuackBehavior qb) => this.quackBehavior = qb; // Requires an instance of a class that implements IQuackBehavior

        public void swim() // All Ducks and subclasses use the same swim() method
        {
            Console.WriteLine("All ducks float, evey decoys!");
        }

        public abstract void Display(); // Display() is abstract, and must be overridden in subclass
    }
}
