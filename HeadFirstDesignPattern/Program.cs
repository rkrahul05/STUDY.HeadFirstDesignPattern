// See https://aka.ms/new-console-template for more information
using HeadFirstDesignPattern;
using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame;
using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Concrete;
using HeadFirstDesignPattern.IntroToDesignPattern.Duck;
using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Concrete;
using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Interface;
using HeadFirstDesignPattern.TheAdapterPattern;
using HeadFirstDesignPattern.TheAdapterPattern.Concrete;
using HeadFirstDesignPattern.TheAdapterPattern.Interface;
using HeadFirstDesignPattern.TheCommandPattern;
using HeadFirstDesignPattern.TheCommandPattern.Command;
using HeadFirstDesignPattern.TheCommandPattern.VendorClasses;
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


/*Singleton pattern
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
*/

/* Command Pattern
#region Command Pattern
//SimpleRemoteControl remote = new SimpleRemoteControl();
//Light light = new Light("Any ligh");
//GarageDoor garageDoor = new GarageDoor("Garage");
//LightOnCommand lightOn = new LightOnCommand(light);
//GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);

//remote.SetCommand(lightOn);
//remote.ButtonWasPressed();
//remote.SetCommand(garageDoorOpen);
//remote.ButtonWasPressed();

//Implementing the complete remote
//Devices
RemoteControl remoteControl = new RemoteControl();
Light livingRoomLight = new Light("Living room light");
Light kitchenLight = new Light("Kitechen light");
CeilingFan ceilingFan = new CeilingFan("Living room");
GarageDoor garageDoor1 = new GarageDoor("Garage");
Stereo stereo = new Stereo("Living room");

//Commands
LightOnCommand livingRoomLightOnCommand = new LightOnCommand(livingRoomLight);
LightOffCommand livingRoomLightOffCommand = new LightOffCommand(livingRoomLight);
LightOnCommand kitchenLightOnCommand = new LightOnCommand(kitchenLight);
LightOffCommand kitchenLightOffCommand = new LightOffCommand(kitchenLight);

CeilingFanOnCommand ceilingFanOncommand = new CeilingFanOnCommand(ceilingFan);
CeilingFanOffCommand ceilingFanOffcommand = new CeilingFanOffCommand(ceilingFan);

StereoOnWithCDCommand stereoOnWithCDCommand = new StereoOnWithCDCommand(stereo);
StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);

//Setting all the command to button
remoteControl.SetCommand(0,livingRoomLightOnCommand,livingRoomLightOffCommand);
remoteControl.SetCommand(1,kitchenLightOnCommand,kitchenLightOffCommand);
remoteControl.SetCommand(2,ceilingFanOncommand,ceilingFanOffcommand);
remoteControl.SetCommand(3,stereoOnWithCDCommand,stereoOffCommand);

Console.WriteLine(remoteControl);

remoteControl.OnButtonWasPressed(0);
remoteControl.OffButtonWasPressed(0);
remoteControl.OnButtonWasPressed(1);
remoteControl.OffButtonWasPressed(1);
remoteControl.OnButtonWasPressed(2);
remoteControl.OffButtonWasPressed(2);
remoteControl.OnButtonWasPressed(3);
remoteControl.OffButtonWasPressed(3);

#endregion Command Pattern
*/

#region Adapter Pattern
IDuck duck = new HeadFirstDesignPattern.TheAdapterPattern.Concrete.MallardDuck();
ITurkey turkey = new WildTurkey();

IDuck turkeyAdapter = new TurkeyAdapter(turkey);

Console.WriteLine("The Turkey says.......");
turkey.Gobble();
turkey.Fly();

Console.WriteLine("The Duck says.......");
CommanStaticClass.TestDuck(duck);

Console.WriteLine("The TurkeyAdapter says.......");
CommanStaticClass.TestDuck(turkeyAdapter);





#endregion Adapter Pattern
