namespace HeadFirstDesignPattern.TheCommandPattern.VendorClasses
{
    public class GarageDoor
    {
        public string NameOfPlace { get; set; }
        public GarageDoor(string name)
        {
            NameOfPlace = name;
        }
        public void Up()
        {
            Console.WriteLine("Garage Door is Open");
        }
        public void Down()
        {
            Console.WriteLine("Garage Door is Closed");
        }
    }
}
