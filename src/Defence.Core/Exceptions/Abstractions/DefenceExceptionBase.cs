namespace Defence.Core.Exceptions.Abstractions;

public abstract class DefenceExceptionBase : Exception
{
    public DefenceExceptionBase(string errorMessage , int statusCode)
    {
        ErrorMessage = errorMessage;
        
        StatusCode = statusCode;
    }

    public int StatusCode { get; private set; }
    
    public string ErrorMessage { get; private set; }
}