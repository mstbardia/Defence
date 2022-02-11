using Defence.Exceptions;
using Defence.Internals.Abstractions;

namespace Defence.Internals.Handlers;

/// <summary>
/// this handler helps to create and hold errors per field and per request on your model
/// </summary>
internal class DefenceErrorHandler : IDefenceErrorHandler
{
    private readonly IDefenceContextHandler _defenceContextHandler;
    
    private static readonly Dictionary<string, HashSet<string>> Errors = new();

    public DefenceErrorHandler(IDefenceContextHandler defenceContextHandler)
    {
        _defenceContextHandler = defenceContextHandler;
    }
    
    public Dictionary<string, HashSet<string>> GetAllRequestsErrors()
    {
        return Errors;
    }

    public DefenceResult GetCurrentRequestResult()
    {
        var traceId = _defenceContextHandler.GetRequestTraceId();

        var isTraceIdExist = Errors.TryGetValue(traceId, out var errorList);
 
        return isTraceIdExist ? new DefenceResult(errorList,traceId) : null;
    }
    
    public void CreateCurrentRequestError(string fieldName, string error)
    {
        var errorText = $"{fieldName} : {error}";

        if (_defenceContextHandler.ShouldThrowExceptions())
        {
            ClearCurrentRequestErrors(); // if u think well this is redundant but i put it for caution
            throw new DefenceBadRequestException(errorText);
        }
        
        var traceId = _defenceContextHandler.GetRequestTraceId();
        
        var existTraceId = Errors.TryGetValue(traceId, out var errorList);
        
        if (existTraceId)
            errorList.Add(errorText);
        else
            Errors.Add(traceId, new HashSet<string> {errorText});
    }

    public void ClearCurrentRequestErrors()
    {
        var traceId = _defenceContextHandler.GetRequestTraceId();

        var isTraceIdExist = Errors.TryGetValue(traceId, out var errorList);

        if (isTraceIdExist)
            Errors.Remove(traceId);
    }
}