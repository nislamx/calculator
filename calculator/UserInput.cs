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
    public int firstInput { get; set; }
    public int secondInput { get; set; }
    public Operations operation { get; set; }
}