using HeadFirstDesignPattern.TheObserverPattern.Interface;

namespace HeadFirstDesignPattern.TheObserverPattern
{
    public class WeatherData : Subject
    {
        private List<Observer> observers { get; set; }
        private float temperature { get; set; }
        private float humidity { get; set; }
        private float pressure { get; set; }
        public WeatherData()
        {
            observers = new List<Observer>();
        }
        public void NotifyObserver()
        {
            foreach (Observer observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void RegisterObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.pressure = pressure;
            this.humidity = humidity;
            MeasurementsChanged();
        }
    }
}
