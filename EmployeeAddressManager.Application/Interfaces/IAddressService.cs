using EmployeeAddressManager.Application.DTOS;
using EmployeeAddressManager.Domain.Entities;

namespace EmployeeAddressManager.Application.Interfaces;

public interface IAddressService
{
    Task<IEnumerable<AddressDto>> GetAddressesAsync();
    Task<AddressDto> GetAddressByIdAsync(int id);
    Task<AddressDto> CreateAddressAsync(AddressDto address);
    Task<AddressDto> UpdateAddressAsync(AddressDto address);
    Task<AddressDto> DeleteAddressAsync(int id);
}