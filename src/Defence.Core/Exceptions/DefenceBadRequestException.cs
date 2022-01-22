using Defence.Core.Exceptions.Abstractions;

namespace Defence.Core.Exceptions;

public class DefenceBadRequestException : DefenceExceptionBase 
{
    public DefenceBadRequestException(string message = "Bad Request") : base(message, 400)
    {
        
    }
}