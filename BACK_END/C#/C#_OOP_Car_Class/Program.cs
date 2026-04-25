using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

public class Program
{
    public static void Main(string[] args)

    {

    }
}
    public class car
    {
        /* the car's make, year, Type, Price, model, Pallet No, and color */
        private string carMake;
        private string carType;
        private string carModel;
        private string carPalletNo;
        private string carColor;


        private int year;

        private decimal price;
        private  static  bool engineState =true ;

        public car(string carMake, string carType, string carModel, string carPalletNo, string carColor, int year, decimal price)
        {
            this.carMake = carMake;
            this.carType = carType;
            this.carModel = carModel;
            this.price = price;
            this.carPalletNo = carPalletNo;
            this.carColor = carColor;
            this.year = year;

        }


    public void startEngine()
    {
        if (engineState)
        {
            Console.WriteLine("Already Started ");

        }
        else
        {
            Console.WriteLine("Starting The Engine");
        }

    }
    public void stopEngine()
    {
        if (engineState)
        {
            Console.WriteLine("Stopping The Engine");

        }
        else
        {
            Console.WriteLine("Already Stopped");
        }

    }
    public string returnFullString()
    {
        return carMake+" "+carModel +" "+carPalletNo +" "+ carColor +" "+ price +" " +year +" "+ carType;
    }














}

   


