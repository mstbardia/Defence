using AutoFixture;
using Defence.Exceptions;
using Defence.Internals.Abstractions;
using Defence.Internals.Handlers;
using Defence.Validations;
using Defence.Validations.Extensions.Double;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace Defence.Tests.Unit.Validations;

public class NullableDoubleValidationTests
{
    [Theory]
    [InlineData(null, 5)]
    public void Should_throw_with_null_input_on_BeLessThan(int? input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeLessThan(expectedValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be less than {expectedValue} But it is Null");
    }

    [Theory]
    [InlineData(5.11, 5.11), InlineData(5.23, 5.21), InlineData(6, 5)]
    public void Should_throw_with_wrong_input_on_BeLessThan(double input, double expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeLessThan(expectedValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be less than {expectedValue}");
    }

    [Theory]
    [InlineData(4.231, 4.232)]
    public void Should_not_throw_with_correct_input_on_BeLessThan(double input, double expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeLessThan(expectedValue);

        // Assert
        result.Should().NotThrow();
    }


    [Theory]
    [InlineData(null, 5)]
    public void Should_throw_with_null_input_on_BeLessThanOrEqual(int? input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeLessThanOrEqual(expectedValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be less than or Equal to {expectedValue} But it is Null");
    }

    [Theory]
    [InlineData(6.23, 6.21)]
    public void Should_throw_with_wrong_input_on_BeLessThanOrEqual(double input, double expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeLessThanOrEqual(expectedValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be less than or Equal to {expectedValue}");
    }

    [Theory]
    [InlineData(5.556, 5.556), InlineData(4.32, 4.34), InlineData(4, 5)]
    public void Should_not_throw_with_correct_input_on_BeLessThanOrEqual(double input, double expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeLessThanOrEqual(expectedValue);

        // Assert
        result.Should().NotThrow();
    }


    [Theory]
    [InlineData(null, 5)]
    public void Should_throw_with_null_input_on_BeGreaterThan(int? input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeGreaterThan(expectedValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be greater than {expectedValue} But it is Null");
    }

    [Theory]
    [InlineData(5.23, 5.23), InlineData(5.11, 5.14), InlineData(4, 5)]
    public void Should_throw_with_wrong_input_on_BeGreaterThan(double input, double expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeGreaterThan(expectedValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be greater than {expectedValue}");
    }

    [Theory]
    [InlineData(6.2, 6.1), InlineData(4, 3)]
    public void Should_not_throw_with_correct_input_on_BeGreaterThan(double input, double expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeGreaterThan(expectedValue);

        // Assert
        result.Should().NotThrow();
    }


    [Theory]
    [InlineData(null, 5)]
    public void Should_throw_with_null_input_on_BeGreaterThanOrEqual(int? input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeGreaterThanOrEqual(expectedValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be greater than or Equal to {expectedValue} But it is Null");
    }

    [Theory]
    [InlineData(4.23, 4.25), InlineData(3, 4)]
    public void Should_throw_with_wrong_input_on_BeGreaterThanOrEqual(double input, double expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeGreaterThanOrEqual(expectedValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be greater than or Equal to {expectedValue}");
    }

    [Theory]
    [InlineData(5.16, 5.16), InlineData(4, 4), InlineData(5, 4), InlineData(5.15, 5.14)]
    public void Should_not_throw_with_correct_input_on_BeGreaterThanOrEqual(double input, double expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeGreaterThanOrEqual(expectedValue);

        // Assert
        result.Should().NotThrow();
    }


    [Theory]
    [InlineData(null, 5)]
    public void Should_throw_with_null_input_on_BeEqual(int? input, int expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeEqual(expectedValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be equal to {expectedValue} But it is Null");
    }

    [Theory]
    [InlineData(4.14, 4.15), InlineData(6, 5)]
    public void Should_throw_with_wrong_input_on_BeEqual(double input, double expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeEqual(expectedValue);

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be equal to {expectedValue}");
    }

    [Theory]
    [InlineData(5.262, 5.262),InlineData(4,4)]
    public void Should_not_throw_with_correct_input_on_BeEqual(double input, double expectedValue)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeEqual(expectedValue);

        // Assert
        result.Should().NotThrow();
    }


    [Theory]
    [InlineData(null)]
    public void Should_throw_with_null_input_on_BePositive(double? input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BePositive();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be positive But it is Null");
    }

    [Theory]
    [InlineData(-1.25), InlineData(-1)]
    public void Should_throw_with_wrong_input_on_BePositive(int input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BePositive();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be positive");
    }

    [Theory]
    [InlineData(5.556), InlineData(4), InlineData(0)]
    public void Should_not_throw_with_correct_input_on_BePositive(int input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BePositive();

        // Assert
        result.Should().NotThrow();
    }


    [Theory]
    [InlineData(null)]
    public void Should_throw_with_null_input_on_BeNegative(double? input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeNegative();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be negative But it is Null");
    }

    [Theory]
    [InlineData(1.236), InlineData(1)]
    public void Should_throw_with_wrong_input_on_BeNegative(double? input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeNegative();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be negative");
    }

    [Theory]
    [InlineData(-5.233), InlineData(-4), InlineData(0)]
    public void Should_not_throw_with_correct_input_on_BeNegative(double? input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeNegative();

        // Assert
        result.Should().NotThrow();
    }

    [Theory]
    [InlineData(null)]
    public void Should_throw_with_wrong_input_on_NotBeNull(double? input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.NotBeNull();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must not be null");
    }

    [Theory]
    [InlineData(5.45)]
    public void Should_not_throw_with_correct_input_on_NotBeNull(int input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.NotBeNull();

        // Assert
        result.Should().NotThrow();
    }

    [Theory]
    [InlineData(5.33)]
    public void Should_throw_with_wrong_input_on_BeNull(double? input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeNull();

        // Assert
        result.Should().ThrowExactly<DefenceBadRequestException>()
            .WithMessage($"{fakeField} : Must be null");
    }

    [Theory]
    [InlineData(null)]
    public void Should_not_throw_with_correct_input_on_BeNull(double? input)
    {
        // Arrange
        var defenceContextHandler = Substitute.For<IDefenceContextHandler>();
        defenceContextHandler.GetRequestTraceId().Returns(new Fixture().Create<string>());
        defenceContextHandler.ShouldThrowExceptions().Returns(true);
        var defenceErrorHandler = new DefenceErrorHandler(defenceContextHandler);
        var fakeField = new Fixture().Create<string>();

        var validator = new NullableDoubleValidation(new DefenceProperty<double?>(fakeField, input), defenceErrorHandler);

        // Act
        var result = () => validator.BeNull();

        // Assert
        result.Should().NotThrow();
    }
}