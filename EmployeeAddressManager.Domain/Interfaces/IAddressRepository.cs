using EmployeeAddressManager.Domain.Entities;

namespace EmployeeAddressManager.Domain.Interfaces;

public interface IAddressRepository
{
    Task<IEnumerable<Address>> GetAddressesAsync();
    Task<Address> GetAddressByIdAsync(int id);
    Task<Address> CreateAddressAsync(Address address);
    Task<Address> UpdateAddressAsync(Address address);
    Task<Address> DeleteAddressAsync(Address address);
}