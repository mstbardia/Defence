using System.Collections.Generic;

namespace Defence.Internals;

internal class DefenceResult
{
    public DefenceResult(IEnumerable<string> errors)
    {
        DefenceErrors = errors;
    }
    public IEnumerable<string> DefenceErrors { get; set; }
}