using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Interface;

namespace HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Concrete
{
    public class BowAndArrowBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shooting an arrow with a bow");
        }
    }
}
