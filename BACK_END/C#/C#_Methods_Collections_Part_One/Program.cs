using System;
using System.Collections.Generic;
using System.Linq;
public class Program {

    /* Task 1*/
    static double CalculateAverage(int n1, int n2, int n3)
    {
        int sum = n1 + n2 + n3;
        double avg = sum / 3;
        return avg;
    }

    public static void Main(string[] args) {
    /* Task 1*/
        Console.WriteLine("The Average = " + CalculateAverage(9, 8, 6));

        //--------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------


        /* Task 2 */

        List<string> studentsNames = new List<string>();

        studentsNames.Add("Ali");
        studentsNames.Add("Zayen");
        studentsNames.Add("Ahmad");
        studentsNames.Add("Majid");
        studentsNames.Add("Raed");
        Console.Write("[  ");
        foreach (string student in studentsNames)
        {
            Console.Write(student + " ");
        }
        Console.Write(" ]");

        Console.WriteLine("");
        studentsNames.Remove("Ahmad");

        Console.Write("[  ");
        foreach (string student in studentsNames)
        {
            Console.Write(student + " ");
        }
        Console.Write(" ]");
        Console.WriteLine("");
      //--------------------------------------------------------------------------------------------------------------------------------------------
      //--------------------------------------------------------------------------------------------------------------------------------------------


      /* Task 3 */

    Dictionary <int , string > nameID = new Dictionary<int , string >();

        nameID.Add(1, "Ali");
        nameID.Add(2, "Zayen");
        nameID.Add(3, "Majid");

        foreach(var element in nameID)
        {
            Console.WriteLine("ID -> "+ element.Key + " "+ "Name :"+element.Value);
        }

      //--------------------------------------------------------------------------------------------------------------------------------------------
      //--------------------------------------------------------------------------------------------------------------------------------------------

        /* Task 4 */

        int[] numbers = { 5, 10, 15, 20, 25, 30 };
        string[] names = { "Ahmad", "Ali", "Sara", "Mona", "Omar" };

        /* Question 1*/
        var numbersGreater15 = numbers.Where(n => n > 15);

        Console.Write("{  ");
        foreach (var number in numbersGreater15) {
            Console.Write(number + " ");
        }
        Console.Write(" }");
        Console.WriteLine();
        //---------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------

        /* Question 2*/

        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.Write("{  ");
        foreach (var number in evenNumbers)
        {
            Console.Write(number + " ");
        }
        Console.Write(" }");
        Console.WriteLine();
        //---------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------


        /* Question 3*/

        var ascNumbers = numbers.OrderBy(n => n);
        var descNumbers = numbers.OrderByDescending(n  => n);

        Console.WriteLine("Ascending Order");
        Console.Write("{  ");
        foreach (var number in ascNumbers)
        {
            Console.Write(number + " ");
        }
        Console.Write(" }");
        Console.WriteLine();




        Console.WriteLine("Descending Order");
        Console.Write("{  ");
        foreach (var number in descNumbers)
        {
            Console.Write(number + " ");
        }
        Console.Write(" }");
        Console.WriteLine();

        //---------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------


        /* Question 4*/

        var startsWithA = names.Where(n => n.StartsWith("A"));
        Console.Write("{  ");
        foreach (var name in startsWithA)
        {
            Console.Write(name + " ");
        }
        Console.Write(" }");
        Console.WriteLine();

        //---------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------

        /* Question 5*/

        var firtNumber = numbers.FirstOrDefault(n => n > 10);
        Console.WriteLine("First Number Greater Than 10 => " + firtNumber);

        //---------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------

        /* Question 6*/

        var multipliedByTwo = numbers.Select(n => n * 2);

        Console.Write("{  ");
        foreach (var number in multipliedByTwo)
        {
            Console.Write(number + " ");
        }
        Console.Write(" }");
        Console.WriteLine();

        //--------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------

        /* Task 5*/

        SayWelcome();
        SayWelcome("Laila");
        SayWelcomeWithAge("Laila", 21);

        Console.WriteLine(sumOfTwoNumbers(2,9));
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        PrintArrayElements(arr);




    }
    /* Task 5*/
    /* Question 1 */
    static void SayWelcome()
    {
        Console.WriteLine("Welcome");
    }

    /* Question 2 */
    static void SayWelcome(string userName)
    {
        Console.WriteLine("Welcome "+ userName);
    }

    /* Question 3 */

    static void SayWelcomeWithAge(string userName ,int age =18)
    {
        Console.WriteLine("Welcome " + userName + " Your Age " +age);
    }

    /* Question 4 */

    static int sumOfTwoNumbers (int num1 , int num2)
    {
        int sum = num1 + num2;
        return sum;
    }

    /* Question 5 */

    static void PrintArrayElements(int[] arr)
    {
        Console.Write("[  ");
        foreach (int i in arr)
        {
            Console.Write(i+" ");   
        }
        Console.Write(" ]");
    }

   






































}