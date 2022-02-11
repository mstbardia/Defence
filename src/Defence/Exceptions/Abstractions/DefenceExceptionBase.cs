namespace Defence.Exceptions.Abstractions;

public abstract class DefenceExceptionBase : Exception
{
    protected DefenceExceptionBase(string errorMessage , int statusCode)
    {
        StatusCode = statusCode;

        Message = errorMessage;
    }

    protected virtual int StatusCode { get; }
    public override string Message { get; }
}