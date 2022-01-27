using Defence.Core.Handlers.Internals.Abstractions;
using Defence.Core.Internals;
using Defence.Core.Validations.Abstractions;

namespace Defence.Core.Validations.Internals;

/// <summary>
/// implementation of <see cref="IIntegerValidation" />
/// </summary>
internal class IntegerValidation : DefenceProperty<int>, IIntegerValidation
{
    private readonly IDefenceErrorHandler _defenceErrorHandler;
    
    public IntegerValidation(string fieldName, int input , IDefenceErrorHandler defenceErrorHandler) : base(fieldName, input)
    {
        _defenceErrorHandler = defenceErrorHandler;
    }


    public IIntegerValidation BeLessThan(int value)
    {
        if (Input >= value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be less than {value}");

        return this;
    }

    public IIntegerValidation BeLessThanOrEqual(int value)
    {
        if (Input > value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be less than or Equal to {value}");

        return this;
    }

    public IIntegerValidation BeGreaterThan(int value)
    {
        if (Input <= value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be greater than {value}");

        return this;
    }

    public IIntegerValidation BeGreaterThanOrEqual(int value)
    {
        if (Input < value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be greater than or Equal to {value}");

        return this;
    }

    public IIntegerValidation BeEqual(int value)
    {
        if (Input != value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be equal to {value}");

        return this;
    }

    public IIntegerValidation BePositive()
    {
        // I consider ZERO value is neither positive and negative ,so no error Must thrown
        if (Input < 0)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be positive");

        return this;
    }

    public IIntegerValidation BeNegative()
    {
        // I consider ZERO value is neither positive and negative ,so no error Must thrown
        if (Input > 0)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be negative");

        return this;
    }
}