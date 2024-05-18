using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {   // 0 1 1 2 3 5 8 13 21...

            // creates list 
            List<int> fibNumbers = new List<int>();

            // stores integers for first two numbers in sequence
            fibNumbers.Add(0);
            fibNumbers.Add(1);

            // variables for user defined list length and to break out of while loop when conditions are met
            int userInput = 0;
            bool positiveControl = true;
            bool validInput = false;

            // greets user and asks for initial input
            Console.WriteLine("Welcome to the Fibonacci Sequence. Please enter how many numbers you would like typed out...");
            string input = Console.ReadLine();

            // verifies user input is a valid in and throws an error if its a negative number or not a valid int
            while (!validInput)
            {
                // verifies user input is a valid int
                if (int.TryParse(input, out userInput))
                {
                    // verifies if outside of valid range of numbers
                    if (userInput >= 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter a positive number.");
                        input = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid number.");
                    input = Console.ReadLine();
                }
            }
            // initiates and writes Fibonacci Sequence based on user input
            while (positiveControl)
            {
                // loops through list generating numbers, starts at 2 since first two numbers are already populated in list
                for (int i = 2; i < userInput; i++)
                {
                    // adds numbers to list after calculating their values
                    fibNumbers.Add(fibNumbers[i - 1] + fibNumbers[i - 2]);
                }
                positiveControl = false;
            }

            if (userInput == 0)
            {
                Console.WriteLine("No numbers to display.");
            }
            else
            {
                for (int i = 0; i < userInput; i++)
                {
                    Console.Write(fibNumbers[i] + " ");
                }
            }

            // writes list to console
            // checks if user is asking for no numbers
            /*if (userInput == 0)
            {
                Console.WriteLine("No numbers to display.");
            }
            // checks if user is asking for only the first number in Fibonacci Sequence and will only show position 0 in list
            if (userInput == 1)
            {
                Console.Write(fibNumbers[0]);
            }
            // checks if user is asking for only the first two number in Fibonacci Sequence and will only show position 0 in list
            if (userInput == 2)
            {
                Console.Write(fibNumbers[0] + " ");
                Console.Write(fibNumbers[1]);
            }
            // checks if user is asking for more than first two numbers in Fibonacci Sequence and will output all requested positions
            if (userInput > 2)
            {
                foreach (int number in fibNumbers)
                {
                    Console.Write(number + " ");
                }
            }*/
        }
    }
}