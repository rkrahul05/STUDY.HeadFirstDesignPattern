namespace HeadFirstDesignPattern.TheCommandPattern.VendorClasses
{
    public class Light
    {
        public string NameOfLight { get; set; }
        public Light(string name)
        {
            NameOfLight = name;
        }
        public void On()
        {
            Console.WriteLine("{0} Light is ON", NameOfLight);
        }
        public void Off()
        {
            Console.WriteLine("{0} Light is OFF", NameOfLight);

        }
    }
}
