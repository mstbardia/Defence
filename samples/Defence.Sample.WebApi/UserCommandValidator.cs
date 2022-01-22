using Defence.Core;
using Defence.Core.Abstractions;

namespace Defence.Sample.WebApi;

public class UserCommandValidator : IDefenceValidator<UserCommand>
{
    public Task Validate(UserCommand input)
    {
        //input.Name.defenceFor(nameof(input.Name)).NotNull();
        
        
        input.Family.Must(nameof(input.Family)).HaveGreaterLength(2);
        
        input.Age.Must("d").LessThan(5);
        
         defence
        
        return Task.CompletedTask;
    }
}