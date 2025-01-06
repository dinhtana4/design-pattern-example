// See https://aka.ms/new-console-template for more information
using Creation.AbstractFactory;

Console.WriteLine("*============================*================================*");
Console.WriteLine("*                                                             *");
Console.WriteLine("*                                                             *");
Console.WriteLine("***************Abstract Factory Pattern Example****************");
Console.WriteLine("*                                                             *");
Console.WriteLine("*                                                             *");
Console.WriteLine("*============================*================================*");
Console.WriteLine("Enter OS type (Windows, Mac):");
string osType = Console.ReadLine();

var uiFactory = ABFactory.CreateUIFactory(osType);
uiFactory.CreateButton().Render();
uiFactory.CreateCheckbox().Render();
