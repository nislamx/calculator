using calculator;

IUserInputService userInputService = new UserInputService();

var calculatorLogic = new CalculatorLogic(userInputService);

Console.WriteLine("Welcome to the Calculator Application! \n");
Console.WriteLine("If you would like to exit the application, press the X key after completing a calculation. \n");

while (true)
{
    calculatorLogic.Calculate();
    Console.WriteLine("\nPress any key to continue with a new calculation or X to exit");


    if (Console.ReadKey(false).Key == ConsoleKey.X)
    {
        break;
    }
}
    

