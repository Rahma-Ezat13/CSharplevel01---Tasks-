using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint1_Tasks.Topic3_C_Conditional_Statements
{
    internal class Topic3
    {
        public static void Run()
        {

            //Q1 Read two integers and determine whether they are equal.
            #region Q1 

                 Console.WriteLine("--Q1--------------");

            Console.WriteLine("Enter first number:");
            string num1 = Console.ReadLine();
            int num1D = int.Parse(num1);

            Console.WriteLine("Enter second number:");
            string num2 = Console.ReadLine();
            int num2D = int.Parse(num2);

            if (num1 == num2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            Console.WriteLine("\n");

            #endregion

            //Q2 Determine whether an integer is even or odd.
            #region Q2

                   Console.WriteLine("--Q2---------------");


            Console.WriteLine("Enter a number:");
            string number = Console.ReadLine();
            int numberD = int.Parse(number);

            if (numberD  % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }


                 Console.WriteLine("\n");

            #endregion

            //Q3 Determine whether a number is positive or negative.
            #region Q3  

                   Console.WriteLine("--Q3----------------");

            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            int inputD= int.Parse(input);

            if (inputD > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (inputD < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }

                  Console.WriteLine("\n");



            #endregion

            //Q4 Determine whether a year is a leap year.
            #region Q4 

                             Console.WriteLine("--Q4------------------");


            Console.WriteLine("Enter a year:");
            string year = Console.ReadLine();
            int yearD = int.Parse(year);

            if (yearD % 400 == 0 )
            {
                Console.WriteLine("Leap Year");
            }
            else if (yearD % 100 == 0)
            {
                Console.WriteLine("Not Leap Year");
            }
            else if (yearD % 4 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }



            Console.WriteLine("\n");




            #endregion

            //Q5 Read a candidate's age and determine voting eligibility.
            #region Q5

                      Console.WriteLine("--Q5-----------------");


            Console.WriteLine("Enter your age:");
            string age = Console.ReadLine();
            int ageD = int.Parse(age);

            if (ageD >= 18)
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                Console.WriteLine("Not Eligible to voting");
            }



            Console.WriteLine("\n");





            #endregion 















        }
    }
}
