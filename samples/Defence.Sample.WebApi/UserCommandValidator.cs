using Defence.Abstractions;
using Defence.Validations.CollectionExtensions;
using Defence.Validations.Extensions;


namespace Defence.Sample.WebApi;

public class UserCommandValidator : IDefenceValidator<UserCommand>
{
    public Task Validate(UserCommand input)
    {
        input.BoolExample.Must(nameof(input.BoolExample)).BeEqual(true);
        input.ByteExample.Must(nameof(input.ByteExample)).BeGreaterThan((byte)1);
        input.CharExample.Must(nameof(input.CharExample)).BeEqual('x');
        input.DecimalExample.Must(nameof(input.DecimalExample)).BeLessThan(2);
        input.DoubleExample.Must(nameof(input.DoubleExample)).BeGreaterThan(3.3);
        input.NLongExample.Must(nameof(input.NLongExample)).BePositive();
        input.NShortExample.Must(nameof(input.NShortExample)).BeNegative();
        input.NuShortExample.Must(nameof(input.NuShortExample)).BeEqual((ushort)2);
        input.NsByteExample.Must(nameof(input.NsByteExample)).BeEqual((sbyte)1);


        input.StringCollectionExample.Must(nameof(input.StringCollectionExample)).NotBeEmpty();
        
        
        return Task.CompletedTask;
    }
    
}
 