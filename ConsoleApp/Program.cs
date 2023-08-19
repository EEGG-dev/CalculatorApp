
using ConsoleApp;

Logic.WelcomeMessage();

while (true)
{
    char sign = Logic.GetOperator();
    if (sign == 'q')
    {
        Console.WriteLine("Exiting the program. Goodbye!");
        break;
    }
    Logic.EvaluateSign(sign);

    Console.Write("Press 'q' and Enter to quit or any other key to continue: ");
    char quit = Console.ReadKey().KeyChar;
    Console.WriteLine();
    if (quit == 'q')
    {
        Console.WriteLine("Exiting the program. Goodbye!");
        break;
    }
}