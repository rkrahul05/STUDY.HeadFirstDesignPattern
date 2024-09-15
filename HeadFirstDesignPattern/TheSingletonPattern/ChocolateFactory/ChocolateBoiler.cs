namespace HeadFirstDesignPattern.TheSingletonPattern.ChocolateFactory
{
    public class ChocolateBoiler
    {
        private Boolean empty;
        private Boolean boilded;
        private static ChocolateBoiler instance;
        public ChocolateBoiler()
        {
            empty = true;
            boilded = false;
        }

        public static ChocolateBoiler GetChocolateBoiler()
        {
            if (instance == null)
            {
                instance = new ChocolateBoiler();
            }
            return instance;
        }
        public void Fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boilded = false;
                Console.WriteLine("Filling boiler with milk and chocolate");
            }
            else
            {
                Console.WriteLine("Boiler is already have mixture");
            }
        }
        public void Drain()
        {
            if (!IsEmpty() && IsBoilded())
            {
                Console.WriteLine("Drain the boiled mile and chocolate");
                empty = true;
            }
            else
            {
                Console.WriteLine("Either the mixture is not boiled or boiler is empty");
            }
        }
        public void Boil()
        {
            if (!IsEmpty() && !IsBoilded())
            {
                Console.WriteLine("Bring the content to boil");
            }
            else
            {
                Console.WriteLine("Either the mixture is already boiled or boiler is empty");
            }
        }

        public Boolean IsEmpty()
        {
            return empty;
        }
        public Boolean IsBoilded()
        {
            return boilded;
        }
    }
}
