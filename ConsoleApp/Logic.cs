namespace ConsoleApp;

public static class Logic
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("---- WELCOME TO SWITCH APP ----");
        Console.WriteLine("*******************************");
        Console.WriteLine();
    }

    public static double GetNumber()
    {
        while(true)
        {
            Console.Write("Enter a number: ");
            if (double.TryParse(Console.ReadLine(), out double result))
            return result;

            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    public static char GetOperator()
    {
        while (true)
        {
            Console.Write("Enter the sign of the operation to be performed (+, -, *, /): ");
            char sign = Console.ReadKey().KeyChar();
            Console.WriteLine();
            if (sign == '+' || sign '-' || sign == '*' || sign == '/')
                return sign;
            Console.WriteLine("Invalid Operator. Please enter a valid operator (+, -, *, /): ");
        }
    }

    public static void EvaluateSign(char sign)
    {
        switch (sign)
        {
            case '+':
                Operations.Sum();
                break;
            case '-':
                Operations.Rest();
                break;
            case '*':
                Operations.Mult();
                break;
            case '/':
                Operations.Div();
                break;
        }
    }
}
