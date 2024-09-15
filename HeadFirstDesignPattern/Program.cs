﻿// See https://aka.ms/new-console-template for more information
using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame;
using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Concrete;
using HeadFirstDesignPattern.IntroToDesignPattern.Duck;
using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Concrete;
using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Interface;
using HeadFirstDesignPattern.TheDecoratorPattern;
using HeadFirstDesignPattern.TheDecoratorPattern.Beverages;
using HeadFirstDesignPattern.TheDecoratorPattern.ConcreteCondimentDecorator;
using HeadFirstDesignPattern.TheFactoryPattern;
using HeadFirstDesignPattern.TheFactoryPattern.ConcretePizzaStore;
using HeadFirstDesignPattern.TheObserverPattern;
using HeadFirstDesignPattern.TheObserverPattern.Display;
using HeadFirstDesignPattern.TheSingletonPattern.ChocolateFactory;
using HeadFirstDesignPattern.TheSingletonPattern.ClassicSingleton;


/* Duck simulation
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

/*Game
#region Game

Character king = new King();
king.Fight();
king.weaponBehavior = new AxeBehavior();
king.Fight();
king.weaponBehavior = new BowAndArrowBehavior();
king.Fight();

Character queen = new Queen();
queen.Fight();

#endregion Game*/

/* Observer pattern
#region Weather-O-Rama
WeatherData weatherData = new WeatherData();
CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

weatherData.SetMeasurements(80,65,30.4f);
weatherData.SetMeasurements(82,63,31.4f);
weatherData.SetMeasurements(84,67,32.4f);
weatherData.SetMeasurements(96,70, 34.4f);
Console.WriteLine("before unsbuscribe the heatindex display");
heatIndexDisplay.Display();
Console.WriteLine("after unsbuscribe the heatindex display");
heatIndexDisplay.Unsubscribe();
weatherData.SetMeasurements(100, 100, 37.4f);
heatIndexDisplay.Display();
#endregion Weather-O-Rama
*/

/* Decorator Pattern
#region Decorator Pattern

Beverage beverage = new Espresso();
Console.WriteLine(beverage.GetDescription() +" $"+ beverage.Cost());

Beverage beverage1 = new DarkRoast();
beverage1 = new Mocha(beverage1);  //Wrapping DarkRoast with Mocha
beverage1 = new Mocha(beverage1);  // onother one
beverage1 = new Whip(beverage1);   //Wrapping DarkRoast with Whip
Console.WriteLine(beverage1.GetDescription() + " $" + beverage1.Cost());   //Print the description and cost
#endregion Decorator Pattern
*/

/* Factory pattern
#region Factory pattern
PizzaStore nyStore = new NYStylePizzaStore();
Pizza pizza = nyStore.OrderPizza("Cheese");
Console.WriteLine("I have ordered a " + pizza.GetName());

#endregion Factory pattern
*/

#region Singleton pattern
//var singletonInstance =  Singleton.GetInstance();
//singletonInstance.SayHello();

//Creating first instance of boiler
var boilerInstance1 = ChocolateBoiler.GetChocolateBoiler();
Console.WriteLine(boilerInstance1.IsEmpty());
boilerInstance1.Fill();  //Filling the boiler with mixture
Console.WriteLine(boilerInstance1.IsEmpty());

//Now creating another instace of the boiler and checking is empty, If the instance is same the it should be already filled with mixture
var boilerInstance2 = ChocolateBoiler.GetChocolateBoiler();
Console.WriteLine(boilerInstance2.IsEmpty());
#endregion Singleton pattern