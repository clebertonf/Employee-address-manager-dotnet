using AutoMapper;
using EmployeeAddressManager.Application.DTOS;
using EmployeeAddressManager.Application.Interfaces;
using EmployeeAddressManager.Domain.Entities;
using EmployeeAddressManager.Domain.Interfaces;

namespace EmployeeAddressManager.Application.Services;

public class AddressService : IAddressService
{
    private readonly IAddressRepository _addressRepository;
    private readonly IMapper _mapper;

    public AddressService(IAddressRepository addressRepository, IMapper mapper)
    {
        _addressRepository = addressRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<AddressDto>> GetAddressesAsync()
    {
        var address = await _addressRepository.GetAddressesAsync();
        return _mapper.Map<IEnumerable<AddressDto>>(address);
    }

    public async Task<AddressDto> GetAddressByIdAsync(int id)
    {
        var address = await _addressRepository.GetAddressByIdAsync(id);
        return _mapper.Map<AddressDto>(address);
    }

    public async Task<AddressDto> CreateAddressAsync(AddressDto addressDto)
    {
        var address = _mapper.Map<Address>(addressDto);
        await _addressRepository.CreateAddressAsync(address);
        return _mapper.Map<AddressDto>(address);
    }

    public async Task<AddressDto> UpdateAddressAsync(AddressDto addressDto)
    {
        var address = _mapper.Map<Address>(addressDto);
        await _addressRepository.UpdateAddressAsync(address);
        return _mapper.Map<AddressDto>(address);
    }

    public async Task<AddressDto> DeleteAddressAsync(int id)
    {
       var address = await _addressRepository.DeleteAddressAsync(id);
       return _mapper.Map<AddressDto>(address);
    }
}