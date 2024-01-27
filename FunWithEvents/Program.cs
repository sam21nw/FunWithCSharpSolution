
HR hr = new();
EmployeeCare _ = new(hr);
hr.RegisterEmployee("dude", "male", 33);

public delegate void NewEmployeeEventHandler(object sender, NewEmployeeEventArgs e);

class EmployeeCare
{
    public EmployeeCare(HR hr)
    {
        hr.NewEmployee += Hr_NewEmployee;
    }

    private void Hr_NewEmployee(object sender, NewEmployeeEventArgs e)
    {
        Console.WriteLine("Sender of Event: " + sender);
        Console.WriteLine($"Customer Info: {e.Name}, {e.Sex}, {e.Age}");
    }
}

class HR
{
    public event NewEmployeeEventHandler NewEmployee;

    protected void OnNewEmployee(NewEmployeeEventArgs e)
    {
        NewEmployee?.Invoke(this, e);
    }

    public void RegisterEmployee(string name, string sex, int age)
    {
        NewEmployeeEventArgs e = new(name, sex, age);
        OnNewEmployee(e);
    }
}


public class NewEmployeeEventArgs
{
    public string Name;
    public string Sex;
    public int Age;

    public NewEmployeeEventArgs(string name, string sex, int age)
    {
        Name = name;
        Sex = sex;
        Age = age;
    }
}

//MyDelegate d = new(MyMethod);
//d += new MyDelegate(MyMethod2);

//d("Hello");


//static void MyMethod(string text)
//{
//    Console.WriteLine("My method 1: " + text);
//}
//static void MyMethod2(string text)
//{
//    Console.WriteLine("My method 2: " + text);
//}

//public delegate void MyDelegate(string text);