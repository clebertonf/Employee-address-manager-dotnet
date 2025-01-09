using EmployeeAddressManager.Domain.Validation;

namespace EmployeeAddressManager.Domain.Entities;

public sealed class Employee : BaseEntity
{
    public string Name { get; set; }
    public string Role { get; set; }
    public DateTime  DateOfHiring { get; set; }

    public Employee(string name, string role, DateTime dateOfHiring)
    {
        ValidateDomain(name, role, dateOfHiring);
    }
    
    public Employee(int id, string name, string role, DateTime dateOfHiring)
    {
        ValidateDomain(name, role, dateOfHiring);
        Id = id;
    }

    private void ValidateDomain(string name, string role, DateTime dateOfHiring)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name), $"{nameof(name)} cannot be null or empty.");
        DomainExceptionValidation.When(string.IsNullOrEmpty(role), $"{nameof(role)} cannot be null or empty.");
        DomainExceptionValidation.When(dateOfHiring == default(DateTime), $"{nameof(dateOfHiring)} cannot be empty.");
        
        Name = name;
        Role = role;
        DateOfHiring = dateOfHiring;
    }
}