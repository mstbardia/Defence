using Defence.Core.Handlers.Internals.Abstractions;
using Defence.Core.Internals;
using Defence.Core.Validations.Abstractions;
using Defence.Core.Validations.Abstractions.Nullables.Base;

namespace Defence.Core.Validations.Internals;

/// <summary>
/// implementation of <see cref="IStringValidation" />
/// </summary>
internal class StringValidation : DefenceProperty<string>, IStringValidation, INullValidation<IStringValidation>
{
    private readonly IDefenceErrorHandler _defenceErrorHandler;

    public StringValidation(string fieldName, string input, IDefenceErrorHandler defenceErrorHandler) : base(fieldName,
        input)
    {
        _defenceErrorHandler = defenceErrorHandler;
    }

    public IStringValidation NotBeNullOrWhiteSpaceOrEmpty()
    {
        if (string.IsNullOrWhiteSpace(Input))
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must not be null or whitespace or empty");

        return this;
    }

    public IStringValidation BeNullOrWhiteSpaceOrEmpty()
    {
        if (!string.IsNullOrWhiteSpace(Input))
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be null or whitespace or empty");

        return this;
    }

    public IStringValidation NotBeNullOrEmpty()
    {
        if (string.IsNullOrEmpty(Input))
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must not be null or empty");

        return this;
    }

    public IStringValidation BeNullOrEmpty()
    {
        if (!string.IsNullOrEmpty(Input))
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be null or empty");

        return this;
    }

    public IStringValidation BeEqual(string value)
    {
        if (Input == null)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be equal to {value} But it is Null");
        else if (Input != value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be equal to {value}");

        return this;
    }

    public IStringValidation HaveExactLength(int value)
    {
        if (Input == null)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must have exact length {value} But it is Null");
        else if (Input.Length != value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must have exact length {value}");

        return this;
    }


    public IStringValidation HaveGreaterLength(int value)
    {
        if (Input == null)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName,
                $"Must have greater length than {value} But it is Null");
        else if (Input.Length <= value)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must have greater length than {value}");

        return this;
    }

    public IStringValidation NotBeNull()
    {
        if (Input == null)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must not be null");

        return this;
    }

    public IStringValidation BeNull()
    {
        if (Input != null)
            _defenceErrorHandler.CreateCurrentRequestError(FieldName, $"Must be null");

        return this;
    }
}