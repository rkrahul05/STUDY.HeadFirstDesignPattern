using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Interface;

namespace HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Concrete
{
    public class SwordBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Swinging a sword");
        }
    }
}
