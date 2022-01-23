namespace Defence.Core.Validations.Abstractions;

/// <summary>
/// interface which validates fields with string type
/// </summary>
public interface IDefenceStringValidation
{
    /// <summary>
    /// validates your field for not null or not empty or not filled by whitespace condition
    /// </summary>
    /// <returns>The <see cref="IDefenceIntegerValidation"/> so that additional calls can be chained.</returns>
    IDefenceStringValidation NotBeNullOrWhiteSpaceOrEmpty();
    /// <summary>
    /// validates your field for null or empty or filled by whitespace condition
    /// </summary>
    /// <returns>The <see cref="IDefenceIntegerValidation"/> so that additional calls can be chained.</returns>
    IDefenceStringValidation BeNullOrWhiteSpaceOrEmpty();
    /// <summary>
    /// validates your field for not null or not empty condition
    /// </summary>
    /// <returns>The <see cref="IDefenceIntegerValidation"/> so that additional calls can be chained.</returns>
    IDefenceStringValidation NotBeNullOrEmpty();
    /// <summary>
    /// validates your field for null or empty condition
    /// </summary>
    /// <returns>The <see cref="IDefenceIntegerValidation"/> so that additional calls can be chained.</returns>
    IDefenceStringValidation BeNullOrEmpty();
    /// <summary>
    /// validates your field for having expected value
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IDefenceIntegerValidation"/> so that additional calls can be chained.</returns>
    IDefenceStringValidation BeEqual(string value);
    /// <summary>
    /// validates your field for having exact value length as expected
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IDefenceIntegerValidation"/> so that additional calls can be chained.</returns>
    IDefenceStringValidation HaveExactLength(int value);
    /// <summary>
    /// validates your field for having greater value length than expected
    /// </summary>
    /// <param name="value">your expected value</param>
    /// <returns>The <see cref="IDefenceIntegerValidation"/> so that additional calls can be chained.</returns>
    IDefenceStringValidation HaveGreaterLength(int value);
}