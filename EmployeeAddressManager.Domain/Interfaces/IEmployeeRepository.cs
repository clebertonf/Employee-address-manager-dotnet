using EmployeeAddressManager.Domain.Entities;

namespace EmployeeAddressManager.Domain.Interfaces;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetEmployeesAsync();
    Task<Employee> GetEmployeeByIdAsync(int id);
    Task<Employee> CreateEmployeeAsync(Employee employee);
    Task<Employee> UpdateEmployeeAsync(Employee employee);
    Task<Employee> DeleteEmployeeAsync(int id);
}