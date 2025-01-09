using AutoMapper;
using EmployeeAddressManager.Application.DTOS;
using EmployeeAddressManager.Domain.Entities;

namespace EmployeeAddressManager.Application.Mappings;

public class DomainToDtoMappingProfile : Profile
{
    public DomainToDtoMappingProfile()
    {
        CreateMap<Address, AddressDto>().ReverseMap();
        CreateMap<Employee, EmployeeDto>().ReverseMap();
    }
}