// See https://aka.ms/new-console-template for more information
using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame;
using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Concrete;
using HeadFirstDesignPattern.IntroToDesignPattern.Duck;
using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Concrete;
using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Interface;


/*
#region Duck simulation
Duck mallard = new RubberDuck();
mallard.PerformQuack();
mallard.PerformFly();
//mallard.flyBehavior = new FlyNoWay();

Duck model = new ModelDuck();
model.Display();
model.PerformFly();
model.flyBehavior = new FlyRocketPowered();
model.PerformFly();

#endregion Duck simulation

*/


#region Game

Character king = new King();
king.Fight();
king.weaponBehavior = new AxeBehavior();
king.Fight();
king.weaponBehavior = new BowAndArrowBehavior();
king.Fight();

Character queen = new Queen();
queen.Fight();

#endregion Game