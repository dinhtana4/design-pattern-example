using Creation.Builder;

Console.WriteLine("*============================*================================*");
Console.WriteLine("*                                                             *");
Console.WriteLine("*                                                             *");
Console.WriteLine("******************Prototype Pattern Example********************");
Console.WriteLine("*                                                             *");
Console.WriteLine("*                                                             *");
Console.WriteLine("*============================*================================*");

var luxuryHouse = new LuxuryHouseBuilder();
var houseDirector = new HouseDirector(luxuryHouse);
houseDirector.ConstructHouse();
houseDirector.GetHouse().Display();

var basicHouse = new BasicHouseBuilder();
houseDirector = new HouseDirector(basicHouse);
houseDirector.ConstructHouse();
houseDirector.GetHouse().Display();
