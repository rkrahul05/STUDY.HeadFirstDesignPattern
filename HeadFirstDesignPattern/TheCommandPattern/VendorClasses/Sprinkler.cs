namespace HeadFirstDesignPattern.TheCommandPattern.VendorClasses
{
    public class Sprinkler
    {
        public void WaterOn()
        {
            Console.WriteLine("Watering grass");
        }
        public void WaterOff()
        {
            Console.WriteLine("Sprinkler Off");
        }
    }
}
