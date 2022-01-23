namespace Defence.Core.Validations.Abstractions;

/// <summary>
/// interface which validates fields with integer type
/// </summary>
public interface IDefenceIntegerValidation
{
    /// <summary>
    /// validates your field for having less value than expected value
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IDefenceIntegerValidation"/> so that additional calls can be chained.</returns>
    IDefenceIntegerValidation LessThan(int value);
}