using HeadFirstDesignPattern.TheObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.TheObserverPattern.Display
{
    public class StatisticsDisplay: Observer,DisplayElement
    {
        private float temperature { get; set; }
        private float humidity { get; set; }
        private float pressure { get; set; }
        private WeatherData weatherData { get; set; }

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("Statistics conditions: {0}F degrees, {1}% humidity and pressure {2}bar",temperature,humidity,pressure);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
    }
}
