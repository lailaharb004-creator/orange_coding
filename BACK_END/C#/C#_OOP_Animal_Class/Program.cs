using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    { }
}
public class Animal
{
    public virtual void makeSound() { }
}

public class Dog :Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat :Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Meow");
    }
}
