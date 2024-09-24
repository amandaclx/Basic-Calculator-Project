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
        //Display options for user to select
        Console.WriteLine("Starting the Calculator Application");
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Addition (+) ");
        Console.WriteLine("2. Subtraction (-) ");
        Console.WriteLine("3. Multiplication (*) ");
        Console.WriteLine("4. Division (/) ");
        Console.WriteLine("5. Subtraction (-) ");
        Console.WriteLine("0. Exit ");

        int operation = Convert.ToInt32(Console.ReadLine());

        if (operation == 0)         //exit program
            Environment.Exit(0);

        Console.WriteLine("Please enter first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter second number: ");
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
                break;
        }

        if (operation != 0)
            Console.WriteLine("Result of operation is: " + calculation);
    
    }

}
