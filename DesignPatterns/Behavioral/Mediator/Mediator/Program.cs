using Mediator;

var tower = new ControlTower();

var plane1 = new Airplane("Boeing 737", tower);
var plane2 = new Airplane("Airbus A320", tower);

plane1.RequestLanding();
Console.WriteLine("----------------");

plane2.RequestLanding();