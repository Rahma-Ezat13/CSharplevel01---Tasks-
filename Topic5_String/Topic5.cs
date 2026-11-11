using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint1_Tasks.Topic5_String
{
    internal class Topic5
    {
        public static void Run()
        {

            //Q1  Read a string and print it.
            #region Q1 

            Console.WriteLine("--Q1-----------------");

            Console.WriteLine("Enter a string : ");
            string text = Console.ReadLine();

            Console.WriteLine($"your text is : {text}");

            Console.WriteLine("\n");

            #endregion

            //Q2 Find a string's length without using a library length function.
            #region Q2

            Console.WriteLine("--Q2----------------");

            Console.WriteLine("Enter a string:");
            string letter = Console.ReadLine();

            int count = 0;

            foreach (char c in letter)
            {
                count++;
            }

            Console.WriteLine($"String length = {count} ");

            Console.WriteLine("\n");




            #endregion

            //Q3  Print the individual characters in a string.
            #region Q3 

            Console.WriteLine("--Q3----------------");


            Console.WriteLine("Enter a string:");
            string word = Console.ReadLine();

            //i [<] word.length not [<=] because index start from 0 & length start from 1 .

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);

            }

            Console.WriteLine("\n");

            #endregion

            //Q4 Print the characters of a string in reverse order.
            #region Q4 

            Console.WriteLine("--Q4----------------");

            Console.WriteLine("Enter a string:");
            string w = Console.ReadLine();

            for (int i = w.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(w[i]);
            }

            Console.WriteLine("\n");

            #endregion

            //Q5 Count the words in a string.    //important 
            #region Q5

            Console.WriteLine("--Q5----------------");

            Console.WriteLine("Enter a sentence :");
            string sentence = Console.ReadLine();

            int countS = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ' && (i == 0 || sentence[i - 1] == ' '))
                {
                    countS++;
                }
            }

            Console.WriteLine($"The Number of words =  {countS}") ;


            Console.WriteLine("\n");

            #endregion




















        }
    }
}
