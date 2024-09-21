namespace HeadFirstDesignPattern.TheCommandPattern.VendorClasses
{
    public class Stereo
    {
        public string PlaceOfStereo { get; set; }
        public Stereo(string name)
        {
            PlaceOfStereo = name;
        }
        public double Volume { get; set; }
        public void On()
        {
            Console.WriteLine("{0} Stereo is On", PlaceOfStereo);
        }
        public void SetCD()
        {
            Console.WriteLine("CD is set");
        }
        public void SetVolume(double volume)
        {
            Volume = volume;
            Console.WriteLine("Volume is set to {0}", Volume);
        }
        public void Off()
        {
            Console.WriteLine("{0} Stereo is Off", PlaceOfStereo);
        }
    }
}
