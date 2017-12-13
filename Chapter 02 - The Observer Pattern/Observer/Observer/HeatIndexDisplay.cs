using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class HeatIndexDisplay : IObserver, IDisplayElement, IDisposable
    {
        float heatIndex = 0.0f;
        private ISubject weatherData = null;
        private Measurements measurements = new Measurements();

        public HeatIndexDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display() => Console.WriteLine("Heat index is {0}", heatIndex);

        public void Update(Measurements newMeasurements)
        {
            this.measurements = newMeasurements;
            float t = measurements.temperature;
            float rh = measurements.humidity;
            heatIndex = (float)
                (
                (16.923 + (0.185212 * t)) +
                (5.37941 * rh) -
                (0.100254 * t * rh) +
                (0.00941695 * (t * t)) +
                (0.00728898 * (rh * rh)) +
                (0.000345372 * (t * t * rh)) -
                (0.000814971 * (t * rh * rh)) +
                (0.0000102102 * (t * t * rh * rh)) -
                (0.000038646 * (t * t * t)) +
                (0.0000291583 * (rh * rh * rh)) +
                (0.00000142721 * (t * t * t * rh)) +
                (0.000000197483 * (t * rh * rh * rh)) -
                (0.0000000218429 * (t * t * t * rh * rh)) +
                (0.000000000843296 * (t * t * rh * rh * rh)) -
                (0.0000000000481975 * (t * t * t * rh * rh * rh)));

            Display();
        }

        public void Dispose() => this.RemoveObserver();

        public void RemoveObserver()
        {
            if (this.weatherData != null)
            {
                this.weatherData.RemoveObserver(this);
            }
        }
    }
}
