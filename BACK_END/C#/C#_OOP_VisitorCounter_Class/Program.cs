using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(VisitorCounter.counter);

        VisitorCounter vistor_1 = new VisitorCounter();
        VisitorCounter vistor_2 = new VisitorCounter();
        VisitorCounter vistor_3 = new VisitorCounter();
        VisitorCounter vistor_4 = new VisitorCounter();

        Console.WriteLine(VisitorCounter.counter);



    }
}

public class VisitorCounter
{
    public  static int counter = 0;

    public VisitorCounter()
    {
        counter++;
    }
}