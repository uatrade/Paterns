using Paterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Patern.Displays
{
    internal class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float Temp { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }
        private WeatherData WeatherData { get; set; }

        public StatisticsDisplay(WeatherData weatherData)
        {
            WeatherData = weatherData;
            weatherData.RegistryObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"StatisticsDisplay: temp= {Temp} C, Humidity= {Humidity}  mm, Pressure= {Pressure} Pa");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.Temp = temp;
            this.Humidity = humidity;
            this.Pressure = pressure;

            Display();
        }
    }
}
