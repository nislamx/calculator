namespace calculator;

public interface IUserInputService
{
    public UserInput getUserInput();
}

public class UserInputService: IUserInputService
{
 

    public UserInput getUserInput()
    {
        UserInput userInput = new UserInput();

        while (true)
        {
            Console.WriteLine("What operation would you like to perform. Please type one of add / subtract / divide / multiply");
            string operationInput = Console.ReadLine();

            if (Enum.TryParse(operationInput, true, out Operations operation))
            {
                userInput.operation = operation;
                break; //Exit loop if input is valid
            }
            
            Console.WriteLine("Yo, I said add / subtract / divide / multiply");
        }
        
        while (true)
        {
            Console.WriteLine("Please put in your first input which should be a number");
            string firstInputAsString = Console.ReadLine();

            if (int.TryParse(firstInputAsString, out int firstInputAsNum))
            {
                userInput.firstInput = firstInputAsNum;
                break; //Exit loop if input is valid
            }
            
            Console.WriteLine("This ain't a number matey");
        }

        while (true)
        {
            Console.WriteLine("Please put in your second number matey");
            string secondInputAsString = Console.ReadLine();

            if (int.TryParse(secondInputAsString, out int secondInputAsNum))
            {
                userInput.secondInput = secondInputAsNum;
                break; //Exit loop if input is valid
            }

            Console.WriteLine("This ain't a number matey");
        }

        return userInput;
    }
}