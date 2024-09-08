using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Concrete;

namespace HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame
{
    public class Troll : Character
    {
        public Troll()
        {
            weaponBehavior = new AxeBehavior();
        }
    }
}
