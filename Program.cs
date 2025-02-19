// See https://aka.ms/new-console-template for more information
var p = 12L;
Console.WriteLine($"Hello, World! Part {p}!");

List<string> names = ["Peter", "Ana", "Felipe"];
names.Add("Maria");
foreach (string name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

var items = new List<string>();
Console.WriteLine($"There are {items.Count} items in the list.");