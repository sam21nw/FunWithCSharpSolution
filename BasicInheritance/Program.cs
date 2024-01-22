using BasicInheritance;

Console.WriteLine("***** Basic Inheritance *****\n");
Car car = new(80) { Speed = 100 };

Console.WriteLine(car);

Console.WriteLine("-----------------------------");
MiniVan van = new() { Speed = 100 };
Console.WriteLine(van);