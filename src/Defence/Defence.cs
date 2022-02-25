using Defence.Internals.Abstractions;
using Defence.Validations;
using Defence.Validations.Abstractions;

namespace Defence;

/// <summary>
/// Contains extension methods for Defence validations in unit tests.
/// </summary>
public static partial class Defence
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
    /// <see cref="T:BaseValidation&lt;bool&gt;"/> The object that can be used to validate
    /// </summary>
    /// <param name="fieldName">The field name that specifies the input validation result</param>
    /// <returns></returns>
    public static BaseValidation<bool> Must(this bool input, string fieldName)
    {
        return new BaseValidation<bool>(new DefenceProperty<bool>(fieldName, input), _defenceErrorHandler);
    }

    /// <summary>
    /// <see cref="T:BaseValidation&lt;byte&gt;"/> The object that can be used to validate
    /// </summary>
    /// <param name="fieldName">The field name that specifies the input validation result</param>
    /// <returns></returns>
    public static BaseValidation<byte> Must(this byte input, string fieldName)
    {
        return new BaseValidation<byte>(new DefenceProperty<byte>(fieldName, input), _defenceErrorHandler);
    }

    /// <summary>
    /// <see cref="T:BaseValidation&lt;sbyte&gt;"/> The object that can be used to validate
    /// </summary>
    /// <param name="fieldName">The field name that specifies the input validation result</param>
    /// <returns></returns>
    public static BaseValidation<sbyte> Must(this sbyte input, string fieldName)
    {
        return new BaseValidation<sbyte>(new DefenceProperty<sbyte>(fieldName, input), _defenceErrorHandler);
    }

    /// <summary>
    /// <see cref="T:BaseValidation&lt;char&gt;"/> The object that can be used to validate
    /// </summary>
    /// <param name="fieldName">The field name that specifies the input validation result</param>
    /// <returns></returns>
    public static BaseValidation<char> Must(this char input, string fieldName)
    {
        return new BaseValidation<char>(new DefenceProperty<char>(fieldName, input), _defenceErrorHandler);
    }

    /// <summary>
    /// <see cref="T:BaseValidation&lt;decimal&gt;"/> The object that can be used to validate
    /// </summary>
    /// <param name="fieldName">The field name that specifies the input validation result</param>
    /// <returns></returns>
    public static BaseValidation<decimal> Must(this decimal input, string fieldName)
    {
        return new BaseValidation<decimal>(new DefenceProperty<decimal>(fieldName, input), _defenceErrorHandler);
    }

    /// <summary>
    /// <see cref="T:BaseValidation&lt;double&gt;"/> The object that can be used to validate
    /// </summary>
    /// <param name="fieldName">The field name that specifies the input validation result</param>
    /// <returns></returns>
    public static BaseValidation<double> Must(this double input, string fieldName)
    {
        return new BaseValidation<double>(new DefenceProperty<double>(fieldName, input), _defenceErrorHandler);
    }

    /// <summary>
    /// <see cref="T:BaseValidation&lt;float&gt;"/> The object that can be used to validate
    /// </summary>
    /// <param name="fieldName">The field name that specifies the input validation result</param>
    /// <returns></returns>
    public static BaseValidation<float> Must(this float input, string fieldName)
    {
        return new BaseValidation<float>(new DefenceProperty<float>(fieldName, input), _defenceErrorHandler);
    }

    /// <summary>
    /// <see cref="T:BaseValidation&lt;int&gt;"/> The object that can be used to validate
    /// </summary>
    /// <param name="fieldName">The field name that specifies the input validation result</param>
    /// <returns></returns>
    public static BaseValidation<int> Must(this int input, string fieldName)
    {
        return new BaseValidation<int>(new DefenceProperty<int>(fieldName, input), _defenceErrorHandler);
    }
    
    /// <summary>
    /// <see cref="T:BaseValidation&lt;uint&gt;"/> The object that can be used to validate
    /// </summary>
    /// <param name="fieldName">The field name that specifies the input validation result</param>
    /// <returns></returns>
    public static BaseValidation<uint> Must(this uint input, string fieldName)
    {
        return new BaseValidation<uint>(new DefenceProperty<uint>(fieldName, input), _defenceErrorHandler);
    }

    /// <summary>
    /// <see cref="T:BaseValidation&lt;long&gt;"/> The object that can be used to validate
    /// </summary>
    /// <param name="fieldName">The field name that specifies the input validation result</param>
    /// <returns></returns>
    public static BaseValidation<long> Must(this long input, string fieldName)
    {
        return new BaseValidation<long>(new DefenceProperty<long>(fieldName, input), _defenceErrorHandler);
    }

    /// <summary>
    /// <see cref="T:BaseValidation&lt;ulong&gt;"/> The object that can be used to validate
    /// </summary>
    /// <param name="fieldName">The field name that specifies the input validation result</param>
    /// <returns></returns>
    public static BaseValidation<ulong> Must(this ulong input, string fieldName)
    {
        return new BaseValidation<ulong>(new DefenceProperty<ulong>(fieldName, input), _defenceErrorHandler);
    }

    /// <summary>
    /// <see cref="T:BaseValidation&lt;short&gt;"/> The object that can be used to validate
    /// </summary>
    /// <param name="fieldName">The field name that specifies the input validation result</param>
    /// <returns></returns>
    public static BaseValidation<short> Must(this short input, string fieldName)
    {
        return new BaseValidation<short>(new DefenceProperty<short>(fieldName, input), _defenceErrorHandler);
    }

    /// <summary>
    /// <see cref="T:BaseValidation&lt;ushort&gt;"/> The object that can be used to validate
    /// </summary>
    /// <param name="fieldName">The field name that specifies the input validation result</param>
    /// <returns></returns>
    public static BaseValidation<ushort> Must(this ushort input, string fieldName)
    {
        return new BaseValidation<ushort>(new DefenceProperty<ushort>(fieldName, input), _defenceErrorHandler);
    }
}