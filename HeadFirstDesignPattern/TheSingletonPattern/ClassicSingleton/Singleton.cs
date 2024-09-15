namespace HeadFirstDesignPattern.TheSingletonPattern.ClassicSingleton
{
    public class Singleton
    {
        private static Singleton instance;
        private Singleton()
        {
            
        }
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello I am classic singleton pattern");
        }
    }
}
