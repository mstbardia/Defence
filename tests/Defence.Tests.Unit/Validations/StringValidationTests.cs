using System.Threading.Tasks;
using AutoFixture;
using FluentAssertions;
using NSubstitute;
using Defence.Core.Exceptions;
using Defence.Core.Handlers.Internals;
using Defence.Core.Handlers.Internals.Abstractions;
using Defence.Core.Validations.Internals;
using Xunit;

namespace Defence.Tests.Unit.Validations;

public class StringValidationTests
{
    [Theory]
    [InlineData(null), InlineData("")]
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
            .WithMessage($"{fakeField} : Must not be null or empty");
    }

    [Theory]
    [InlineData("input"), InlineData(" ")]
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
    [InlineData(" "), InlineData("input")]
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
    [InlineData(null), InlineData("")]
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
    [InlineData(null), InlineData(" "), InlineData("")]
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
    [InlineData(null), InlineData(" "), InlineData("")]
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
    [InlineData(null, "hey")]
    public async Task Should_throw_with_null_input_on_BeEqual(string input, string expectedValue)
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
    [InlineData("not hey", "hey")]
    public async Task Should_throw_with_wrong_input_on_BeEqual(string input, string expectedValue)
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
    [InlineData("hey", "hey")]
    public async Task Should_not_throw_with_correct_input_on_BeEqual(string input, string expectedValue)
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
    
    [Theory]
    [InlineData(null, 5)]
    public async Task Should_throw_with_null_input_on_HaveExactLength(string input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new StringValidation(fakeField, input, defenceErrorHandler);

        var result = () => validator.HaveExactLength(expectedValue);

        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must have exact length {expectedValue} But it is Null");
    }
    
    [Theory]
    [InlineData("hey", 5)]
    public async Task Should_throw_with_wrong_input_on_HaveExactLength(string input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new StringValidation(fakeField, input, defenceErrorHandler);

        var result = () => validator.HaveExactLength(expectedValue);

        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must have exact length {expectedValue}");
    }

    [Theory]
    [InlineData("hey", 3)]
    public async Task Should_not_throw_with_correct_input_on_HaveExactLength(string input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new StringValidation(fakeField, input, defenceErrorHandler);

        var result = () => validator.HaveExactLength(expectedValue);

        result.Should().NotThrow();
    }

    [Theory]
    [InlineData(null, 5)]
    public async Task Should_throw_with_null_input_on_HaveGreaterLength(string input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new StringValidation(fakeField, input, defenceErrorHandler);

        var result = () => validator.HaveGreaterLength(expectedValue);

        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must have greater length than {expectedValue} But it is Null");
    }

    [Theory]
    [InlineData("hey", 5), InlineData("hey", 3)]
    public async Task Should_throw_with_wrong_input_on_HaveGreaterLength(string input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new StringValidation(fakeField, input, defenceErrorHandler);

        var result = () => validator.HaveGreaterLength(expectedValue);

        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must have greater length than {expectedValue}");
    }

    [Theory]
    [InlineData("hey", 2)]
    public async Task Should_not_throw_with_correct_input_on_HaveGreaterLength(string input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new StringValidation(fakeField, input, defenceErrorHandler);

        var result = () => validator.HaveGreaterLength(expectedValue);

        result.Should().NotThrow();
    }

    [Theory]
    [InlineData(null)]
    public async Task Should_throw_with_wrong_input_on_NotBeNull(string input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new StringValidation(fakeField, input, defenceErrorHandler);

        // Act
        var result = () => validator.NotBeNull();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must not be null");
    }

    [Theory]
    [InlineData("hey")]
    public async Task Should_not_throw_with_correct_input_on_NotBeNull(string input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new StringValidation(fakeField, input, defenceErrorHandler);

        // Act
        var result = () => validator.NotBeNull();

        // Assert
        result.Should().NotThrow();
    }

    [Theory]
    [InlineData("hey")]
    public async Task Should_throw_with_wrong_input_on_BeNull(string input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new StringValidation(fakeField, input, defenceErrorHandler);

        // Act
        var result = () => validator.BeNull();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be null");
    }

    [Theory]
    [InlineData(null)]
    public async Task Should_not_throw_with_correct_input_on_BeNull(string input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new StringValidation(fakeField, input, defenceErrorHandler);

        // Act
        var result = () => validator.BeNull();

        // Assert
        result.Should().NotThrow();
    }
}