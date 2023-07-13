using Moq;

namespace calculator.Test;

public class CalculatorLogicTests
{
    private Mock<IUserInputService> mock;

    public CalculatorLogicTests()
    {
        mock = new Mock<IUserInputService>();
    }

    
    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        UserInput mockUserInput = new UserInput() { operation = Operations.Add, firstInput = 2, secondInput = 2 };
        mock.Setup(service => service.getUserInput()).Returns(mockUserInput);
        CalculatorLogic calculatorLogic = new CalculatorLogic(mock.Object);
        
        decimal result = calculatorLogic.Add(mockUserInput);
        
        Assert.Equal(4,result);
        mock.Reset();

    }

    [Fact]
    public void Calculate_MultiplyTwoNumbers_ReturnsCorrectSum()
    {
        UserInput mockUserInput = new UserInput() { operation = Operations.Multiply, firstInput = 2, secondInput = 10 };
        mock.Setup(service => service.getUserInput()).Returns(mockUserInput);
        CalculatorLogic calculatorLogic = new CalculatorLogic(mock.Object);
        decimal result = calculatorLogic.Calculate();
        
        Assert.Equal(20,result);



    }
    
    
}