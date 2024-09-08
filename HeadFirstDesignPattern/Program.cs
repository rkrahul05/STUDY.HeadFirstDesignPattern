﻿// See https://aka.ms/new-console-template for more information
using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame;
using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Concrete;
using HeadFirstDesignPattern.IntroToDesignPattern.Duck;
using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Concrete;
using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Interface;
using HeadFirstDesignPattern.TheObserverPattern;
using HeadFirstDesignPattern.TheObserverPattern.Display;


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