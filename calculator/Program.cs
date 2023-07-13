using calculator;

IUserInputService userInputService = new UserInputService();

var calculatorLogic = new CalculatorLogic(userInputService);

calculatorLogic.Calculate();