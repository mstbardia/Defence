using Defence.Core.Handlers.Internals.Abstractions;
using Defence.Core.Internals;
using Defence.Core.Validations.Abstractions;

namespace Defence.Core.Validations.Internals;

/// <summary>
/// implementation of <see cref="IDefenceStringValidation" />
/// </summary>
internal class  DefenceStringValidation : DefenceProperty<string> , IDefenceStringValidation
{
    private readonly IDefenceErrorHandler _defenceErrorHandler;
    
    public DefenceStringValidation(string fieldName, string input , IDefenceErrorHandler defenceErrorHandler) : base(fieldName, input)
    {
        _defenceErrorHandler = defenceErrorHandler;
    }

    
    public IDefenceStringValidation NotBeNullOrWhiteSpaceOrEmpty()
    {
        if (string.IsNullOrWhiteSpace(Input))
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be not be null or whitespace");

        return this;
    }

    public IDefenceStringValidation BeNullOrWhiteSpaceOrEmpty()
    {
        if (!string.IsNullOrWhiteSpace(Input))
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be null or whitespace");

        return this;
    }

    public IDefenceStringValidation NotBeNullOrEmpty()
    {
        if (string.IsNullOrEmpty(Input))
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be not null or empty");

        return this;
    }
    
    public IDefenceStringValidation BeNullOrEmpty()
    {
        if (!string.IsNullOrEmpty(Input))
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be null or empty");

        return this;
    }

    public IDefenceStringValidation BeEqual(string value)
    {
        if (Input != value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be equal to {value}");

        return this;
    }

    public IDefenceStringValidation HaveExactLength(int value)
    {
        if (Input?.Length != value || Input == null)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must have exact length : {value}");

        return this;
    }


    public IDefenceStringValidation HaveGreaterLength(int value)
    {
        if (Input?.Length <= value || Input == null)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must have greater length than {value}");

        return this;
    }
}