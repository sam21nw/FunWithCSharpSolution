namespace FunWithEncapsulation
{
    internal class Employee
    {
        // Field data
        private string? _empName;

        private static int _empId = 1234567890;
        private float _currPay;

        // Accessor (get method)
        public string? GetName() => _empName;

        // Mutator (set method)
        public void SetName(string name)
        {
            // Check
            if (name.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            }
            else
            {
                _empName = name;
            }
        }

        // Properties
        //public string? Name
        //{
        //    get { return _empName; }
        //    set { _empName = value; }
        //}

        public string? Name
        {
            get { return _empName; }
            set
            {
                if (value?.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }

        private static int Id { get; set; }
        public float Pay { get; set; }

        // Constructors
        public Employee()
        {
        }

        public Employee(string? name, float pay)
        {
            Name = name;
            _currPay = pay;
            Id = _empId;
            _empId++;
        }

        // Methods
        public void GiveBonus(float amount) => _currPay += amount;

        public override string ToString()
        {
            return $"Name:{_empName}, ID:{Id}, Current Pay:{_currPay}";
        }
    }
}