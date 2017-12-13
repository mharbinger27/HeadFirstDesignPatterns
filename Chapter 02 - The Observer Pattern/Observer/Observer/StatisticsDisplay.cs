using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class StatisticsDisplay : IObserver, IDisplayElement, IDisposable
    {
        private ISubject weatherData = null;
        private Measurements measurements = new Measurements();
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Display() => Console.WriteLine("Avg/Max/Min temperature = {0}/{1}/{2} on {3} readings.", (tempSum/numReadings), maxTemp, minTemp, numReadings);

        public void Update(Measurements newMeasurements)
        {
            this.measurements = newMeasurements;
            float temp = this.measurements.temperature;
            tempSum += temp;
            numReadings++;

            if (temp > maxTemp)
            {
                maxTemp = temp;
            }

            if (temp < minTemp)
            {
                minTemp = temp;
            }

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
