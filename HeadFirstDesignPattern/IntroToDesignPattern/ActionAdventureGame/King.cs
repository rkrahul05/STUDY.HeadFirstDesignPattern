using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Concrete;

namespace HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame
{
    public class King : Character
    {
        public King()
        {
            weaponBehavior = new SwordBehavior();
        }

    }
}
