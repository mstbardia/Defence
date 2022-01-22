namespace Defence.Core.Validations.Abstractions;

/// <summary>
/// interface which validates fields with integer type
/// </summary>
public interface IDefenceIntegerValidation
{
    IDefenceIntegerValidation LessThan(int value);
}