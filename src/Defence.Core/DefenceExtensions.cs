using Defence.Core.Handlers.Internals.Abstractions;
using Defence.Core.Validations.Abstractions;
using Defence.Core.Validations.Internals;

namespace Defence.Core;

/// <summary>
/// Contains extension methods for Defence validations in unit tests.
/// </summary>
public static class DefenceExtensions
{
    private static IDefenceErrorHandler _defenceErrorHandler;
    
    /// <summary>
    /// tricks for passing object from IOC container to static class
    /// </summary>
    /// <param name="defenceErrorHandler">an instance from IDefenceErrorHandler</param>
    internal static void Configure(IDefenceErrorHandler defenceErrorHandler)
    {
        if (_defenceErrorHandler == null)
            _defenceErrorHandler = defenceErrorHandler;
    }
  
    /// <summary>
    /// Returns an <see cref="IDefenceIntegerValidation" /> object that can be used to validate
    /// </summary>
    /// <param name="input">your input field</param>
    /// <param name="fieldName">your field name to specify in error result</param>
    /// <returns></returns>
    public static IDefenceIntegerValidation Must(this int input, string fieldName)
    {
        return new DefenceIntegerValidation(fieldName, input, _defenceErrorHandler);
    }
    
    /// <summary>
    /// Returns an <see cref="IDefenceStringValidation" /> object that can be used to validate
    /// </summary>
    /// <param name="input">your input field</param>
    /// <param name="fieldName">your field name to specify in error result</param>
    /// <returns></returns>
    public static IDefenceStringValidation Must(this string input, string fieldName)
    {
        return new DefenceStringValidation(fieldName, input, _defenceErrorHandler);
    }
}

 