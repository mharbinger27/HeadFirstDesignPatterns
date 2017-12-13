using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ForecastDisplay : IObserver, IDisplayElement, IDisposable
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private ISubject weatherData = null;
        private Measurements measurements = new Measurements();

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.Write("Forecast: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (currentPressure < lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }

        public void Update(Measurements newMeasurements)
        {
            this.measurements = newMeasurements;
            lastPressure = currentPressure;
            currentPressure = measurements.pressure;

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