namespace Defence.Internals.Abstractions;

/// <summary>
/// you should seek its duty on its implementer
/// </summary>
internal interface IDefenceErrorHandler
{
    Dictionary<string, HashSet<string>> GetAllRequestsErrors();
  
    DefenceResult GetCurrentRequestResult();
    
    void CreateCurrentRequestError(string fieldName, string error);

    void ClearCurrentRequestErrors();
}