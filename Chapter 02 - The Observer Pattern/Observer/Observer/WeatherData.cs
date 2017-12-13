using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    struct Measurements
    {
        public float temperature;
        public float humidity;
        public float pressure;
    }

    class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private Measurements measurements = new Measurements();

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o) => this.observers.Add(o);

        public void RemoveObserver(IObserver o) => this.observers.Remove(o);

        public void NotifyObservers()
        {
            foreach (IObserver observer in this.observers)
            {
                observer.Update(measurements);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(Measurements newMeasurements)
        {
            this.measurements = newMeasurements;
            MeasurementsChanged();
        }
    }
}
