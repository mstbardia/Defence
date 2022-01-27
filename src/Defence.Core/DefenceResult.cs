namespace Defence.Core;

internal class DefenceResult
{
    public DefenceResult(IEnumerable<string> errors,string traceId)
    {
        DefenceErrors = errors;
        TraceId = traceId;
    }
    public IEnumerable<string> DefenceErrors { get; set; }
    public string TraceId { get; set; }
}