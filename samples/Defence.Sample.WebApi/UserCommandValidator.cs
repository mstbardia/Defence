using Defence.Core;
using Defence.Core.Abstractions;

namespace Defence.Sample.WebApi;

public class UserCommandValidator : IDefenceValidator<UserCommand>
{
    public Task Validate(UserCommand input)
    {
        
        // input.Family.Must(nameof(input.Family)).NotBeNullOrEmpty();
        //
        //
        // input.Age.Must(nameof(input.Age))
        //


        
         
        input.Family.Must(nameof(input.Family)).HaveExactLength(5);

            
        input.DD.Must("DD").BeLessThan(5);
            
        return Task.CompletedTask;
    }
}