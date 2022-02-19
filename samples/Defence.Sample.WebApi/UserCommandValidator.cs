using Defence.Abstractions;
using Defence.Validations.Extensions.Double;
using Defence.Validations.Extensions.Integer;
using Defence.Validations.Extensions.Long;
using Defence.Validations.Extensions.String;
using Defence.Validations.Extensions.StringCollection;

namespace Defence.Sample.WebApi;

public class UserCommandValidator : IDefenceValidator<UserCommand>
{
    public Task Validate(UserCommand input)
    {
        input.StringExample.Must(nameof(input.StringExample)).BeEqual("hi");
        input.IntegerExample.Must(nameof(input.IntegerExample)).BeEqual(1);
        input.NIntegerExample.Must(nameof(input.NIntegerExample)).BeEqual(2);
        input.DoubleExample.Must(nameof(input.DoubleExample)).BeEqual(1.42);
        input.NDoubleExample.Must(nameof(input.NDoubleExample)).BeGreaterThan(1.56).BePositive();
        input.LongExample.Must(nameof(input.LongExample)).BeGreaterThan(5).BePositive();
        input.NLongExample.Must(nameof(input.LongExample)).BePositive();
        input.StringCollectionExample.Must(nameof(input.StringCollectionExample)).Contains("hi");
        
        return Task.CompletedTask;
    }
}