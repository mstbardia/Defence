using Defence.Abstractions;
using Defence.Validations.Extensions.Double;
using Defence.Validations.Extensions.Integer;
using Defence.Validations.Extensions.Long;

namespace Defence.Sample.WebApi;

public class UserCommandValidator : IDefenceValidator<UserCommand>
{
    public Task Validate(UserCommand input)
    {


        input.Double.Must(nameof(input.Double)).BeEqual(1.42);
        
        input.NDouble.Must(nameof(input.NDouble)).BeGreaterThan(1.56).BePositive();
        
        
        input.Long.Must(nameof(input.Long)).BeGreaterThan(5).BePositive();
        
        input.NLong.Must(nameof(input.Long)).BePositive();
          
        
        return Task.CompletedTask;
         
        
    }
}