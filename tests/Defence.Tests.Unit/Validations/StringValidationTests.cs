using System.Threading.Tasks;
using AutoFixture;
using FluentAssertions;
using NSubstitute;
using Defence.Core.Exceptions;
using Defence.Core.Handlers.Internals.Abstractions;
using Defence.Core.Validations.Internals;
using Defence.Handlers.Internals;
using Xunit;

namespace Defence.Tests.Unit.Validations;

public class StringValidationTests
{
    
    [Theory]
    [InlineData(null),InlineData("")]
    public async Task Should_throw_with_wrong_input_on_NotBeNullOrEmpty(string input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();
        
        var validator = new StringValidation(fakeField, input, defenceErrorHandler);
        
        var result = () => validator.NotBeNullOrEmpty();
        
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be not null or empty");
    }
    
    
    [Theory]
    [InlineData("input"),InlineData(" ")]
    public async Task Should_not_throw_with_correct_input_on_NotBeNullOrEmpty(string input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();
        
        var validator = new StringValidation(fakeField, input, defenceErrorHandler);
        
        var result = () => validator.NotBeNullOrEmpty();

        result.Should().NotThrow();
    }
    
    [Theory]
    [InlineData(" "),InlineData("input")]
    public async Task Should_throw_with_wrong_input_on_BeNullOrEmpty(string input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();
        
        var validator = new StringValidation(fakeField, input, defenceErrorHandler);
        
        var result = () => validator.BeNullOrEmpty();
        
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be null or empty");

    }
    
    [Theory]
    [InlineData(null),InlineData("")]
    public async Task Should_not_throw_with_correct_input_on_BeNullOrEmpty(string input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();
        
        var validator = new StringValidation(fakeField, input, defenceErrorHandler);
        
        var result = () => validator.BeNullOrEmpty();

        result.Should().NotThrow();
    }
    
    
    
    [Theory]
    [InlineData(null),InlineData(" "),InlineData("")]
    public async Task Should_throw_with_wrong_input_on_NotBeNullOrWhiteSpaceOrEmpty(string input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();
        
        var validator = new StringValidation(fakeField, input, defenceErrorHandler);
        
        var result = () => validator.NotBeNullOrWhiteSpaceOrEmpty();
        
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must not be null or whitespace or empty");
    }
    
    [Fact]
    public async Task Should_not_throw_with_correct_input_on_NotBeNullOrWhiteSpaceOrEmpty()
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();
        
        var validator = new StringValidation(fakeField, "input", defenceErrorHandler);
        
        var result = () => validator.NotBeNullOrWhiteSpaceOrEmpty();

        result.Should().NotThrow();
    }
    
    [Fact]
    public async Task Should_throw_with_wrong_input_on_BeNullOrWhiteSpaceOrEmpty()
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();
        
        var validator = new StringValidation(fakeField, "input", defenceErrorHandler);
        
        var result = () => validator.BeNullOrWhiteSpaceOrEmpty();
        
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be null or whitespace or empty");
    }
    
    [Theory]
    [InlineData(null),InlineData(" "),InlineData("")]
    public async Task Should_not_throw_with_correct_input_on_BeNullOrWhiteSpaceOrEmpty(string input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();
        
        var validator = new StringValidation(fakeField, input, defenceErrorHandler);
        
        var result = () => validator.BeNullOrWhiteSpaceOrEmpty();

        result.Should().NotThrow();
    }
    
    
    
    
    [Theory]
    [InlineData(null,"hey")]
    public async Task Should_throw_with_null_input_on_BeEqual(string input , string expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();
        
        var validator = new StringValidation(fakeField, input, defenceErrorHandler);
        
        var result = () => validator.BeEqual(expectedValue);
        
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be equal to {expectedValue} But it is Null");
    }
    
    [Theory]
    [InlineData("not hey","hey")]
    public async Task Should_throw_with_wrong_input_on_BeEqual(string input , string expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();
        
        var validator = new StringValidation(fakeField, input, defenceErrorHandler);
        
        var result = () => validator.BeEqual(expectedValue);
        
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be equal to {expectedValue}");
    }
    
    [Theory]
    [InlineData("hey","hey")]
    public async Task Should_not_throw_with_correct_input_on_BeEqual(string input , string expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();
        
        var validator = new StringValidation(fakeField, input, defenceErrorHandler);
        
        var result = () => validator.BeEqual(expectedValue);

        result.Should().NotThrow();
    }
    
    [Fact]
    public async Task Should_throw_with_wrong_input_on_HaveExactLength()
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();
        
        var validator = new StringValidation(fakeField, "input", defenceErrorHandler);
        
        var result = () => validator.HaveExactLength(10);
        
        result.Should().ThrowExactly<DefenceBadRequestException>();
    }
    
    [Fact]
    public async Task Should_not_throw_with_correct_input_on_HaveExactLength()
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();
        
        var validator = new StringValidation(fakeField, "input", defenceErrorHandler);
        
        var result = () => validator.HaveExactLength(5);

        result.Should().NotThrow();
    }
    
    [Fact]
    public async Task Should_throw_with_wrong_input_on_HaveGreaterLength()
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();
        
        var validator = new StringValidation(fakeField, "input", defenceErrorHandler);
        
        var result = () => validator.HaveGreaterLength(10);
        
        result.Should().ThrowExactly<DefenceBadRequestException>();
    }
    
    [Fact]
    public async Task Should_not_throw_with_correct_input_on_HaveGreaterLength()
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();
        
        var validator = new StringValidation(fakeField, "input_extra", defenceErrorHandler);
        
        var result = () => validator.HaveGreaterLength(5);

        result.Should().NotThrow();
    }

}