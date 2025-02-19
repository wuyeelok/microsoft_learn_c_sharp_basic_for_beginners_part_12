// See https://aka.ms/new-console-template for more information
long p = 12;
Console.WriteLine($"Hello, World! Part {p}!");

List<string> names = ["Peter", "Ana", "Felipe"];
names.Add("Maria");
foreach (string name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}