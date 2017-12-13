using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class WeatherStation
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            Measurements measurements = new Measurements
            {
                humidity = 65F,
                pressure = 30.4F,
                temperature = 80F
            };
            weatherData.SetMeasurements(measurements);

            measurements.humidity = 70F;
            measurements.pressure = 29.2F;
            measurements.temperature = 82F;
            weatherData.SetMeasurements(measurements);

            measurements.humidity = 90F;
            measurements.pressure = 29.2F;
            measurements.temperature = 78F;
            weatherData.SetMeasurements(measurements);
        }
    }
}
