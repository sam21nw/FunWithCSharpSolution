using System.Collections.ObjectModel;
using System.Collections.Specialized;

using FunWithObservableCollections;

ObservableCollection<Person> people = [];
people.Add(new Person(firstName: "Dude", lastName: "Rock", age: 45));
people.Add(new Person(firstName: "Mister", lastName: "Kid", age: 23));

people.CollectionChanged += People_CollectionChanged;

static void People_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
{
    Console.WriteLine($"Action for this event: {e.Action}");
    if (e.Action == NotifyCollectionChangedAction.Remove)
    {
        Console.WriteLine("Here are the OLD items");
        foreach (Person person in e.OldItems)
        {
            Console.WriteLine(person);
        }
        Console.WriteLine();
    }
    if (e.Action == NotifyCollectionChangedAction.Add)
    {
        Console.WriteLine("Here are the OLD items");
        foreach (Person person in e.NewItems)
        {
            Console.WriteLine(person);
        }
        Console.WriteLine();
    }
}

people.Add(new Person("Fred", "Smith", 34));