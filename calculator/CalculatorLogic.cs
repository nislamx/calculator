namespace calculator;

public class CalculatorLogic
{
    private readonly IUserInputService _userInputService;

    public CalculatorLogic(IUserInputService userInputService)
    {
        _userInputService = userInputService;
    }

    public void Calculate()
    {
        UserInput userInput = _userInputService.getUserInput();

        switch (userInput.operation)
        {
            case Operations.Add:
                Add(userInput);
                break;
            case Operations.Subtract:
                Subtract(userInput);
                break;
            case Operations.Multiply:
                Multiply(userInput);
                break;
            case Operations.Divide:
                Divide(userInput);
                break;
        }
    }

    private void Add(UserInput userInput)
    {
        int result = userInput.firstInput + userInput.secondInput;
        Console.WriteLine(result);
    }

    private void Subtract(UserInput userInput)
    {
        int result = userInput.firstInput - userInput.secondInput;
        Console.WriteLine(result);
    }
    
    private void Multiply(UserInput userInput)
    {
        int result = userInput.firstInput * userInput.secondInput;
        Console.WriteLine(result);
    }
    
    private void Divide(UserInput userInput)
    {
        if(userInput.secondInput != 0) 
        {
            int result = userInput.firstInput / userInput.secondInput;
            Console.WriteLine(result);
        }
        else 
        {
            Console.WriteLine("Division by zero is not allowed!");
        }
    }
}