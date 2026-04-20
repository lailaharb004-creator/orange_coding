using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        /* Task 1 */
        string d1 = "June 14, 2019";
        string d2 = "June 20, 2019";

        DateTime day1 = DateTime.Parse(d1);
        DateTime day2 = DateTime.Parse(d2);

        Console.WriteLine("The Diffrence between " + day1.ToString("MMMM dd ,yyyy") + " And " + day2.ToString("MMMM dd ,yyyy") + "  -> " + getDays(day1, day2));

        d1 = "December 29, 2018";
        d2 = "January 1, 2019";

        day1 = DateTime.Parse(d1);
        day2 = DateTime.Parse(d2);

        Console.WriteLine("The Diffrence between " + day1.ToString("MMMM dd ,yyyy") + " And " + day2.ToString("MMMM dd ,yyyy") + "  -> " + getDays(day1, day2));


        /* Task 2 */
        string[] arr_1 = { "1a", "a", "2b", "b" };
        string[] arr_2 = { "abc", "abc10" };
        string[] onlyNumbersArray = onlyNumbers(arr_1);
        onlyNumbersArray = onlyNumbers(arr_2);
        Console.Write("[  ");
        foreach (string i in onlyNumbersArray)
        {
            Console.Write(i + " ");
        }
        Console.Write(" ]");
        Console.WriteLine();


        /* Task 3 */
        string str = "One two three four six seven nine";
        reverseOddLength(str);



        /* Task 4 */

        Int64 number = 98140723568910;
        Console.Write(pandigitalNumber(number));
        








    }
    /* Task 1 */
    static int getDays(DateTime day1, DateTime day2)
    {
        TimeSpan d = day2 - day1;
        return d.Days;
    }

    /* Task 2 */
    static string[] onlyNumbers(string[] arr)
    {

        string[] newArray = new string[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] >= '0' && arr[i][j] <= '9')
                {
                    newArray[i] = arr[i];
                }
            }


        }
        return newArray;
    }
    /* Task 3 */
    static void reverseOddLength(string str)
    {
        /* 
        i=0 
        str2 =O 
        i=1 
        str2 =On
        i=2 
        str2 =One 
        i=3 
        str[3]=" "
        str2.length ==3
        enO 
        str3 =eno+arr[i]=arr[3]=" " -> eno 
        i=4 
        str2=t
        i=5 
        str2=tw
        i=6 
        str2=two 
        i=7 
        str[7]=" "
        
        str2.length=3 
        owt
        
        str3 =eno owt+arr[i]=arr[7]=" " -> eno owt 
        
        i=8 
        str2 =t
        
        i=9 
        str2 =th
        i=10 
        str2=thr
        i=11 
        str2=thre
        i=12 
        str2=three
        
        i=13
        str[i] =str[13]=" "
        
        str2.length=5 
        eerht
        
        str3 = eno owt eerht 
        
        i=14 
        str2=f
        i=15 
        str2=fo
        i=16 
        str2=fou
        i=17  = str.length -1 
        str2=four
        length =4 
        four 
        str3 =eno owt eerht four 
    
        
        
        */


        string str2 = "";
        string str3 = "";


        for (int i = 0; i <= str.Length; i++)
        {
            if (i < str.Length && str[i] != ' ')
            {
                str2 += str[i];
            }
            else
            {

                if (str2.Length % 2 != 0)
                {
                    for (int j = str2.Length - 1; j >= 0; j--)
                    {
                        str3 += str2[j];
                    }


                }
                else
                {
                    str3 += str2;

                }
                str3 += " ";
                str2 = "";

            }

        }

        Console.WriteLine(str3);
    }
   


    /* Task 4 */
    static bool pandigitalNumber(Int64 n)
    {   string number = n.ToString();
        int[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        bool[] isPandigitalNumberArray = new bool[10];
        

        for (int i = 0; i < number.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] == number[i])
                {
                    isPandigitalNumberArray[j] = true;

                }



            }
        }

        foreach (bool i in isPandigitalNumberArray)
        {
            if (!i)
            {
                return false;
                
            }
        }
        return true;




    }


}