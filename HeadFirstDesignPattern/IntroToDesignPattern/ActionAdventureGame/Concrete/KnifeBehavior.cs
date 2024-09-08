using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Interface;

namespace HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Concrete
{
    public class KnifeBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Cutting with a knife");
        }
    }
}
