namespace Employees;

class Employee
{
    // Field data.
    private string? _empName;
    private int _empId;
    private int _empAge;
    private float _currPay;
    private string? _empSSN;
    private EmployeePayTypeEnum _payType;
    private DateTime _hireDate;

    // Properties
    public string? Name
    {
        get { return _empName; }
        set
        {
            if (value?.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            } else
            {
                _empName = value;
            }
        }
    }
    public int Age
    {
        get { return _empAge; }
        set { _empAge = value; }
    }
    public int Id
    {
        get { return _empId; }
        set { _empId = value; }
    }
    public float Pay
    {
        get { return _currPay; }
        set { _currPay = value; }
    }
    public string? SocialSecurityNumber
    {
        get => _empSSN;
        private set => _empSSN = value;
    }

    public EmployeePayTypeEnum PayType
    {
        get { return _payType; }
        set { _payType = value; }
    }
    public DateTime HireDate
    {
        get { return _hireDate; }
        set { _hireDate = value; }
    }

    // Constructors.
    public Employee() { }
    public Employee(string name, int id, float pay, string empSsn, DateTime hireDate) : this(name, 0, id, pay, empSsn, EmployeePayTypeEnum.Salaried, hireDate) { }
    public Employee(string name, int age, int id, float pay, string empSsn, EmployeePayTypeEnum payType, DateTime hireDate)
    {
        Name = name;
        Age = age;
        Id = id;
        Pay = pay;
        SocialSecurityNumber = empSsn;
        PayType = payType;
        HireDate = hireDate;
    }
    public Employee(string name, int age, int id, float pay, string empSsn, EmployeePayTypeEnum payType)
    {
        Name = name;
        Id = id;
        Age = age;
        Pay = pay;
        SocialSecurityNumber = empSsn;
        PayType = payType;
    }

    // Methods.
    public void GiveBonus(float amount)
    {
        Pay = this switch
        {
            { Age: >= 18, PayType: EmployeePayTypeEnum.Commission, HireDate.Year: > 2020 }
            => Pay += .10F * amount,
            { PayType: EmployeePayTypeEnum.Hourly, HireDate.Year: > 2020 }
            => Pay += .40F * amount / 2080F,
            { PayType: EmployeePayTypeEnum.Salaried, HireDate.Year: > 2020 }
            => Pay += .10F * amount,
            _ => Pay += 0
        };
    }
    public void SetAge(int age) => _empAge = age;
    public void DisplayStats()
    {
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("Age: {0}", Age);
        Console.WriteLine("ID: {0}", Id);
        Console.WriteLine("Pay: {0}", Pay);
    }
}