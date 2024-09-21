namespace HeadFirstDesignPattern.TheCommandPattern.VendorClasses
{
    public class CeilingFan
    {
        public string PlaceOfCeilingFan { get; set; }
        public CeilingFan(string name)
        {
            PlaceOfCeilingFan = name;
        }
        public void On()
        {
            Console.WriteLine("{0} Ceiling fan is On", PlaceOfCeilingFan);
        }
        public void Off()
        {
            Console.WriteLine("{0} Ceiling fan is Off", PlaceOfCeilingFan);
        }
    }
}
