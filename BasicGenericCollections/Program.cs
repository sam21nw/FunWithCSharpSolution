// See https://aka.ms/new-console-template for more information
using BasicGenericCollections;

Console.WriteLine("***** Basic generic collections *****");

List<Person> people =
  [
    new() { FirstName = "Homer", LastName = "Simpson", Age = 47 },
      new() { FirstName = "Marge", LastName = "Simpson", Age = 45 },
      new() { FirstName = "Lisa", LastName = "Simpson", Age = 9 },
      new() { FirstName = "Bart", LastName = "Simpson", Age = 8 }
  ];

foreach (Person item in people)
{
    Console.WriteLine(item);
}