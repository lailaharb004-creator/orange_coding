using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

public class Program
{
    public static void Main(string[] args)

    {
        /* Task 1 */
         
        /* 
         string [ ] ARR= [ 1,7  9  45, ] 

        int arr2=["Str" "alex","moh" 

        string arr3= 'the','fox' 'over' lazy, 'dog',  ] 

         */
        int[] arr = { 1, 7, 9, 45 };
        string[] arr2 = { "Str", "alex", "moh" };
        string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

        /* Task 2 */
        /* 
         What the index of "Banana","Tomato"? 

        String [ ]  fruits=["Tomato","Banana","Watermelon"] 

         Banana -> 1
         Tomato -> 0

        */

        /* Task 3 */
        string[] fruits = { "banana", "watermelon", "strawberry", "Berries", "peach" };
        string[] movies = { "howel", "maze runner", "big hero 6" };
        string[] sports = { "karate", "boxing", "volleyball" };


        foreach (string fruit in fruits)
        {

            Console.Write(fruit + " ");

        }

        for (int i = 0; i < fruits.Length; i++)
        {
            Console.Write(fruits[i] + " ");
        }
        Console.WriteLine();

        foreach (string movie  in movies)
        {
            Console.Write(movie + " ");
        }
        Console.WriteLine();

        for (int i = 0;i < movies.Length; i++)
        {
            Console.Write(movies[i] + " ");

        }
        Console.WriteLine();

        foreach(string sport in sports)
        {
            Console.Write(sport + " ");

        }
        Console.WriteLine();




        /* Task 4  */
        string  input = Console.ReadLine();
        string[] inputSplit = input.Split(',');

        int num1 = Convert.ToInt32(inputSplit[0]);  
        int num2 = Convert.ToInt32(inputSplit[1]);
        int num3 = Convert.ToInt32(inputSplit[2]);

        int sum = num1 + num2 + num3;

        /* Task 5 */
        int sum_odd = 0;
        for (int i= 1; i<=100; i++)

        {
            if (i %2 != 0)
            {
                sum_odd += i;
            }
        }
            
        Console.WriteLine (sum_odd);


        /* Task 6 */
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 3; j >= i; j--)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
        }
        /* Task 7 */
        int num = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 4; j >= i; j--)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }

            Console.WriteLine();
        }









    }

}