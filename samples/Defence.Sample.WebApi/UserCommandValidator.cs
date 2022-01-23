using Defence.Core;
using Defence.Core.Abstractions;

namespace Defence.Sample.WebApi;

public class UserCommandValidator : IDefenceValidator<UserCommand>
{
    public Task Validate(UserCommand input)
    {
        input.Family.Must(nameof(input.Family)).HaveGreaterLength(2);
         
           
        return Task.CompletedTask;
    }
}