// See https://aka.ms/new-console-template for more information
var p = 12L;
Console.WriteLine($"Hello, World! Part {p}!");

List<string> names = ["Peter", "Ana", "Felipe"];
names.Add("Maria");
foreach (string name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"Hello {names[i].ToUpper()}!");
}


var items = new List<string>();
Console.WriteLine($"There are {items.Count} items in the list.");

var keys = new HashSet<string>
{
    "key1",
    "key1"
};
foreach (var key in keys)
{
    Console.WriteLine(key);
}