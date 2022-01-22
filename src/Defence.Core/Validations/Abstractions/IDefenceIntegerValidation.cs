namespace Defence.Core.Validations.Abstractions;

public interface IDefenceIntegerValidation
{
    IDefenceIntegerValidation LessThan(int value);
}