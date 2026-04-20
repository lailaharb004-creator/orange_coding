using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {

        /* Task 1 */
        int n1 = 10;
        Console.WriteLine($"The Adding of {n1} to The Number = " + addNToNumber(n1));

        /* Task 2 */
        string n2 = "00120300";
        deleteZeros(n2);


        /* Task 3 */
        int[] arr1 = { 10, 40, 30, 20, 50 };
        Console.WriteLine("The Second Largest -> " + secondLargest(arr1));
        int[] arr2 = { 25, 143, 89, 13, 105 };
        Console.WriteLine("The Second Largest -> " + secondLargest(arr2));
        int[] arr3 = { 54, 23, 11, 17, 10 };
        Console.WriteLine("The Second Largest -> " + secondLargest(arr3));

        /* Task  4 */
        int n3 = 66;
        int n4 = 0;
        int n5 = -11;
        Console.WriteLine($"It Is repdigit n3 ?? " + repdigit(n3));
        Console.WriteLine($"It Is repdigit n4 ?? " + repdigit(n4));
        Console.WriteLine($"It Is repdigit n5 ?? " + repdigit(n5));

        /* Task 5 */
        string str1 = "the sky is blue";
        string str2 = "hello world!";
        string str3 = "a good example";

        reverseWords(str1);
        reverseWords(str2);
        reverseWords(str3);













    }

    /* Task 1 */
    static int addNToNumber(int n)
    {
        int number = 20;
        return number + n;
    }

    static void deleteZeros(string number)
    {
        int startIndex = 0;
        int endIndex = number.Length - 1;


        while (number[startIndex] == '0')
        {
            startIndex++;
        }
        while (number[endIndex] == '0')
        {
            endIndex--;
        }

        Console.Write("[  ");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(number[i] + " ");
        }
        Console.Write(" ]");
        Console.WriteLine();
    }


    /* Task 3 */
    static int secondLargest(int[] arr)
    {
        int maxOne = 0;
        int maxTwo = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > maxOne)
            {
                maxOne = arr[i];
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > maxTwo && arr[i] < maxOne)
            {
                maxTwo = arr[i];
            }


        }
        return maxTwo;
    }

    /* Task 4 */
    static bool repdigit(int n)
    {

        if (n >= 0)
        {
            string number = n.ToString();
            for (int i = 1; i < number.Length; i++)
            {
                if (number[i] != number[0])
                {
                    return false;
                }


            }
            return true;
        }
        return false;
    }
    /* Task 5 */
    static void reverseWords(string str)
    {
        string str2 = "";
        string str3 = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (str[i] != ' ')
            {
                str2 += str[i];
            }

            if (str[i] == ' ' || i == 0)
            {
                for (int j = str2.Length - 1; j >= 0; j--)
                {
                    str3 += str2[j];
                }

                str3 += " ";
                str2 = "";
            }
        }
        Console.WriteLine(str3);
    }











}