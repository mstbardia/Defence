using Defence.Exceptions.Abstractions;

namespace Defence.Exceptions;

internal class DefenceBadRequestException : DefenceExceptionBase 
{
    public DefenceBadRequestException(string errorMessage = "Bad Request") : base(errorMessage, 400)
    {
        
    }
}