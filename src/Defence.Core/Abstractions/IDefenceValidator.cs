namespace Defence.Core.Abstractions;

/// <summary>
/// Do not play with this , it is just a trick for strategy
/// </summary>
public interface IValidator
{
    Task Validate(object input);
}

/// <summary>
/// the main interface of Defence library which
/// helps you to make fluent validation of your model
/// </summary>
/// <typeparam name="T">The Type which you want to validate</typeparam>
public interface IDefenceValidator<in T> : IValidator
{
    Task IValidator.Validate(object source) => Validate((T) source);
    Task Validate(T input);
}