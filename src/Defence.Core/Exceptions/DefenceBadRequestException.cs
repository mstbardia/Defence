using Defence.Core.Exceptions.Abstractions;

namespace Defence.Core.Exceptions;

internal class DefenceBadRequestException : DefenceExceptionBase 
{
    public DefenceBadRequestException(string errorMessage = "Bad Request") : base(errorMessage, 400)
    {
        
    }
}