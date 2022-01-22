namespace Defence.Core.Exceptions.Abstractions;

public abstract class DefenceExceptionBase : Exception
{
    public DefenceExceptionBase(string message , int statusCode)
    {
        Message = message;
        
        StatusCode = statusCode;
    }

    public int StatusCode { get; private set; }
    
    public string Message { get; private set; }
}