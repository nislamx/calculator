namespace calculator;

public class CalculatorLogic
{
    private readonly IUserInputService _userInputService;

    public CalculatorLogic(IUserInputService userInputService)
    {
        _userInputService = userInputService;
    }

    public decimal Calculate()
    {
        UserInput userInput = _userInputService.getUserInput();

        switch (userInput.operation)
        {
            case Operations.Add:
                return Add(userInput);
            case Operations.Subtract:
                return Subtract(userInput);
            case Operations.Multiply:
                return Multiply(userInput);
            case Operations.Divide:
                return Divide(userInput);
            default:
                throw new ArgumentException($"Unsupported operation: {userInput.operation}");
        }
    }

    public decimal Add(UserInput userInput)
    {
        decimal result = userInput.firstInput + userInput.secondInput;
        Console.WriteLine(result);
        return result;
    }

    private decimal Subtract(UserInput userInput)
    {
        decimal result = userInput.firstInput - userInput.secondInput;
        Console.WriteLine(result);
        return result;

    }
    
    private decimal Multiply(UserInput userInput)
    {
        decimal result = userInput.firstInput * userInput.secondInput;
        Console.WriteLine(result);
        return result;

    }
    
    private decimal Divide(UserInput userInput)
    {
        decimal result = userInput.firstInput / userInput.secondInput;
        Console.WriteLine(result);
        return result;

    }
}