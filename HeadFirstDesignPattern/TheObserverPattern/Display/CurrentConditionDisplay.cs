using HeadFirstDesignPattern.TheObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.TheObserverPattern.Display
{
    public class CurrentConditionDisplay : Observer,DisplayElement
    {
        private float temperature { get; set; }
        private float humidity { get; set; }
        private float pressure { get; set; }
        private WeatherData weatherData { get; set; }

        public CurrentConditionDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("Current conditions: {0}F degrees and {1}% humidity",temperature,humidity);
        }

        public void Update()
        {
            this.temperature = weatherData.GetTemprature();
            this.humidity = weatherData.GetHumidity();
            Display();
        }
    }
}
