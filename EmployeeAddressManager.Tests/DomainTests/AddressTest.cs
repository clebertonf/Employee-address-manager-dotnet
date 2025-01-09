using EmployeeAddressManager.Domain.Entities;
using EmployeeAddressManager.Domain.Validation;
using FluentAssertions;

namespace EmployeeAddressManager.Tests.DomainTests;

public class AddressTest
{
    [Fact]
    public void CreateAdress_WhithValidParams_ShouldCreateAdress()
    {
        Action action = () => new Address(1, "Street 123", "City 123", "State 123");
        action.Should().NotThrow<DomainExceptionValidation>();
    }

    [Fact]
    public void CreateAdress_WithInvalidStreet_NotShouldCreateAdress()
    {
        var street = string.Empty;
        Action action = () => new Address(1, street, "City 123", "State 123");
        action.Should().Throw<DomainExceptionValidation>().WithMessage($"{nameof(street)} cannot be null or empty.");
    }
    
    [Fact]
    public void CreateAdress_WithInvalidCity_NotShouldCreateAdress()
    {
        var city = string.Empty;
        Action action = () => new Address(1, "Street 123", city, "State 123");
        action.Should().Throw<DomainExceptionValidation>().WithMessage($"{nameof(city)} cannot be null or empty.");

    }
    
    [Fact]
    public void CreateAdress_WithInvalidState_NotShouldCreateAdress()
    {
        var state = string.Empty;
        Action action = () => new Address(1, "Street 123", "City 123", state);
        action.Should().Throw<DomainExceptionValidation>().WithMessage($"{nameof(state)} cannot be null or empty.");
    }
}