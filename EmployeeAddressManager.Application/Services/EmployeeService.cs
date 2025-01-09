using AutoMapper;
using EmployeeAddressManager.Application.DTOS;
using EmployeeAddressManager.Application.Interfaces;
using EmployeeAddressManager.Domain.Entities;
using EmployeeAddressManager.Domain.Interfaces;

namespace EmployeeAddressManager.Application.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

    public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<EmployeeDto>> GetEmployeesAsync()
    {
       var employees = await _employeeRepository.GetEmployeesAsync();
       return _mapper.Map<IEnumerable<EmployeeDto>>(employees);
    }

    public async Task<EmployeeDto> GetEmployeeByIdAsync(int id)
    {
        var employee = await _employeeRepository.GetEmployeeByIdAsync(id);
        return _mapper.Map<EmployeeDto>(employee);
    }

    public async Task<EmployeeDto> CreateEmployeeAsync(EmployeeDto employeeDto)
    {
        var employeeEntity = _mapper.Map<Employee>(employeeDto);
        await _employeeRepository.CreateEmployeeAsync(employeeEntity);
        return _mapper.Map<EmployeeDto>(employeeEntity);
    }

    public async Task<EmployeeDto> UpdateEmployeeAsync(EmployeeDto employeeDto)
    {
        var employeeEntity = _mapper.Map<Employee>(employeeDto);
        await _employeeRepository.UpdateEmployeeAsync(employeeEntity);
        return _mapper.Map<EmployeeDto>(employeeEntity);
    }

    public async Task<EmployeeDto> DeleteEmployeeAsync(int id)
    {
        var employeeEntity = await _employeeRepository.GetEmployeeByIdAsync(id);
        return _mapper.Map<EmployeeDto>(employeeEntity);
    }
}