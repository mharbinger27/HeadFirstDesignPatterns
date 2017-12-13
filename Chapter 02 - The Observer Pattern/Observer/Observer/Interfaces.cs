using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface IDisplayElement
    {
        void Display();
    }

    interface IObserver
    {
        void Update(Measurements newMeasurements);
    }

    interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
