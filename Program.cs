namespace Sprint1.Tasks
{
    internal class Program
    {
        static void Main(string[] args)
            {

            // Topics 1,2,3,4,5

            #region code for choose a Topic to reveiw .

            Console.WriteLine("Choose a topic for review :");
                Console.WriteLine("1 - C Basic Declarations");
                Console.WriteLine("2 - Data Types");
                Console.WriteLine("3 - Conditional Statements");
                Console.WriteLine("4 - For Loop");
                Console.WriteLine("5 - String");

                string choice = Console.ReadLine();
             

                if (choice == "1")
                    Sprint1_Tasks.Topic1_C_BasicDeclarations.Topic1.Run();
                else if (choice == "2")
                    Sprint1_Tasks.Topic2_Data_Types.Topic2.Run();
                else if (choice == "3")
                    Sprint1_Tasks.Topic3_C_Conditional_Statements.Topic3.Run();
                else if (choice == "4")
                    Sprint1_Tasks.Topic4_For_Loop.Topic4.Run();
                else if (choice == "5")
                    Sprint1_Tasks.Topic5_String.Topic5.Run();
                else
                    Console.WriteLine("Invalid choice");


                    Console.ReadLine();

            #endregion


        }
    }
}
