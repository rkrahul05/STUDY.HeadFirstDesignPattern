using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Interface;

namespace HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Concrete
{
    public class AxeBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Chopping with an axe");
        }
    }
}
