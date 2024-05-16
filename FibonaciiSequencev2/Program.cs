namespace FibonacciSequence

{
    class Program
    {
        static void Main(string[] args)
        {   // 0 1 1 2 3 5 8 13 21...

            // creates list 
            List<int> fibNumbers = new List<int>();
            List<int> negativeFibNumbers = new List<int>();

            // stores integers for first two numbers in sequence
            fibNumbers.Add(0);
            fibNumbers.Add(1);

            negativeFibNumbers.Add(0);
            negativeFibNumbers.Add(1);
            // variables for user defined list length and to break out of while loop when conditions are met 
            int userInput = 0;
            bool positiveControl = true;
            bool negativeControl = true;
            bool validInput = true;

            Console.WriteLine("Welcome to the Fibonacci Sequence. Please enter how many numbers you would like typed out...");
           
            while (validInput)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out userInput))
                {
                    validInput = false;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid number.");
                }
            }
            if (userInput >= 0)
            {
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
            }

            else if (userInput < 0)
            {
                while (negativeControl)
                {
                    // loops through list generating numbers, starts at 2 since first two numbers are already populated in list 
                    for (int i = 2; i < -userInput; i++)
                    {
                        // adds numbers to list after calculating their values
                        negativeFibNumbers.Add(negativeFibNumbers[i - 2] + negativeFibNumbers[i - 1]);
                    }
                        negativeControl = false;
                }
            }

            // writes list to console 
            // checks if user is asking for only first number in Fibonacci Sequence and will only show position 0 in list
            if (userInput == 1)
            {
                Console.Write(fibNumbers[0]);
            }
            // checks if user is asking for only first two number in Fibonacci Sequence and will only show position 0 & 1 in list
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
            }
            if (userInput < 0)
            {
                foreach (int number in negativeFibNumbers)
                {
                    Console.Write(number + " ");
                }
            }            
        }
    }
}