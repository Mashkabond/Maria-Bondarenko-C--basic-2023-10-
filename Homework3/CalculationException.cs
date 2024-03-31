namespace Homework3;

public class CalculationException : Exception
{
    public CalculationException(string messsage, Exception innerException) : base(messsage, innerException)
    {
    }
}