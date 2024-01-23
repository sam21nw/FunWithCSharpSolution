using System.Collections;

namespace BasicCollections
{
    internal record Garage : IEnumerable
    {
        private readonly Car[] carArray = new Car[4];

        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 46);
            carArray[3] = new Car("Fred", 78);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public GarageEnum GetEnumerator()
        {
            return new GarageEnum(carArray);
        }
    }
}