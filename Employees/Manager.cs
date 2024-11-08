﻿namespace Employees;
internal class Manager : Employee
{
    public int StockOptions { get; set; }
    public Manager()
    {

    }
    public Manager(string fullName, int age, int empId, float currPay, string ssn, int
numbOfOpts)
: base(fullName, age, empId, currPay, ssn, EmployeePayTypeEnum.Salaried)
    {
        StockOptions = numbOfOpts;
    }
}
