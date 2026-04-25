using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    { 
        Company c1 = new Company();
        Company c2 = new Company();
        Company c3 = new Company();


        Company.companyName = "Orange School";
        //c1.companyName = "Orange School"; // error 

        Console.WriteLine(Company.companyName);
       // Console.WriteLine(c1.companyName); // error 

    }
}

public class Company
{
    public static string companyName { get; set; } = "Orange";
    public string employeeName { get; set; }
}
