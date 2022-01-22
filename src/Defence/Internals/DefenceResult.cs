using System.Collections.Generic;

namespace Defence.Internals;

internal class DefenceResult
{
    public DefenceResult(IEnumerable<string> errors)
    {
        Errors = errors;
    }
    public IEnumerable<string> Errors { get; set; }
}