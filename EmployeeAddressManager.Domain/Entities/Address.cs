using EmployeeAddressManager.Domain.Validation;

namespace EmployeeAddressManager.Domain.Entities;

public class Address : BaseEntity
{
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public int EmployeeId { get; set; }

    public Address(string street, string city, string state)
    {
        ValidateDomian(street, city, state);
    }
    
    public Address(int id, string street, string city, string state)
    {
        ValidateDomian(street, city, state);
        Id = id;
    }
    
    private void ValidateDomian(string? street, string? city, string? state)
    {
        DomainExceptionValidation.When(string.IsNullOrWhiteSpace(street), $"{nameof(street)} cannot be null or empty.");
        DomainExceptionValidation.When(string.IsNullOrWhiteSpace(city), $"{nameof(city)} cannot be null or empty.");
        DomainExceptionValidation.When(string.IsNullOrWhiteSpace(state), $"{nameof(state)} cannot be null or empty.");
        
        Street = street;
        City = city;
        State = state;
    }
}