using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        /*Task 1 */
        int num1 = 5; int num2 = 10;
        Console.WriteLine(minNumber(num1, num2));

        num1 = 15; num2 = 10;
        Console.WriteLine(minNumber(num1, num2));

        num1 = 15; num2 = 15;
        Console.WriteLine(minNumber(num1, num2));


        /*Task 2 */
        int num3 = 15;
        int num4 = -15;
        int num5 = 0;

        Console.WriteLine(displaySign(num3));
        Console.WriteLine(displaySign(num4));
        Console.WriteLine(displaySign(num5));


        /* Task 3 */
        int num6 = 9;
        int num7 = -18;
        int num8 = -10;

        ascSorting(num6, num7, num8);

        num6 = 0; num7 = -1; num8 = 4;
        ascSorting(num6, num7, num8);

        /* Task 4 */
        int[] arr1 = { 5, -2, -6, 0, -1 };
        Console.WriteLine(maxNumber(arr1));

        /* Task 6 */
        totalMinutes(5, 37);

        /* Task 7*/
        totalHours(546);

        /* Task 8*/
        string[] arr2 = { "hi", "hello", "programming", "C#", "developer" };
        fixedLength(arr2, 2);





    }
    /*Task 1 */

    static int minNumber(int num1, int num2)
    {
        if (num1 == num2)
        {
            return num1;
        }
        else if (num2 < num1)
        {
            return num2;
        }
        else
        {
            return num1;
        }


    }
    /*Task 2 */

    static char displaySign(int number)
    {
        if (number == 0)
        {
            return '0';

        }
        else if (number < 0)
        {
            return '-';
        }
        else
        {
            return '+';
        }

    }

    /* Task 3 */
    static void ascSorting(int num1, int num2, int num3)
    {
        int[] arr = { num1, num2, num3 };// 9 -18 -10 
        int[] minArray = new int[3];

        int index = 0;
        int minIndex = -1;
        int min = 100;

        while (index < minArray.Length)
        {
            for (int i = 0; i < arr.Length; i++)

            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;

                }



            }
            minArray[index] = min;
            arr[minIndex] = 999999;
            index++;
            min = 100;

        }
        foreach (int i in minArray)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

    }

    /* Task 4 */
    static int maxNumber(int[] arr)
    {
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];

            }
        }
        return max;

    }
    /* Task 6 */
    static void totalMinutes(int hours, int minutes)
    {
        int total = (hours * 60) + minutes;
        Console.WriteLine(total);
    }


    /* Task 7 */
    static void totalHours(int minutes)
    {
        int hours = minutes / 60;
        int min = minutes % 60;
        Console.WriteLine(hours);
        Console.WriteLine(min);
    }

    /* Task 8 */
    static void fixedLength(string[] arr, int length)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length == length)
            {
                Console.Write(arr[i] + " ");
            }
        }

    }



















}