using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Sprint1_Tasks.Topic2_Data_Types
{
    internal class Topic2
    {
        public static void Run()
        {

            // Q1  Read three letters and display them in reverse order.
            #region Q1

                     Console.WriteLine("--Q1-----------------");

            Console.WriteLine("Enter first letter : ");
            char first = Console.ReadLine()[0];


            Console.WriteLine("Enter second letter : ");
            char second = Console.ReadLine()[0];

            Console.WriteLine("Enter third letter: ");
            char third = Console.ReadLine()[0];

            Console.WriteLine($"{third} {second} {first}");

            Console.WriteLine("\n");


            #endregion


            // Q2  Read a number and a width, then print a descending-width triangle using that number. (important)
            #region Q2 

                       Console.WriteLine("--Q2------------------");

            Console.WriteLine("Enter a number : ");
            string number = Console.ReadLine();

            Console.WriteLine("Enter a width : ");
            string width = Console.ReadLine();
            int intwidth = int.Parse(width);

            for (int i = intwidth; i >= 1; i--) 
            {
                for (int r = 1; r <= i; r++)
                {
                    Console.Write(number);

                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");



            #endregion


            // Q3  Read a user ID and password; reject the user after three unsuccessful attempts. (important)
            #region Q3 

                         Console.WriteLine("--Q3----------------");


            string correctID = "rahma";
            string correctpassword = "1312";
            bool loggedin = false;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter your ID : ");
                string ID = Console.ReadLine();

                Console.WriteLine("Enter your password : ");
                string password = Console.ReadLine();

                bool result = ID == correctID && password == correctpassword;

                if (result == true)
                {
                    loggedin = true;
                    Console.WriteLine("welcome welcome ! ");
                    break;
                }
                else
                {
                    Console.WriteLine($"Wrong! {i}");
                }
            }
            if (loggedin == false)
            {
                Console.WriteLine("Access denied .");
            }
            Console.WriteLine("\n");

            #endregion


            //Q4  Read two numbers and an operator (+, -, *, x, or /), then display the result.
            #region Q4 

                        Console.WriteLine("--Q4---------------------");
            Console.WriteLine("Enter first number : ");
            String num1 = Console.ReadLine();
            double num1D = double.Parse(num1);

           Console.WriteLine("Enter second number : ");
            String num2 = Console.ReadLine();
            double num2D = double.Parse(num2);

            Console.WriteLine("Enter operator : ");
            string O = Console.ReadLine();


            if (O == "+")
            {
                Console.WriteLine($"Result = {num1D + num2D}");
            }
            else if (O == "-")
            {
                Console.WriteLine($"Result  = {num1D - num2D}");
            }
            else if (O == "*")
            {
                Console.WriteLine($"Result  ={num1D * num2D} ");
            }
            else if (O == "/")
            {
                Console.WriteLine($"Result  = {num1D / num2D}");
            }
            else
            {
                Console.WriteLine("your enter is incorrect ");
            }

            Console.WriteLine("\n");
            #endregion


            //Q5  Read a circle radius and calculate its perimeter and area.
            #region Q5 

                        Console.WriteLine("--Q5------------------");

            Console.WriteLine("To calculate perimeter and area for circle");
            Console.WriteLine("Enter number for circle radius :");

            string radius = Console.ReadLine();
            double radiusD = double.Parse(radius);

            Console.WriteLine($"the perimeter = {2 * (22.5 / 7) * radiusD}");
            Console.WriteLine($"the area = {(22.5/7)*radiusD*radiusD}");

            Console.WriteLine("\n");


            #endregion


            //Q6  Display values of  x = y^2 + 2y + 1  for integer y from -5 through 5.
            #region Q6

                       Console.WriteLine("--Q6---------------");
            Console.WriteLine("press enter to watch this operation  X = [ y^2 + 2y + 1  ]");
            Console.ReadLine(); 

            for (int y=-5; y<=5; y++)
            {
                Console.WriteLine($" when\t Y={y}\t X= {y ^ 2 + 2 * y + 1}" +
                    $"");

            }

             Console.WriteLine("\n");



            #endregion


            //Q7  Read distance and elapsed hours, minutes, and seconds; display speed in m/s, km/h, an  mph.
            #region Q7

                     Console.WriteLine("--Q7----------------");
            Console.WriteLine("TO calculate speed for you please,");
            Console.WriteLine("enter distance in meters : ");
            
            string distance =  Console.ReadLine();
            double distanceD = double.Parse(distance);

            Console.WriteLine("Enter hours : ");
            string hour = Console.ReadLine();
            double hourD = double.Parse(hour);
           
            Console.WriteLine("Enter minutes : ");
            string min = Console.ReadLine();
            double minutesD = double.Parse(min);

            Console.WriteLine("Enter seconds : ");
            string sec = Console.ReadLine();
            double secondD = double.Parse(sec);

            Console.WriteLine("\n");
            Console.WriteLine($"Speed in m/s = [ distance/total second ] = {distanceD / (hourD * 3600) + (minutesD * 60) + (secondD)}");

            Console.WriteLine($"Speed in km/h = [ m/s * 3.6 ] = {(distanceD / (hourD * 3600) + (minutesD * 60) + (secondD)) * 3.6} ");

            Console.WriteLine($"Speed in mph = [ m/s * 2.23694 ] = {(distanceD / (hourD * 3600) + (minutesD * 60) + (secondD)) * 2.23694} ");

            Console.WriteLine("\n");


            #endregion


            //Q8  Read a sphere radius and calculate its surface area and volume.
            #region Q8 

            Console.WriteLine("--Q8--------------");
            Console.WriteLine("TO calculate surface area and volume for Sphere please ");
            Console.WriteLine("enter a sphere radius number : ");
            string radiusnum = Console.ReadLine();
            double radiusnumD = double.Parse(radiusnum);

            Console.WriteLine($"the Surface Area (A) = [ 4 * 3.14 * (r*r) ] = {4 * 3.14 *( radiusnumD * radiusnumD)}");
            Console.WriteLine($"the volume = [ 4/3 * 3.14 * (r*r*r) ] = {(4.0 / 3) * 3.14 * (radiusnumD * radiusnumD * radiusnumD)}");

            Console.WriteLine("\n");


            #endregion


            //Q9  Read a character and classify it as a vowel, digit, or other symbol.
            #region Q9 

                  Console.WriteLine("--Q9----------------");
            Console.WriteLine("Enter one character : ");
            char character =Convert.ToChar( Console.ReadLine());

            character = char.ToLower(character);


            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            {
                Console.WriteLine("this character is a Vowel ");
            }

            else if (character <= 9 && character >= 0)
            {
                Console.WriteLine("this character is a Digit ");
            }

            else
            {
                Console.WriteLine("this character isn't a vowel or digit \n this is Other symbol ");
            }

            Console.WriteLine("\n");

            #endregion


            //Q10 Read two numbers and return true when both have the same parity (both even or both odd).
            #region Q10 

                  Console.WriteLine("--Q10----------------");
            Console.WriteLine("Enter first number :");
            string firstnum = Console.ReadLine();
            double firstnumD = double.Parse(firstnum);

            Console.WriteLine("Enter second number :");
            string secondnum = Console.ReadLine();
            double secondnumD = double.Parse(secondnum);

            //num % 2 == 0 this even 
           // num % 2 != 0 this odd 

            if (firstnumD % 2 == 0 && secondnumD % 2 == 0 || firstnumD % 2 != 0 && secondnumD % 2 != 0)
            {
                Console.WriteLine("true");

            }

            else 
            {
                Console.WriteLine("false  (both of them don't have the same parity) ");

            }


            Console.WriteLine("\n");


            #endregion
























































        }
    }
}
