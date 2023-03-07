using Observer_Patern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns.Observer
{
    public class WeatherData : ISubject
    {
        private List<IObserver> Observers;
        private float Temp { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }

        public WeatherData() {
            Observers = new List<IObserver>();
        }


        public void NotifyObserver()
        {
            foreach (var observer in Observers)
            {
                observer.Update(Temp, Humidity, Pressure);
            }
        }

        public void RegistryObserver(IObserver o)
        {
            Observers.Add(o);   
        }

        public void RemoveObserver(IObserver o)
        {
            Observers.Remove(o);    
        }

        public void SetData(float temp, float humidity, float pressure)
        {
            this.Temp=temp; 
            this.Humidity=humidity;    
            this.Pressure=pressure;

            NotifyObserver();
        }
    }
}
