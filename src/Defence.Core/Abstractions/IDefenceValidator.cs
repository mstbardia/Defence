namespace Defence.Core.Abstractions;

public interface IDefenceValidator
{
    Task Validate(object input);
}

public interface IDefenceValidator<in T> : IDefenceValidator
{
    Task IDefenceValidator.Validate(object source)
    {
        return Validate((T) source);
    }

    Task Validate(T input);
}