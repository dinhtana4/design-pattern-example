// See https://aka.ms/new-console-template for more information
using Creation.Factory;

Console.WriteLine("*============================*================================*");
Console.WriteLine("*                                                             *");
Console.WriteLine("*                                                             *");
Console.WriteLine("*******************Factory Pattern Example*********************");
Console.WriteLine("*                                                             *");
Console.WriteLine("*                                                             *");
Console.WriteLine("*============================*================================*");
Console.WriteLine("Enter vehicle type (Car/Bike/Truck):");
string vehicleType = Console.ReadLine();

try
{
    IVehicle vehicle = VehicleFactory.CreateVehicle(vehicleType);
    vehicle.Drive();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}