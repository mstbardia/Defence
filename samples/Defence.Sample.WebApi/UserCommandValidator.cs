using Defence.Core;
using Defence.Core.Abstractions;

namespace Defence.Sample.WebApi;

public class UserCommandValidator : IDefenceValidator<UserCommand>
{
    public Task Validate(UserCommand input)
    {
        
        input.Family.Must(nameof(input.Family)).NotBeNullOrEmpty();
        
        input.Family.Must(nameof(input.Family)).HaveExactLength(5);

        input.Age.Must(nameof(input.Age)).BeLessThan(2);
        
        return Task.CompletedTask;
    }
}