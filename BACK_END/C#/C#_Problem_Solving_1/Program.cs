using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main (string[] args)
    {
        /* Task 1*/

        Console.WriteLine("Minutes To Seconds -> "+ ConvertToSec(5));

        /* Task 2 */
        Console.WriteLine("Increment By One -> "+ IncrementByOne(5));

        /* Task 3 */
        int[] arr = { 90, 67, 45, 124 };
        Console.WriteLine("First Element In Only Numbers Array -> "+OnlyNumbersArray(arr));

        /* Task 4 */
        Console.WriteLine("The Area Of Rectangle -> "+AreaOfRectangle(5,4));

        /* Task 5 */
        int[] arr_2 = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };
        int[] evenArray = EvenNumberEvenIndex(arr_2);

        Console.Write("[  ");
        foreach (int i in evenArray) {
            Console.Write(i+" ");
        }
        Console.Write(" ]");
        Console.WriteLine();

        /* Task 6 */
        string[] arr_3 = { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" };
        string[] evenIndexOddLengthArray = evenIndexOddLength(arr_3);


        Console.Write("[  ");
        foreach (string i in evenIndexOddLengthArray)
        {
            Console.Write(i + " ");
        }
        Console.Write(" ]");
        Console.WriteLine();






































    }
    /* Task 1*/
        static int ConvertToSec(int minutes)
    {
        return minutes * 60;
    }

    /* Task 2 */
    static int IncrementByOne(int number)
    {
        return number + 1;
    }

    /* Task 3 */

    static int OnlyNumbersArray(int[] arr)
    {
        return arr[0];
    }

    /* Task 4 */
    static double AreaOfRectangle(double width , double height)
    {
        return width* height;
    }
    /* Task 5 */
    static int []  EvenNumberEvenIndex(int[] arr)
    {
        int evenCount = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0 && i %2 ==0)
            {
                evenCount++;
            }
        }
        int[] evenArray = new int[evenCount];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0 && i % 2 == 0)
            {
                evenArray[index] = arr[i];
                index++;
            }
        }
        return evenArray;
    }

    /* Task 6  */
    static string[] evenIndexOddLength (string[] arr)
    {
        int evenIndexOddLengthCount = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length % 2 != 0 && i % 2 == 0)
            {
                evenIndexOddLengthCount++;
            }
        }
        string[] evenIndexOddLength = new string[evenIndexOddLengthCount];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length % 2 != 0 && i % 2 == 0)
            {
                evenIndexOddLength[index] = arr[i];
                index++;
            }
        }
        return evenIndexOddLength;
    }

    /* Task  7 */
    static int[] powerElementIndex (int[] arr)
    {

    }

















}
