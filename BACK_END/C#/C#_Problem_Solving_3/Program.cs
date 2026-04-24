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
        Console.WriteLine($"It Is repdigit n3 ?? " + repDigit(n3));
        Console.WriteLine($"It Is repdigit n4 ?? " + repDigit(n4));
        Console.WriteLine($"It Is repdigit n5 ?? " + repDigit(n5));

        /* Task 5 */
        string str1 = "the sky is blue";
        string str2 = "hello world!";
        string str3 = "a good example";

        reverseWords(str1);
        reverseWords(str2);
        reverseWords(str3);

        /* Task 6 */
        int[] arr_4 = { 1, 2, 3, 4, 5, 6, 7 };
        int[] arr_5 = { 8, 6, 33, 100 };
        int[] arr_6 = { 2, 55, 60, 97, 86 };

        Console.WriteLine(sevenBoom(arr_4));
        Console.WriteLine(sevenBoom(arr_5));
        Console.WriteLine(sevenBoom(arr_6));

        /* Task 7 */
        string str4 = "SheWalksToTheBeach";
        string str5 = "MarvinTalksTooMuch";
        string str6 = "TheGreatestUpsetInHistory";

        Console.WriteLine(insertWhitespace(str4));
        Console.WriteLine(insertWhitespace(str5));
        Console.WriteLine(insertWhitespace(str6));


        /* Task 8 */
        bool[] arr_7 = { true, false, false, true, false };
        bool[] arr_8 = { false, false, false, false };
        bool[] arr_9 = { };

        Console.WriteLine(countTrue(arr_7));
        Console.WriteLine(countTrue(arr_8));
        Console.WriteLine(countTrue(arr_9));

        /* Task 9 */
        string str7 = "hApPy";
        string str8 = "moveMENT";
        string str9 = "shOrtCAKE";

        capToFront(str7);
        capToFront(str8);
        capToFront(str9);

        /* Task 10 */

        object[] arr10 = { "rsq", "6hi", "g", "rsq6hig" };
        object[] arr11 = { 1, 1, 1, "11" };
        object[] arr12 = { 8, "thunder", true, "8thundertrue" };

        Console.WriteLine(matchLastItem(arr10));
        Console.WriteLine(matchLastItem(arr11));
        Console.WriteLine(matchLastItem(arr12));

        /* Task 11 */
        double[] arr13 = { 1, 2, double.NaN };
        double[] arr14 = {double.NaN, 1, 2, 3, 4};
        double[] arr15 = { 0, 1, 2, 3, 4 };
        Console.WriteLine(findNaN(arr13));
        Console.WriteLine(findNaN(arr14));
        Console.WriteLine(findNaN(arr15));


        /*Task 14 */
        string str10 = "Those who dare to fail miserably can achieve greatly.";
        string str11 = "Love is a serious mental disease.";

        Console.WriteLine(removeLastVowel(str10));
        Console.WriteLine(removeLastVowel(str11));

        /* Task 15 */
        int[] arr16 = { 1, 5, 9 };
        int[] arr17 = { 3, 4, 5 };
        int[] arr18 = { 2 };
        int[] arr19 = { };

        Console.WriteLine(sumOfCubes(arr16));
        Console.WriteLine(sumOfCubes(arr17));
        Console.WriteLine(sumOfCubes(arr18));
        Console.WriteLine(sumOfCubes(arr19));





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
    static bool repDigit(int n)
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


    /* Task 6 */
    static string sevenBoom(int[] arr)
    {
        string element = "";
        for (int i = 0; i < arr.Length; i++)
        {
            element = arr[i].ToString();
            for (int j = 0; j < element.Length; j++)
            {
                if (element[j] == '7')
                {
                    return "Boom !!";
                }
            }

        }
        return "There Is No 7 In The Array";

    }
    /* Task 7 */
    static string insertWhitespace(string str)
    {
        string str2 = "";
        int index = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (i <= str.Length - 2)
            {
                if ((str[i + 1] >= 'A' && str[i + 1] <= 'Z') && (str[i] >= 'a' && str[i] <= 'z'))
                {
                    str2 += str[i] + " ";
                }
                else
                {
                    str2 += str[i];
                }

            }
            else
            {
                str2 += str[i];
            }
        }
        return str2;
    }

    /* Task 8 */
    static int countTrue(bool[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i])
            {
                count++;
            }
        }
        return count;
    }
    /* Task 9*/
    static void capToFront(string str)
    {
        string str2 = "";

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'A' && str[i] <= 'Z')
            {
                str2 += str[i];
            }

        }

        for (int i = 0; i < str.Length; i++)
        {
            if (str2.Contains(str[i]))
            {
                continue;
            }
            else
            {
                str2 += str[i];
            }
        }
        Console.WriteLine(str2);
    }

    /* Task 10 */
    static bool matchLastItem(object[] arr)
    {
        string str1 = "";
        string str2 = arr[arr.Length - 1]+"";

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] is true)
            {
                str1 += arr[i] + "".ToLower();
            }
            else
            {
                str1 += arr[i] + "";
            }
        }
        Console.WriteLine(str1);
        Console.WriteLine(str2);

        
        if (str1 == str2)
        {
            return true;

        }
        return false;

    }

    /* Task 11 */
    static int findNaN(double [] arr)
    {
        int index = -1;
        for (int i = 0;i < arr.Length; i++)
        { 
        
            if (double.IsNaN(arr[i]))
            {
                index = i;
                return index;
            }

        }
        return index;
    }
    /* Task 14 */
    static string  removeLastVowel (string str)
    {
        
        string str2 = "";
        string str3 = "";
        int index = -1;
        int start = 0;



        for (int i = 0; i < str.Length; i++)
        {
            if (i == str.Length - 1 || str[i] == ' ')
            {

                for (int j = 0; j <= i; j++)
                {
                    str2 += str[j];
                    if (str[j] == 'a' || str[j] == 'o' || str[j] == 'e' || str[j] == 'i' || str[j] == 'u')
                    {
                        index = j;
                    }
                }
                for (int k = start; k < str2.Length; k++)
                {
                    if (k == index)
                    {
                        continue;
                    }
                    else
                    {
                        str3 += str2[k];
                    }
                }
                start = i + 1;
            }


            str2 = "";
            index = -1;


        }
        return str3;
    }

    /* Task 15 */
    static int sumOfCubes(int[] arr)
    {
        int sum = 0;
        int cube = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                cube *= arr[i];
            }
            sum += cube;
          
            cube = 1;

        }
       return sum;
    }


}