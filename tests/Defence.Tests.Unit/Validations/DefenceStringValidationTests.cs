using System.Threading.Tasks;
using AutoFixture;
using FluentAssertions;
using NSubstitute;
using Defence.Core.Exceptions;
using Defence.Core.Handlers.Internals.Abstractions;
using Defence.Core.Validations.Internals;
using Xunit;

namespace Defence.Tests.Unit.Validations;

public class DefenceStringValidationTests
{
    
    [Theory]
    [InlineData(null),InlineData("")]
    public async Task Should_throw_with_wrong_input_on_NotBeNullOrEmpty(string input)
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceStringValidation(fakeField, input, defenceErrorHandler);
        
        var result = () => validator.NotBeNullOrEmpty();
        
        result.Should().ThrowExactly<DefenceBadRequestException>();
    }
    
    [Theory]
    [InlineData("input"),InlineData(" ")]
    public async Task Should_not_throw_with_correct_input_on_NotBeNullOrEmpty(string input)
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceStringValidation(fakeField, input, defenceErrorHandler);
        
        var result = () => validator.NotBeNullOrEmpty();

        result.Should().NotThrow();
    }
    
    [Theory]
    [InlineData(" "),InlineData("input")]
    public async Task Should_throw_with_wrong_input_on_BeNullOrEmpty(string input)
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceStringValidation(fakeField, input, defenceErrorHandler);
        
        var result = () => validator.BeNullOrEmpty();
        
        result.Should().ThrowExactly<DefenceBadRequestException>();
    }
    
    [Theory]
    [InlineData(null),InlineData("")]
    public async Task Should_not_throw_with_correct_input_on_BeNullOrEmpty(string input)
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceStringValidation(fakeField, input, defenceErrorHandler);
        
        var result = () => validator.BeNullOrEmpty();

        result.Should().NotThrow();
    }
    
    [Theory]
    [InlineData(null),InlineData(" "),InlineData("")]
    public async Task Should_throw_with_wrong_input_on_NotBeNullOrWhiteSpaceOrEmpty(string input)
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceStringValidation(fakeField, input, defenceErrorHandler);
        
        var result = () => validator.NotBeNullOrWhiteSpaceOrEmpty();
        
        result.Should().ThrowExactly<DefenceBadRequestException>();
    }
    
    [Fact]
    public async Task Should_not_throw_with_correct_input_on_NotBeNullOrWhiteSpaceOrEmpty()
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceStringValidation(fakeField, "input", defenceErrorHandler);
        
        var result = () => validator.NotBeNullOrWhiteSpaceOrEmpty();

        result.Should().NotThrow();
    }
    
    [Fact]
    public async Task Should_throw_with_wrong_input_on_BeNullOrWhiteSpaceOrEmpty()
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceStringValidation(fakeField, "input", defenceErrorHandler);
        
        var result = () => validator.BeNullOrWhiteSpaceOrEmpty();
        
        result.Should().ThrowExactly<DefenceBadRequestException>();
    }
    
    [Theory]
    [InlineData(null),InlineData(" "),InlineData("")]
    public async Task Should_not_throw_with_correct_input_on_BeNullOrWhiteSpaceOrEmpty(string input)
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceStringValidation(fakeField, input, defenceErrorHandler);
        
        var result = () => validator.BeNullOrWhiteSpaceOrEmpty();

        result.Should().NotThrow();
    }
    
    [Fact]
    public async Task Should_throw_with_wrong_input_on_BeEqual()
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceStringValidation(fakeField, "input", defenceErrorHandler);
        
        var result = () => validator.BeEqual("NotInput");
        
        result.Should().ThrowExactly<DefenceBadRequestException>();
    }
    
    [Fact]
    public async Task Should_not_throw_with_correct_input_on_BeEqual()
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceStringValidation(fakeField, "input", defenceErrorHandler);
        
        var result = () => validator.BeEqual("input");

        result.Should().NotThrow();
    }
    
    [Fact]
    public async Task Should_throw_with_wrong_input_on_HaveExactLength()
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceStringValidation(fakeField, "input", defenceErrorHandler);
        
        var result = () => validator.HaveExactLength(10);
        
        result.Should().ThrowExactly<DefenceBadRequestException>();
    }
    
    [Fact]
    public async Task Should_not_throw_with_correct_input_on_HaveExactLength()
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceStringValidation(fakeField, "input", defenceErrorHandler);
        
        var result = () => validator.HaveExactLength(5);

        result.Should().NotThrow();
    }
    
    [Fact]
    public async Task Should_throw_with_wrong_input_on_HaveGreaterLength()
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceStringValidation(fakeField, "input", defenceErrorHandler);
        
        var result = () => validator.HaveGreaterLength(10);
        
        result.Should().ThrowExactly<DefenceBadRequestException>();
    }
    
    [Fact]
    public async Task Should_not_throw_with_correct_input_on_HaveGreaterLength()
    {
        var defenceErrorHandler = Substitute.For<IDefenceErrorHandler>();
        var fakeField = new Fixture().Create<string>();

        defenceErrorHandler.When(c => c.CreateCurrentRequestError(Arg.Any<string>(), Arg.Any<string>()))
            .Throw(new DefenceBadRequestException());
        
        var validator = new DefenceStringValidation(fakeField, "input_extra", defenceErrorHandler);
        
        var result = () => validator.HaveGreaterLength(5);

        result.Should().NotThrow();
    }

}