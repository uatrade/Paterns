using Observer_Patern.Displays;
using Paterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Patern
{
   public class WeatherStation
   {
        public static void Main(string[] args)
        {
            WeatherData weatherData= new WeatherData();

            CurrentConditiosDisplay currentConditiosDisplay = new CurrentConditiosDisplay(weatherData);

            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            StatisticsDisplay StatisticsDisplay = new StatisticsDisplay(weatherData);

            weatherData.SetData(25, 82, 160);

            Console.WriteLine("\nUpdated");
            weatherData.SetData(22, 75, 150);

            Console.WriteLine("\nUpdated");
            weatherData.SetData(18, 95, 140);

            Console.ReadKey();

        }

   }
}
