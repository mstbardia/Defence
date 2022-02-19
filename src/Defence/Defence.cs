using Defence.Internals.Abstractions;
using Defence.Validations;

namespace Defence;

/// <summary>
/// Contains extension methods for Defence validations in unit tests.
/// </summary>
public static class Defence
{
    private static IDefenceErrorHandler _defenceErrorHandler;

    /// <summary>
    /// tricks for passing object from IOC container to static class
    /// </summary>
    /// <param name="defenceErrorHandler">an instance from IDefenceErrorHandler</param>
    internal static void Configure(IDefenceErrorHandler defenceErrorHandler)
    {
        _defenceErrorHandler ??= defenceErrorHandler;
    }

    /// <summary>
    /// Returns an <see cref="IntegerValidation" /> object that can be used to validate
    /// </summary>
    /// <param name="fieldName">your field name to specify in error result</param>
    /// <returns></returns>
    public static IntegerValidation Must(this int input, string fieldName)
    {
        return new IntegerValidation(new DefenceProperty<int>(fieldName, input), _defenceErrorHandler);
    }

    /// <summary>
    /// Returns an <see cref="NullableIntegerValidation" /> object that can be used to validate
    /// </summary>
    /// <param name="fieldName">your field name to specify in error result</param>
    /// <returns></returns>
    public static NullableIntegerValidation Must(this int? input, string fieldName)
    {
        return new NullableIntegerValidation(new DefenceProperty<int?>(fieldName, input), _defenceErrorHandler);
    }
    
    
    /// <summary>
    /// Returns an <see cref="NullableDoubleValidation" /> object that can be used to validate
    /// </summary>
    /// <param name="fieldName">your field name to specify in error result</param>
    /// <returns></returns>
    public static DoubleValidation Must(this double input, string fieldName)
    {
        return new DoubleValidation(new DefenceProperty<double>(fieldName, input), _defenceErrorHandler);
    }
    
    /// <summary>
    /// Returns an <see cref="NullableDoubleValidation" /> object that can be used to validate
    /// </summary>
    /// <param name="fieldName">your field name to specify in error result</param>
    /// <returns></returns>
    public static NullableDoubleValidation Must(this double? input, string fieldName)
    {
        return new NullableDoubleValidation(new DefenceProperty<double?>(fieldName, input), _defenceErrorHandler);
    }
    
    
    /// <summary>
    /// Returns an <see cref="LongValidation" /> object that can be used to validate
    /// </summary>
    /// <param name="fieldName">your field name to specify in error result</param>
    /// <returns></returns>
    public static LongValidation Must(this long input, string fieldName)
    {
        return new LongValidation(new DefenceProperty<long>(fieldName, input), _defenceErrorHandler);
    }
    
    /// <summary>
    /// Returns an <see cref="NullableLongValidation" /> object that can be used to validate
    /// </summary>
    /// <param name="fieldName">your field name to specify in error result</param>
    /// <returns></returns>
    public static NullableLongValidation Must(this long? input, string fieldName)
    {
        return new NullableLongValidation(new DefenceProperty<long?>(fieldName, input), _defenceErrorHandler);
    }
    
    /// <summary>
    /// Returns an <see cref="StringValidation" /> object that can be used to validate
    /// </summary>
    /// <param name="input">your input field</param>
    /// <param name="fieldName">your field name to specify in error result</param>
    /// <returns></returns>
    public static StringValidation Must(this string input, string fieldName)
    {
        return new StringValidation(new DefenceProperty<string>(fieldName, input), _defenceErrorHandler);
    }
    
    
    /// <summary>
    /// Returns an <see cref="StringCollectionValidation" /> object that can be used to validate
    /// </summary>
    /// <param name="input">your input field</param>
    /// <param name="fieldName">your field name to specify in error result</param>
    /// <returns></returns>
    public static StringCollectionValidation Must(this IEnumerable<string> input, string fieldName)
    {
        return new StringCollectionValidation(new DefenceProperty<IEnumerable<string>>(fieldName, input), _defenceErrorHandler);
    }
}