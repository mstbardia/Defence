namespace Defence.Core.Validations.Abstractions;

/// <summary>
/// interface which validates fields with integer type
/// </summary>
public interface IIntegerValidation
{
    /// <summary>
    /// validates that if assigned value is less than expected value
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    IIntegerValidation BeLessThan(int value);
    /// <summary>
    /// validates that if assigned value is less than or equal to expected value
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    IIntegerValidation BeLessThanOrEqual(int value);
    /// <summary>
    /// validates that if assigned value is greater than expected value
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    IIntegerValidation BeGreaterThan(int value);
    /// <summary>
    /// validates that if assigned value is greater than or equal to expected value
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    IIntegerValidation BeGreaterThanOrEqual(int value);
    /// <summary>
    /// validates that if assigned value is equal to expected value
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    IIntegerValidation BeEqual(int value);
    /// <summary>
    /// validates that if assigned value is positive
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    IIntegerValidation BePositive();
    /// <summary>
    /// validates that if assigned value is negative
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    IIntegerValidation BeNegative();
}