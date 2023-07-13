namespace calculator;

public enum Operations
{
    Add,
    Subtract,
    Multiply,
    Divide,
    
}

public class UserInput
{
    public decimal firstInput { get; set; }
    public decimal secondInput { get; set; }
    public Operations operation { get; set; }
}