using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Concrete;

namespace HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame
{
    public class Queen : Character
    {
        public Queen()
        {
            weaponBehavior = new KnifeBehavior();
        }
    }
}
