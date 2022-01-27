using Defence.Core.Handlers.Internals.Abstractions;
using Defence.Core.Internals;
using Defence.Core.Validations.Abstractions;
using Defence.Core.Validations.Abstractions.Nullables;

namespace Defence.Core.Validations.Internals.Nullables;

internal class NullableIntegerValidation : DefenceProperty<int?>, INullableIntegerValidation
{
    private readonly IDefenceErrorHandler _defenceErrorHandler;

    public NullableIntegerValidation(string fieldName, int? input, IDefenceErrorHandler defenceErrorHandler) : base(
        fieldName, input)
    {
        _defenceErrorHandler = defenceErrorHandler;
    }

    public IIntegerValidation BeLessThan(int value)
    {
        if (Input == null)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be less than {value} But it is Null");
        else if (Input >= value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be less than {value}");
      
        return this;
    }

    public IIntegerValidation BeLessThanOrEqual(int value)
    {
        if (Input == null)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be less than or Equal to {value} But it is Null");
        else if (Input > value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be less than or Equal to {value}");
     
        return this;
    }

    public IIntegerValidation BeGreaterThan(int value)
    {
        if (Input == null)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be greater than {value} But it is Null");
        else if (Input <= value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be greater than {value}");
  
        return this;
    }

    public IIntegerValidation BeGreaterThanOrEqual(int value)
    {
        if (Input < value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be greater than or Equal to {value}");
        else if (Input == null)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be greater than or Equal to {value} But it is Null");
    
        return this;
    }

    public IIntegerValidation BeEqual(int value)
    {
        if (Input == null)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be equal to {value} But it is Null");
        else if (Input != value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be equal to {value}");
      
        return this;
    }

    public IIntegerValidation BePositive()
    {
        switch (Input)
        {
            // I consider ZERO value is neither positive and negative ,so no error Must thrown
            case < 0:
                _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be positive");
                break;
            case null:
                _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be positive But it is Null");
                break;
        }

        return this;
    }

    public IIntegerValidation BeNegative()
    {
        switch (Input)
        {
            // I consider ZERO value is neither positive and negative ,so no error Must thrown
            case > 0:
                _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be negative");
                break;
            case null:
                _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be negative But it is Null");
                break;
        }

        return this;
    }

    public IIntegerValidation NotBeNull()
    {
        if (!Input.HasValue)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must not be null");

        return this;
    }

    public IIntegerValidation BeNull()
    {
        if (Input.HasValue)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be null");

        return this;
    }
}