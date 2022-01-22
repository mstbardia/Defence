using Defence.Core.Handlers.Internals.Abstractions;
using Defence.Core.Validations.Abstractions;
using Defence.Core.Validations.Internals;

namespace Defence.Core;

public static class DefenceFactory
{
    private static IDefenceErrorHandler _defenceErrorHandler;

    internal static void Configure(IDefenceErrorHandler defenceErrorHandler)
    {
        if (_defenceErrorHandler == null)
            _defenceErrorHandler = defenceErrorHandler;
    }
    
    public static IDefenceIntegerValidation Must(this int input, string fieldName)
    {
        return new DefenceIntegerValidation(fieldName, input, _defenceErrorHandler);
    }
    
    public static IDefenceStringValidation Must(this string input, string fieldName)
    {
        return new DefenceStringValidation(fieldName, input, _defenceErrorHandler);
    }
    
}

 