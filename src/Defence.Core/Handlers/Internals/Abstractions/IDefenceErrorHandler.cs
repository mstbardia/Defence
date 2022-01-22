namespace Defence.Core.Handlers.Internals.Abstractions;

/// <summary>
/// you should seek its duty on its implementer
/// </summary>
internal interface IDefenceErrorHandler
{
    Dictionary<string, HashSet<string>> GetAllRequestsErrors();
  
    HashSet<string> GetCurrentRequestErrors();
    
    void CreateCurrentRequestError(string fieldName, string error);

    void ClearCurrentRequestErrors();
}