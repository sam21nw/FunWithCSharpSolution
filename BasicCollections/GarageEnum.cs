using System.Collections;

namespace BasicCollections
{
    internal record GarageEnum : IEnumerator
    {
        public Car[] _carLot;
        private int position = -1;

        public GarageEnum(Car[] list)
        {
            _carLot = list;
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public Car Current
        {
            get
            {
                try
                {
                    return _carLot[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position += 1;
            return position < _carLot.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}