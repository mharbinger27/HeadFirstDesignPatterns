using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck(); // Constructs new MallardDuck object
            mallard.performQuack();
            mallard.performFly();

            Duck model = new ModelDuck(); // Constructs new ModelDuck object
            model.performFly(); // initially calls default Fly() method defined in ModelDuck subclass to set behavior
            model.setFlyBehavior(new FlyRocketPowered()); // Overrides default Fly() behavior
            model.performFly();
        }
    }
}
