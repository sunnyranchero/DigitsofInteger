namespace Assign2_3._28DigitsofInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Build a program that separates out the user input of 5 characters into indivdual numbers, print each number with a space in between.
                int userInput;
                string userInputString;

                Console.WriteLine("Welcome! Please write out an integer of exactly 5 characters.\n");
                userInputString = Console.ReadLine();

               // Force an error if it cannot be converted to an integer.
                userInput = int.Parse(userInputString);

                // Check to see if the input is null.
                if (userInputString == null)
                {
                    Console.WriteLine("You entered in no value to check");
                }
                // Check if the value contains a period when it should not. Having a period would make it a double or float.
                else if (userInputString.Contains(".") == true)
                {
                    Console.WriteLine("You inputted a non integer value. Please try again and only input an integer of 5 characters in length.");
                }
                // Check if the unput length is too short.
                else if (userInputString.Length < 5)
                {
                    Console.WriteLine("You've entered in too few characters. Please try again and only input an integer of 5 characters in length.");
                }
                // Check if the unput length is too long.
                else if (userInputString.Length > 5)
                {
                    Console.WriteLine("You've entered in too many characters. Please try again and only input an integer of 5 characters in length.");
                }
                // If everything checks out, proceed.
                else 
                {
                    Console.WriteLine("\n");
                    for (int i = 0; i < userInputString.Length; i++)
                    {
                        Console.Write(userInputString[i]+ "   ");
                    }
                    Console.WriteLine("\n");
                }
            }
            // Prevent the program from crashing. Catch the error, direct the user to try again.
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please make sure your input is an integer of 5 characters in legnth.");
            }
         }
    }
}