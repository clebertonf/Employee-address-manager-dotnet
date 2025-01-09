using EmployeeAddressManager.Application.DTOS;
using EmployeeAddressManager.Domain.Entities;

namespace EmployeeAddressManager.Application.Interfaces;

public interface IEmployeeService
{
    Task<IEnumerable<EmployeeDto>> GetEmployeesAsync();
    Task<EmployeeDto> GetEmployeeByIdAsync(int id);
    Task<EmployeeDto> CreateEmployeeAsync(EmployeeDto employee);
    Task<EmployeeDto> UpdateEmployeeAsync(EmployeeDto employee);
    Task<EmployeeDto> DeleteEmployeeAsync(int id);
}