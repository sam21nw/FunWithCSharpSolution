using System.Collections;

namespace CustomCollection
{
    public class PersonCollection : IEnumerable
    {
        public ArrayList arPeople = [];

        public Person? GetPerson(int pos) => (Person?)arPeople[pos];

        public void AddPerson(Person p)
        {
            arPeople.Add(p);
        }

        public void ClearPeople()
        {
            arPeople.Clear();
        }

        public int Count => arPeople.Count;

        // default implementation
        public IEnumerator GetEnumerator()
        {
            return arPeople.GetEnumerator();
        }

        // explicit implementation supports Foreach enumeration
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}