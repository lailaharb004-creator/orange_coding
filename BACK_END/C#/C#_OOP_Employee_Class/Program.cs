using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {

        Employee emp1 = new FullTimeEmployee("Ali", 1000m);
        Employee emp2 = new PartTimeEmployee("Sara", 40, 10m);

        Console.WriteLine(emp1.Name + " Salary: " + emp1.calculateSalary());
        Console.WriteLine(emp2.Name + " Salary: " + emp2.calculateSalary());

    }
}

public  abstract class Employee
{
    public string Name;
    public Employee (string name)
    {
        Name = name;
    }
    public abstract decimal calculateSalary();
    
}


class FullTimeEmployee : Employee
{
    public decimal MonthlySalary;

    public FullTimeEmployee(string name, decimal monthlySalary)
        : base(name)
    {
        MonthlySalary = monthlySalary;
    }

    public override decimal calculateSalary()
    {
        return MonthlySalary;
    }
}

class PartTimeEmployee : Employee
{
    public int HoursWorked;
    public decimal HourRate;

    public PartTimeEmployee(string name, int hoursWorked, decimal hourRate)
        : base(name)
    {
        HoursWorked = hoursWorked;
        HourRate = hourRate;
    }

    public override decimal calculateSalary()
    {
        return HoursWorked * HourRate;
    }
}