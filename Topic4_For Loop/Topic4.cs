using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint1_Tasks.Topic4_For_Loop
{
    internal class Topic4
    {
        public static void Run()
        {
            // Q1  Display the first 10 natural numbers.
            #region Q1 

            Console.WriteLine("--Q1-----------------");

            int x = 1;
            do
            {
                Console.WriteLine(x++);

            }
            while (x <= 10);

            Console.WriteLine("\n");

            #endregion

            // Q2  Find the sum of the first 10 natural numbers.
            #region Q2

            Console.WriteLine("--Q2-----------------");

            int number = 1;
            int sum = 0;

            do
            {
                sum = sum + number;
                number++;
            }
            while (number <= 10);

            Console.WriteLine($"their sum = {sum}");

            Console.WriteLine("\n");

            #endregion

            //Q3  Display the first n natural numbers and their sum
            #region Q3 

                        Console.WriteLine("--Q3----------------");

            Console.WriteLine("Enter n:");
            string n = Console.ReadLine();
            int nD = int.Parse(n);
            Console.WriteLine("\n");
            Console.WriteLine("The sum for the first (n) natural you just entered : ");
            int thesum = 0;

            for (int i = 1; i <= nD; i++)
            {
                Console.WriteLine(i);
                thesum= thesum + i;
            }

            Console.WriteLine($"Their Sum is = {thesum} ");

            Console.WriteLine("\n");





            #endregion

            //Q4  Read 10 numbers and calculate their sum and average.  //important
            #region Q4 

                        Console.WriteLine("--Q4----------------");

            Console.WriteLine("Enter 10 Numbers to calculate thier sum and average ");
            int sumN = 0;

            for (int i = 1; i <= 10; i++)
            { 
                Console.WriteLine("Enter number :");
                string num = Console.ReadLine();
                int numi = int.Parse(num);

                sumN = sumN + numi;
            }

            // average = sum/n
            double average = sumN / 10.0; 

            Console.WriteLine($"Sum = " + sumN);
            Console.WriteLine($"Average = " + average);


            Console.WriteLine("\n");

            #endregion

            //Q5 Display the cubes of integers from 1 through a supplied limit.  //important 
            #region Q5

                   Console.WriteLine("--Q5----------------");

            Console.WriteLine("Enter limit: ");
            string limit= Console.ReadLine();
            int limitint = int.Parse(limit);
            Console.WriteLine("\n");
            Console.WriteLine("The cubes of integers from 1 to the limit you just entered is : ");

            for (int i = 1; i <= limitint; i++)
            {
                Console.WriteLine(i * i * i);
            }


            Console.WriteLine("\n");


            #endregion


























        }
    }
}
