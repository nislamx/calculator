using calculator;

IUserInputService userInputService = new UserInputService();

// create an instance of CalculatorLogic and pass in the userInputService
var calculatorLogic = new CalculatorLogic(userInputService);

// call the Calculate method
calculatorLogic.Calculate();