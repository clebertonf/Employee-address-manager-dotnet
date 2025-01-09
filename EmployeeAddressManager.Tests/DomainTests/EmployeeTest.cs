using EmployeeAddressManager.Domain.Entities;
using EmployeeAddressManager.Domain.Validation;
using FluentAssertions;

namespace EmployeeAddressManager.Tests.DomainTests;

public class EmployeeTest
{
    [Fact]
    public void CreateEmployee_WhithValidParams_ShouldCreateEmployee()
    {
        Action action = () => new Employee(1, "John Doe", "developer", new DateTime(2020, 01, 01));
        action.Should().NotThrow<DomainExceptionValidation>();
    }

    [Fact]
    public void CreateEmployee_WithInvalidName_NotShouldCreateEmployee()
    {
        var name = string.Empty;
        Action action = () => new Employee(1, name, "developer", DateTime.Now);
        action.Should().Throw<DomainExceptionValidation>().WithMessage($"{nameof(name)} cannot be null or empty.");
    }
    
    [Fact]
    public void CreateEmployee_WithInvalidRole_NotShouldCreateEmployee()
    {
        var role = string.Empty;
        Action action = () => new Employee(1, "John Doe", role, DateTime.Now);
        action.Should().Throw<DomainExceptionValidation>().WithMessage($"{nameof(role)} cannot be null or empty.");
    }
    
    [Fact]
    public void CreateEmployee_WithInvalidDate_NotShouldCreateEmployee()
    {
        var dateOfHiring = default(DateTime);
        Action action = () => new Employee(1, "John Doe", "developer", dateOfHiring);
        action.Should().Throw<DomainExceptionValidation>().WithMessage($"{nameof(dateOfHiring)} cannot be empty.");
    }
}