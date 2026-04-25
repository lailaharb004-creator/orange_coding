using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    { }
}
public abstract  class Appliance
{
    public abstract void turnOn();
    public abstract void turnOff();

    public string brand
    {
        get;
        set;
    }
}
public class WashingMachine : Appliance
{
     static bool washCycle = true;
    public  override void turnOn()

    {
        if (washCycle)
        {
            Console.WriteLine(" Washing Cycle Already Turned On  ");
        }
        else
        {
            Console.WriteLine("Turning On  Washing Cycle");
        }
    }
    public override  void turnOff()
    {
        if (washCycle)
        {
            Console.WriteLine("Turning Off  Washing Cycle");
            washCycle = false;
        }
        else
        {
            Console.WriteLine("Washing Cycle Already Turned Off");
        }
    }
}

public class AirConditioner : Appliance
{
    static bool coolingMood = true;
    public override void turnOn()
    {
        if (coolingMood)
        {
            Console.WriteLine(" Air Conditioner Cooling Mood Already  Turned On  ");
        }
        else
        {
            Console.WriteLine("Turning On Air Conditioner Cooling Mood");
        }
    }
    public override void turnOff()
    {
        if (coolingMood)
        {
            Console.WriteLine("Turning Off  Air Conditioner Cooling Mood");
            coolingMood = false;
        }
        else
        {
            Console.WriteLine("Air Conditioner Cooling Mood Already Turned Off");
        }
    }
}