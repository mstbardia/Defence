using Defence.Core.Validations.Abstractions.Nullables.Base;

namespace Defence.Core.Validations.Abstractions;

/// <summary>
/// interface which validates fields with string type
/// </summary>
public interface IStringValidation : INullValidation<IStringValidation>
{
    /// <summary>
    /// validates your field for not null or not empty or not filled by whitespace condition
    /// </summary>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    IStringValidation NotBeNullOrWhiteSpaceOrEmpty();
    /// <summary>
    /// validates your field for null or empty or filled by whitespace condition
    /// </summary>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    IStringValidation BeNullOrWhiteSpaceOrEmpty();
    /// <summary>
    /// validates your field for not null or not empty condition
    /// </summary>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    IStringValidation NotBeNullOrEmpty();
    /// <summary>
    /// validates your field for null or empty condition
    /// </summary>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    IStringValidation BeNullOrEmpty();
    /// <summary>
    /// validates your field for having expected value
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    IStringValidation BeEqual(string value);
    /// <summary>
    /// validates your field for having exact value length as expected
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    IStringValidation HaveExactLength(int value);
    /// <summary>
    /// validates your field for having greater value length than expected
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IIntegerValidation"/> so that additional calls can be chained.</returns>
    IStringValidation HaveGreaterLength(int value);
}