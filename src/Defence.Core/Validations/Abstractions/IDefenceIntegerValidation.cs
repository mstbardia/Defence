namespace Defence.Core.Validations.Abstractions;

/// <summary>
/// interface which validates fields with integer type
/// </summary>
public interface IDefenceIntegerValidation
{
    /// <summary>
    /// validates that if assigned value is less than expected value
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IDefenceIntegerValidation"/> so that additional calls can be chained.</returns>
    IDefenceIntegerValidation BeLessThan(int value);
    /// <summary>
    /// validates that if assigned value is less than or equal to expected value
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IDefenceIntegerValidation"/> so that additional calls can be chained.</returns>
    IDefenceIntegerValidation BeLessThanOrEqual(int value);
    /// <summary>
    /// validates that if assigned value is greater than expected value
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IDefenceIntegerValidation"/> so that additional calls can be chained.</returns>
    IDefenceIntegerValidation BeGreaterThan(int value);
    /// <summary>
    /// validates that if assigned value is greater than or equal to expected value
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IDefenceIntegerValidation"/> so that additional calls can be chained.</returns>
    IDefenceIntegerValidation BeGreaterThanOrEqual(int value);
    /// <summary>
    /// validates that if assigned value is equal to expected value
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IDefenceIntegerValidation"/> so that additional calls can be chained.</returns>
    IDefenceIntegerValidation BeEqual(int value);
    /// <summary>
    /// validates that if assigned value is positive
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IDefenceIntegerValidation"/> so that additional calls can be chained.</returns>
    IDefenceIntegerValidation BePositive();
    /// <summary>
    /// validates that if assigned value is negative
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IDefenceIntegerValidation"/> so that additional calls can be chained.</returns>
    IDefenceIntegerValidation BeNegative();
}