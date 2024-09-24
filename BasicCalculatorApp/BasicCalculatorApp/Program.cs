//Hi, I am Amanda Chew, and I chose to create "iii.Basic Calculator" project.
//I created this simple calculator application in C# language.

//The project include the following basic features:
//1.Arithmetic Operations
//2.User Interface
//3.Error Handling
//4.Bonus Features
class Program
{
    static void Main(string[] args)
    {
        bool continueCalculation = true;    //to allow user to perform calculation iteratively

        while (continueCalculation)
        {

            //Display options for user to select
            Console.WriteLine("\nStarting the Calculator Application");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Addition (+) ");
            Console.WriteLine("2. Subtraction (-) ");
            Console.WriteLine("3. Multiplication (*) ");
            Console.WriteLine("4. Division (/) ");
            Console.WriteLine("5. Exponentiation (^) ");
            Console.WriteLine("0. Exit");
            Console.WriteLine("------------------------------------\n");

            int operation = GetOperationSelectionFromUser();

            if (operation == 0)         //exit program
                Environment.Exit(0);

            Console.WriteLine("\nPlease enter first number: ");
            double number1 = GetNumberFromUser();

            Console.WriteLine("\nPlease enter second number: ");
            double number2 = GetNumberFromUser();

            double result = 0;
            string calculation = string.Empty;

            //perform operation based on user selection
            switch (operation)
            {
                case 1:
                    result = number1 + number2;
                    calculation = $"{number1} + {number2} = {result}";
                    break;
                case 2:
                    result = number1 - number2;
                    calculation = $"{number1} - {number2} = {result}";
                    break;
                case 3:
                    result = number1 * number2;
                    calculation = $"{number1} * {number2} = {result}";
                    break;
                case 4:
                    if(number2 != 0)
                    {
                        result = number1 / number2;
                        calculation = $"{number1} / {number2} = {result}";
                    }
                    else
                    {
                        Console.WriteLine("\nError, cannot be divided by zero. Pls try again.");
                        
                        Console.WriteLine("\nPlease enter first number: ");
                        double secondtrynumber1 = GetNumberFromUser();

                        Console.WriteLine("\nPlease enter second number: ");
                        double secondtrynumber2 = GetNumberFromUser();

                        if (secondtrynumber2 != 0)
                        {
                            result = secondtrynumber1 / secondtrynumber2;
                            calculation = $"{secondtrynumber1} / {secondtrynumber2} = {result}";
                        }
                        else
                        {
                            Console.WriteLine("\nError, division failed as number is divided by 0. Will be redirecting you back to select an operation.");
                            continue;

                        }
                    }
                    break;
                case 5:
                    result = Math.Pow(number1, number2);
                    calculation = $"{number1} ^ {number2} = {result}";
                    break;
                case 0:
                    Console.WriteLine("Exit");
                    continueCalculation = false; //end operation
                    break;
                default:
                    Console.WriteLine("Invalid operation selected. Please try again.\n");
                    break;
            }

            if (operation != 0)
            {
                Console.WriteLine("\nResult of operation is: " + calculation + "\n");
                //add calculation to history record
            }

            //Allow user to perform calculation again after first calculation
            string userResponse;
            do
            {
                Console.WriteLine("Perform another calculation? (y/n)\n");
                userResponse = Console.ReadLine().Trim().ToLower();

                if (userResponse != "y" && userResponse != "n")
                    Console.WriteLine("\nInvalid input. Please enter either y/n.\n");

            } while (userResponse != "y" && userResponse != "n");

            continueCalculation = userResponse == "y";
        }

        //show history of calculations performed
        Console.WriteLine("\nRecords of Calculation Hisotry");
    }

    private static double GetNumberFromUser()
    {
        double number;
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out number))
                return number;
            else
                Console.WriteLine("\nInvalid input, pls enter a numeric value.");
        }
    }

    private static int GetOperationSelectionFromUser()
    {
        int operation;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out operation) && operation >= 0 && operation <= 5)
                return operation;
            else
                Console.WriteLine("\nInvalid input, pls select a option from below(0 - 5).");
        }
    }
}
