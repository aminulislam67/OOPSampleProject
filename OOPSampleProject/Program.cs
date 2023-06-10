// See https://aka.ms/new-console-template for more information

using OOPSampleProject.Models;


var rental = new Rental()
{
    CarId = 1,
    CarName = "Mersidis",
    Price = 100.00m
};

var car1 = new Car(rental);

string rental1="";
Console.WriteLine("Rent A car first");

rental1=car1.Rentme();
Console.WriteLine(rental1);



var engine = new Engine()
{

    EngineModel = "H932klsd",
    EngineBrand = "Lamborghini",
    EngineHorsePower = 6000

};

var car = new Car(engine);



string carInfo = "";


Console.WriteLine("Start Car...");
 carInfo = car.Start();
Console.WriteLine(carInfo);


Console.WriteLine("Innitiate Accelaration...");
carInfo = car.Accelarate(); 


Console.WriteLine(carInfo);





