using Microsoft.Extensions.Configuration;

using static System.Collections.Specialized.BitVector32;
IConfiguration config = new ConfigurationBuilder()
.SetBasePath(Directory.GetCurrentDirectory())
.AddJsonFile("appsettings.json", true, true)
.Build();

Console.WriteLine($"My car's name is {config["CarName"]}");
Console.ReadLine();

var c = new Car();
section.Bind(c);
Console.Write($"My car object is a {c.Color} ");
Console.WriteLine($"{c.Make} named {c.PetName}");

public class Car
{
    public string? Make { get; set; }
    public string? Color { get; set; }
    public string? PetName { get; set; }
}