// See https://aka.ms/new-console-template for more information
using Creation.Prototype;

Console.WriteLine("*============================*================================*");
Console.WriteLine("*                                                             *");
Console.WriteLine("*                                                             *");
Console.WriteLine("******************Prototype Pattern Example********************");
Console.WriteLine("*                                                             *");
Console.WriteLine("*                                                             *");
Console.WriteLine("*============================*================================*");

// Create an original document
Document originalDoc = new Document(
    "Prototype Pattern",
    "This is an example of the Prototype Design Pattern.",
    "John Doe"
);

Console.WriteLine("Original Document:");
originalDoc.Display();

// Clone the document and modify it
Document clonedDoc = originalDoc.Clone();
clonedDoc.Title = "Cloned Prototype Pattern";
clonedDoc.Author = "Jane Smith";

Console.WriteLine("Cloned Document:");
clonedDoc.Display();

// Original document remains unchanged
Console.WriteLine("Original Document After Cloning:");
originalDoc.Display();