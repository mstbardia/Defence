using Defence.Core.Handlers.Internals.Abstractions;
using Defence.Core.Internals;
using Defence.Core.Validations.Abstractions;

namespace Defence.Core.Validations.Internals;

/// <summary>
/// implementation of <see cref="IDefenceIntegerValidation" />
/// </summary>
internal class DefenceIntegerValidation : DefenceProperty<int>, IDefenceIntegerValidation
{
    private readonly IDefenceErrorHandler _defenceErrorHandler;
    
    public DefenceIntegerValidation(string fieldName, int input , IDefenceErrorHandler defenceErrorHandler) : base(fieldName, input)
    {
        _defenceErrorHandler = defenceErrorHandler;
    }
    
    public IDefenceIntegerValidation BeLessThan(int value)
    {
        if (Input >= value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Should be less than {value}");

        return this;
    }

    public IDefenceIntegerValidation BeLessThanOrEqual(int value)
    {
        if (Input > value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Should be less than or Equal to {value}");

        return this;
    }

    public IDefenceIntegerValidation BeGreaterThan(int value)
    {
        if (Input <= value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Should be greater than {value}");

        return this;
    }

    public IDefenceIntegerValidation BeGreaterThanOrEqual(int value)
    {
        if (Input < value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Should be greater than or Equal to {value}");

        return this;
    }

    public IDefenceIntegerValidation BeEqual(int value)
    {
        if (Input != value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Should be equal to {value}");

        return this;
    }

    public IDefenceIntegerValidation BePositive()
    {
        // I consider ZERO value is neither positive and negative ,so no error should thrown
        if (Input < 0)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Should be positive");

        return this;
    }

    public IDefenceIntegerValidation BeNegative()
    {
        // I consider ZERO value is neither positive and negative ,so no error should thrown
        if (Input > 0)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Should be negative");

        return this;
    }
}