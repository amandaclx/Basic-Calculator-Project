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
            Console.WriteLine("Starting the Calculator Application");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Addition (+) ");
            Console.WriteLine("2. Subtraction (-) ");
            Console.WriteLine("3. Multiplication (*) ");
            Console.WriteLine("4. Division (/) ");
            Console.WriteLine("5. Exponentiation (^) ");
            Console.WriteLine("0. Exit \n");

            int operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 0)         //exit program
                Environment.Exit(0);

            Console.WriteLine("\nPlease enter first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPlease enter second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

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
                    result = number1 / number2;
                    calculation = $"{number1} / {number2} = {result}";
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
                Console.WriteLine("\nResult of operation is: " + calculation);
                //add calculation to history record
            }

            //Allow user to perform calculation again after first calculation
            string userResponse;
            do
            {
                Console.WriteLine("\nPerform another calculation? (y/n)\n");
                userResponse = Console.ReadLine();

                if (userResponse != "y" && userResponse != "n")
                    Console.WriteLine("\nInvalid input. Please enter either y/n.");

            } while (userResponse != "y" && userResponse != "n");

            continueCalculation = userResponse == "y";
        }
    }
}
