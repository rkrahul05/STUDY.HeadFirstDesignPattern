namespace HeadFirstDesignPattern.TheCommandPattern.VendorClasses
{
    public class GarageDoor
    {
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
