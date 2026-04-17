using System;
public class Program
{
    public static void Main()
    {
        /* Task 1*/

        //int[] numbers = { 10, 15, 22, 7, 8, 13, 30 };
        //int evenCount = 0;
        //int oddCount = 0;
        //int sum = 0;
        //double avg = 0;
        //int countFiveOne = 0;
        //int countFiveTwo = 0;


        //int[] filteresArrayOne =new int[numbers.Length];
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i] % 2 == 0)
        //    {
        //        evenCount++;


        //    }
        //    else
        //    {
        //        oddCount++;
        //    }
        //    sum += numbers[i];



        //}
        //avg = sum / numbers.Length;


        //Console.WriteLine($"The Number Of Even = {evenCount}");
        //Console.WriteLine($"The Number Of Odd = {oddCount}");
        //Console.WriteLine($"The Sum Of All Numbers = {sum}");
        //Console.WriteLine($"The Average Of Numbers ={avg}");

        //for (int i = 0; i < numbers.Length; i++)
        //{

        //    if (numbers[i] > avg)
        //    {
        //        filteresArrayOne[countFiveOne] = numbers[i];
        //        countFiveOne++;
        //    }


        //}
        //for (int i = 0; i < filteresArrayOne.Length; i++)
        //{
        //    if (filteresArrayOne[i] !=0)
        //    Console.WriteLine(filteresArrayOne[i]);


        //}
        ///* Another soultion to the filtered array  */
        //for (int i = 0; i < numbers.Length; i++)
        //{

        //    if (numbers[i] > avg)
        //    {

        //        countFiveTwo ++;
        //    }


        //}
        //int counter = 0;
        //int [] filteredArrayTwo = new int[countFiveTwo];
        //for (int i = 0;i < numbers.Length; i++)
        //{
        //    if (numbers[i] > avg)
        //    {

        //        filteredArrayTwo[counter]=numbers[i];
        //        counter++;
        //    }
        //}
        //for (int i = 0; i < filteredArrayTwo.Length; i++)
        //{

        //        Console.WriteLine(filteredArrayTwo[i]);


        //}

        //---------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------


        ///* Task 2*/

        //int[] maxArray = {12, 45, 7, 23, 56, 19};
        //int maxNumber = 0;

        //for (int i = 0; i < maxArray.Length; i++) {


        //    if (maxArray[i] > maxNumber) { 
        //        maxNumber = maxArray[i]; 
        //    }

        //}
        //Console.WriteLine($"The Maximum Number = {maxNumber}");



        //---------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------

        /* Task 3 */
        //string tenNumbers = "";
        //string evenNumbers = "";
        //for (int i = 1; i <= 10; i++)
        //{
        //    tenNumbers += i+" ";
        //    if (i % 2 == 0) {
        //        evenNumbers += i+" ";
        //    }

        //}
        //Console.WriteLine($"Numbers From ( 1 -> 10) {tenNumbers}");
        //Console.WriteLine($"Even Numbers {evenNumbers}");



        //---------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------

        /* Task 4 */
        //Console.WriteLine("Please Enter Your Full Name");
        //string fullName = Console.ReadLine();

        //Console.WriteLine("Please Enter Your Age");
        //int age =Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Please Enter Your Height");
        //double height = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Are You Employeed ??");
        //bool isEmployeed =Convert.ToBoolean(Console.ReadLine());

        //Console.WriteLine($"Name : {fullName}");
        //Console.WriteLine($"Age : {age}");
        //Console.WriteLine($"Height : {height}");
        //Console.WriteLine($"is Employeed ? : {isEmployeed}");


        //---------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------


        ///* Task 5 */
        //Console.WriteLine("Please Enter Your Name");
        //string userName = Console.ReadLine();

        //Console.WriteLine(userName.ToUpper());
        //Console.WriteLine(userName.ToLower());

        //Console.WriteLine("Please Enter Your Age");
        //int age = Convert.ToInt32((string)Console.ReadLine());
        //Console.WriteLine("User Name " + userName);
        //Console.WriteLine("Age " + age);

        //Console.WriteLine(userName[0]);
        //Console.Write("User Name : " + userName + "\nAge :" + age+"\n");
        //Console.WriteLine(userName[userName.Length - 1]);
        //Console.WriteLine("User Name\t" + userName);


        //---------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------

        /* Task 6 */
        //for (int i = 1; i <= 10; i++)
        //{
        //    if (i % 3 == 0)
        //        continue;

        //    if (i == 8)
        //        break;

        //    Console.WriteLine(i);
        //}



    }
}