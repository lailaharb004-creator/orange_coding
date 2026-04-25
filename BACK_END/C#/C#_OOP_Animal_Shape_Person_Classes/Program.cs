using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    { }
}
/* Task 1 */
public class Father
{
    public void AddMethod (int n1 , int n2)
    {
        Console.WriteLine(n1+ n2);
    }
    public void AddMethod(int n1, int n2, int n3)
    {
        Console.WriteLine(n1 + n2 + n3);
    }

}


/* Task 2 */
public class Animal
{
    public virtual void speak()
    {
        Console.WriteLine("Speak From Animal");
    }
}

public class Cat :Animal 
{
    public override  void speak()
    {

        Console.WriteLine("Speak From Cat");
    
    }
}


/* Task 3 */
public class Person
{
    private string name;

    public string getSetName
    {
        get { return name; }
        set { name = value; }
    }
      
}
/* Task 5  + 6  */

public class Shape
{
    public void getArea() { }
}

public class Rectangle :Shape { }
