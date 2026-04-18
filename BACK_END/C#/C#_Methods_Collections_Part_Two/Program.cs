using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

public class Program {

    public static void Main(string[] args) {
        //---------------
        // Section One //
        //---------------

        /* Task 1 */
        List<int> FullNumbersList = new List<int> { 2,6,4,9,45,8};
        List <int> EvenNumbersList = FullNumbersList.Where(n => n % 2 == 0).ToList();

        Console.Write("{ ");
        foreach (int even in EvenNumbersList) {

            Console.Write(even + " ");
        
        }
        Console.Write(" }");
        Console.WriteLine();

        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        /* Task 2 */
        List<int> dublicateNumbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        List<int> cleanNumbers     = dublicateNumbers.Distinct().ToList();

        Console.Write("{  ");
        foreach (int clean in cleanNumbers) { 
        
            Console.Write (clean+" ");
        }
        Console.Write(" }");
        Console.WriteLine();


        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        /* Task 3 */
        List<int> MaximumNumbersList = new List<int> { 2, 6, 4, 9, 45, 8 };
        int maxNumber = MaximumNumbersList.Max();
        Console.WriteLine("Maximum Number Is "+ maxNumber);

        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------
        /* Task 4 */
        List<int> reverseNumbersList = new List<int> { 2, 6, 4, 9, 45, 8 };
        reverseNumbersList.Reverse();
        Console.Write("{  ");
        foreach (int reverse in reverseNumbersList) {
            Console.Write(reverse+" ");
        
        }
        Console.Write(" }");
        Console.WriteLine();


        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        /* Task 5 */
        List<int> countNumbersList = new List<int> { 2, 6, 4, 9, 45, 8 };
        int greaterThan5=countNumbersList.Count(n => n >5);
        Console.WriteLine("The Count Of Numbers Greater Then 5 => "+greaterThan5);


        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        //---------------
        // Section Two //
        //---------------

        /* Task 6 */

        Dictionary <string,int> studentsScores=new Dictionary<string, int> 
        {
            {"Ali",80 },
            {"Ahmad",70 },
            {"Majid",90 },
            {"Zayen",56 },
            {"Waleed",63 },
            {"Raed",24 },
            {"Hani" ,34},
            {"Gameel",12 },
            {"Tareq",88 }

        };

        foreach (var student in studentsScores) { 
            
            if (student.Value > 80)
            {
                Console.WriteLine("Student: "+student.Key+ " Score => "+  student.Value);
            }
        
        
        }

        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        /* Task 7 */
        //Console.WriteLine("Please Enter Name");
        //string enteredName = Console.ReadLine();

        //if (studentsScores.ContainsKey(enteredName))
        //{
        //    Console.WriteLine(studentsScores[enteredName]);
        //}
        //else
        //{
        //    Console.WriteLine("Not Found ");
        //}

        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        /* Task 8 */

        int scoresSum = studentsScores.Sum(s => s.Value);
        Console.WriteLine("The Summation Of All Scores => "+scoresSum);

        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------
        /* Task 9 */
        foreach (var student in studentsScores)
        {

            if (student.Value < 50)
            {
                studentsScores.Remove(student.Key);
            }


        }
        foreach (var student in studentsScores)
        {  
                Console.WriteLine("Student: " + student.Key + " Score => " + student.Value);   
        }

        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        /* Task 10 */
        int maxScore = 0;
        foreach (var student in studentsScores)
        {

            if (student.Value >maxScore)
            {
                maxScore = student.Value;
            }


        }
        Console.WriteLine("The Maximum Score => "+maxScore);


        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        //----------------
        // Section Three //
        //----------------

        
        LinkedList <string> testLinkedList= new LinkedList<string>();
        /* Task 11 */
        testLinkedList.AddFirst("One");
        testLinkedList.AddLast("Three");
        /* Task 13 */
        var beforeNode = testLinkedList.Find("Three");
        var afterNode  = testLinkedList.Find("Three");

        testLinkedList.AddBefore(beforeNode, "Two");
        testLinkedList.AddAfter(afterNode, "Four");

        /* Task 14+ */
        foreach ( var node in testLinkedList)
        {
            Console.Write("[ "+node+" ]"+" ");
        }
        Console.WriteLine();
        /* Task 15 */
        Console.WriteLine("First In LinkedList "+testLinkedList.First.Value);
        Console.WriteLine("Last In LinkedList  "+testLinkedList.Last.Value);

        /* Task 12 */
        var middleNodeOne = testLinkedList.Find("Two");
        var middleNodeTwo = testLinkedList.Find("Three");

        testLinkedList.Remove(middleNodeOne);
        testLinkedList.Remove(middleNodeTwo);

        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        //---------------
        // Section four //
        //---------------

        /* Task 16 */

        int[] arr = { 24, 13, 7, 45, 18, 32, 9, 27, 50, 6 };
        int[] oddNumbersArray = arr.Where(x => x % 2 != 0).ToArray();

        Console.Write("[  ");
        foreach (int odd in oddNumbersArray)
        {
            Console.Write(odd + " ");
        }
        Console.Write(" ]");
        Console.WriteLine();


        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        /* Task 17 */

        int[] multiplyByTwoArray=arr.Select(x=>x*2).ToArray();
        Console.Write("[  ");
        foreach (int number in multiplyByTwoArray)
        {
            Console.Write(number + " ");
        }
        Console.Write(" ]");
        Console.WriteLine();

        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        /* Task 18 */

        int[] descSortingArray =arr.OrderByDescending(x=>x).ToArray();
        Console.Write("[  ");
        foreach (int number in descSortingArray)
        {
            Console.Write(number + " ");
        }
        Console.Write(" ]");
        Console.WriteLine();

        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        /* Task 19 */

        int firstgreaterThan100 = arr.FirstOrDefault(x => x > 100);
        Console.WriteLine("First Number Greater Than 100 => "+ firstgreaterThan100);


        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        /* Task 20 */
        
        double avg =arr.Average(x=>x);
        Console.WriteLine("The Average => "+avg);

        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        //---------------
        // Section five //
        //---------------

        /* Task 21 */
        /* Find common numbers between two lists*/
        List <int> firstList = new List<int> { 24, 13, 7, 45, 18, 32, 9, 27, 50, 6 };
        List <int> secondList = new List<int> { 80, 90, 24, 18, 25, 60, 90, 15, 10, 45 };

        Console.Write("[  ");
        foreach (int number in firstList)
        {

            if (secondList.Contains(number)){
                Console.Write(number+" ");
            }
        }
        Console.Write(" ]");
        Console.WriteLine();

        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        /* Task 22 */
        List<int> firstListToCombine = new List<int> { 1, 2, 3 };
        List<int> secondListToCombine = new List<int> { 4, 5, 6, 7 };

        List<int> combinedList=firstListToCombine .Concat(secondListToCombine).ToList();
        Console.Write("[  ");
        foreach (int combined in combinedList)
        {

            Console.Write(combined + " ");
        }
        Console.Write(" ]");
        Console.WriteLine();

        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        /* Task 23 */
        List<int> toMakeuniqueList = new List<int> { 80, 90, 24, 18, 25, 60, 90, 15, 10, 45 };
        List<int> uniqueList =toMakeuniqueList.Distinct().ToList();

        Console.Write("[  ");
        foreach (int unique in uniqueList)
        {

            Console.Write(unique + " ");
        }
        Console.Write(" ]");
        Console.WriteLine();

        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        /* Task 24 */
        Dictionary<string, int> toList = new Dictionary<string, int>
        {
            {"one",1 }, {"two", 2 } ,  {"three", 3 }

        };
        List<int> fromDictionary = new List<int>();
        foreach (string key in toList.Keys)
        {
            fromDictionary.Add(toList[key]);


        }
        Console.Write("[  ");
        foreach (var item in fromDictionary)
        {
            Console.Write(item+ " ");
        }
        Console.Write(" ]");
        Console.WriteLine();



        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        /* Task 25 */
        Dictionary<string, int> greaterThan100DictBefore = new Dictionary<string, int>
        {
            {"one", 120},
            {"two", 90},
            {"three", 150},
            {"four", 80},
            {"five", 100}
        };

        Dictionary<string, int> greaterThan100DictAfter = greaterThan100DictBefore.Where(x => x.Value > 100).ToDictionary();
        Console.Write("[  ");
        foreach (var item in greaterThan100DictAfter)
        {
            Console.Write(item + " ");
        }
        Console.Write(" ]");
        Console.WriteLine();


        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------
       








    }
































}
