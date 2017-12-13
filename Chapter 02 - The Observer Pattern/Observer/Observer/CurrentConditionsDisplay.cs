using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement, IDisposable
    {
        private ISubject weatherData = null;
        private Measurements measurements = new Measurements();

        public CurrentConditionsDisplay(ISubject newWeatherData)
        {
            this.weatherData = newWeatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Display() => Console.WriteLine("Current conditions: {0}F degrees and {1}% humidity.", this.measurements.temperature, this.measurements.humidity);

        public void Update(Measurements newMeasurements)
        {
            this.measurements = newMeasurements;
            Display();
        }

        public void Dispose() => this.RemoveObserver();

        private void RemoveObserver()
        {
            if (this.weatherData != null)
            {
                this.weatherData.RemoveObserver(this);
            }
        }
    }


}
