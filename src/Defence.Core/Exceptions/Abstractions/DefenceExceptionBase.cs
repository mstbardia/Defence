namespace Defence.Core.Exceptions.Abstractions;

public abstract class DefenceExceptionBase : Exception
{
    public DefenceExceptionBase(string errorMessage , int statusCode)
    {
        StatusCode = statusCode;

        Message = errorMessage;
    }

    public int StatusCode { get; private set; }
    
    public override string Message { get; }
}