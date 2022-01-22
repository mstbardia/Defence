namespace Defence.Core.Handlers.Internals.Abstractions;

internal interface IDefenceErrorHandler
{
    Dictionary<string, HashSet<string>> GetAllRequestsErrors();
  
    HashSet<string> GetCurrentRequestErrors();
    
    void CreateCurrentRequestError(string fieldName, string error);

    void ClearCurrentRequestErrors();
}