// See https://aka.ms/new-console-template for more information
Console.WriteLine("*============================*================================*");
Console.WriteLine("*                                                             *");
Console.WriteLine("*                                                             *");
Console.WriteLine("******************Singleton Pattern Example********************");
Console.WriteLine("*                                                             *");
Console.WriteLine("*                                                             *");
Console.WriteLine("*============================*================================*");

var s1 = Creation.Singleton.Singleton.Instance;
var s2 = Creation.Singleton.Singleton.Instance;

if (s1 == s2)
{
    Console.WriteLine("They are the same instance");
}
else
{
    Console.WriteLine("They are different instance");
}
