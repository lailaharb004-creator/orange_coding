using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    { 
    Calculator calculator = new Calculator();
        Console.WriteLine(calculator.add(1, 2, 3));
        Console.WriteLine(calculator.add(5, 6));
        Console.WriteLine(calculator.add(7.8m, 8.8m));
            
    
    
    
    }


}
public class Calculator
{
    public int      add (int n1 , int n2) { return n1 + n2; }
    public int      add (int n1 , int n2 , int n3) { return n1 + n2 + n3; }
    public decimal  add (decimal n1 , decimal n2) { return n1 + n2; }
}