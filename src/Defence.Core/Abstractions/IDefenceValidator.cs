namespace Defence.Core.Abstractions;

/// <summary>
/// Do not use this , it is just a trick
/// for using strategy pattern in heart of library
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
    Task IValidator.Validate(object source)
    {
        return Validate((T) source);
    }

    Task Validate(T input);
}