using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Concrete;

namespace HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame
{
    public class Knight : Character
    {
        public Knight()
        {
            weaponBehavior = new BowAndArrowBehavior();
        }
    }
}
