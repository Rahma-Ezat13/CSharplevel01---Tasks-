using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Sprint1_Tasks.Topic1_C_BasicDeclarations
{
    internal class Topic1
    {
        public static void Run()
        {
            //Q1 Display a greeting and a person's name on separate lines.
            #region Q1

                      Console.WriteLine("--Q1----------------------");

            Console.WriteLine("welcome, please enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello\n{name}");
            Console.WriteLine("\n");
            #endregion


            //Q2 Read or define two numbers and print their sum.
            #region Q2

                      Console.WriteLine("--Q2--------------------");
           
            int X = 2;
            int Y = 10;
            Console.WriteLine($"(2+10)= {X + Y}");
            Console.WriteLine("\n");
            #endregion


            //Q3 Calculate and display the quotient of two numbers. 
            #region Q3

                      Console.WriteLine("--Q3----------------------");

            float R = 5;
            float v = 2;
            Console.WriteLine($"(5/2)={R / v}");
            Console.WriteLine("\n");

            #endregion


            //Q4 [number 11 in file] Print Age Message Read an age and include it in a short message.
            #region Q4 

                        Console.WriteLine("--Q4----------------");

            Console.WriteLine("Enter your age :");
            string age = Console.ReadLine();
            Console.WriteLine($"you're {age} years old ");
            Console.WriteLine("\n"); 

            #endregion


            //Q5 Exchange the values of two numbers and show the values after swapping.
            #region Q5

            Console.WriteLine("--Q5----------------");

            int firstnumber = 1;
            int secondnumber = 2;
            Console.WriteLine($"firstnumber={firstnumber}, secondnumber={secondnumber} ");

            Console.WriteLine("after Swapping : ");
            firstnumber = 10;
            secondnumber = 20;
            Console.WriteLine($"firstnumber={firstnumber}, secondnumber={secondnumber}");
            Console.WriteLine("\n");

            #endregion


            //Q6 Accept three numbers and print their product. 
            #region Q6 

                              Console.WriteLine("--Q6-----------------");

            Console.WriteLine("Enter first number : ");
            string number1 = Console.ReadLine();
            int intnumber1 = int.Parse(number1);

            Console.WriteLine("Enter second number : ");
            string number2 = Console.ReadLine();
            int intnumber2 = int.Parse(number2);

            Console.WriteLine("Enter third number : ");
            string number3 = Console.ReadLine();
            int intnumber3 = int.Parse(number3);

            Console.WriteLine($"the product of those numbers = {intnumber1 * intnumber2 * intnumber3}");

            Console.WriteLine("\n");

            #endregion


            //Q7 Arithmetic Operation For two input numbers.
            #region Q7

                        Console.WriteLine("--Q7------------------");

            Console.WriteLine("Enter first number: ");
            string num1 = Console.ReadLine();
            double num1double = double.Parse(num1);

            Console.WriteLine("Enter second number : ");
            string num2 = Console.ReadLine();
            double num2double = double.Parse(num2);

            Console.WriteLine("the Arithmetic Operation for those numbers is : ");
            Console.WriteLine($"thier Addition = {num1double + num2double} ");
            Console.WriteLine($"thier Subtraction = {num1double - num2double} ");
            Console.WriteLine($"thier Multiplication = {num1double * num2double}");
            Console.WriteLine($"thier Division = {num1double / num2double}");
            Console.WriteLine($"thier Modulus = {num1double % num2double} ");

            Console.WriteLine("\n");

            #endregion


            //Q8 Print the multiplication table from 0 through 10 for a user-provided number. 
            #region Q8 

                      Console.WriteLine("--Q8-------------------");

            Console.WriteLine("Enter a number : ");
            string usernumber = Console.ReadLine();
            int usernumberint = int.Parse(usernumber);

            Console.WriteLine("the multiplication table for your number is : ");
            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine($"{usernumberint}*{i} = {usernumberint * i}");
            }

            Console.WriteLine("\n");


            #endregion


            //Q9 Accept four numbers and calculate their average.
            #region Q9 

                       Console.WriteLine("--Q9-----------------------");

            Console.WriteLine("Enter first number : ");
            string A = Console.ReadLine();
            double Adouble = double.Parse(A);


            Console.WriteLine("Enter second number : ");
            string B = Console.ReadLine();
            double Bdouble = double.Parse(B);

            Console.WriteLine("Enter third number : ");
            string C = Console.ReadLine();
            double Cdouble = double.Parse(C);


            Console.WriteLine("Enter fourth number : ");
            string D = Console.ReadLine();
            double Ddouble = double.Parse(D);

            Console.WriteLine($"The Average for those numbers is : {(Adouble + Bdouble + Cdouble + Ddouble) / 4}");
            Console.WriteLine("\n");

            #endregion


           // Q10 Specified Formula with Three Numbers
          // For x, y, and z, calculate (x + y) * z and x * y + y * z.

            #region Q10

                       Console.WriteLine("--Q10-------------------");

            Console.WriteLine("K=2 , L=4 and  M=6 ");
            Console.WriteLine("\n");

            double K = 2;
            double L = 4;
            double M = 6;

            Console.WriteLine($" ( K + L )*M = {(K + L) * M} ");
            Console.WriteLine($" ( K * L + L * M ) = {K * L + L * M}");
            Console.WriteLine("\n");


            #endregion

















        }

    }
}
