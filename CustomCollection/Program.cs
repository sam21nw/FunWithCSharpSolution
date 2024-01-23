using CustomCollection;

Console.WriteLine("***** Custom Person Collection *****\n");
PersonCollection myPeople = new PersonCollection();
myPeople.AddPerson(new Person("Homer", "Simpson", 40));
myPeople.AddPerson(new Person("Marge", "Simpson", 38));
myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
myPeople.AddPerson(new Person("Bart", "Simpson", 7));
myPeople.AddPerson(new Person("Maggie", "Simpson", 2));
// This would be a compile-time error!
//myPeople.AddPerson(new Car());

foreach (Person p in myPeople)
{
    Console.WriteLine(p);
}