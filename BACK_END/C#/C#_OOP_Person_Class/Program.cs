using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

public class Program
{
    public static void Main(string[] args)

    {

        // case 1
        Person person_1 = new Person();
        person_1.PersonInfo();
        person_1.name = "Laila";

        // person_1.age  // error 
        // person_1.helloFromStudent() // error 

        //-------------------------------------------------------------------------------
        // case 2
        Student student_1 = new Student();
        student_1.helloFromStudent();
        student_1.PersonInfo();
        student_1.name = "Ali";

        // student_1.age // error 
        // Student student_2 = new Person(); // error 

        //-------------------------------------------------------------------------------
        // case 3
        Person person_2 = new Student();
        person_2.PersonInfo();
       // person_2.helloFromStudent() // error 


    }
}

public class Person
{
    public  string name { get; set; } = "person";
    private int age;

    public void PersonInfo()
    {
        Console.WriteLine("Person Name -> "+ this.name );
        Console.WriteLine("Person Age -> "+this.age);

    }
}

public class Student :Person 
{
    public void helloFromStudent()
    {
        Console.WriteLine("Hello From Student");
    }
}