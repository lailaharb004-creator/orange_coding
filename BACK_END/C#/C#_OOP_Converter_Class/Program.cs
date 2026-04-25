using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    { 
     Converter conv_1 = new Converter();
        // conv_1.convertCelToFeh(); // error 

        Converter.convertCelToFeh();
        Converter.convertkiloToMiles();





    }
}

public class Converter
{
    public static void convertCelToFeh() { }
    public static void convertkiloToMiles() { }
}