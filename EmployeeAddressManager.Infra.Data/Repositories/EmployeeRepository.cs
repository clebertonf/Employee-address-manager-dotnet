using EmployeeAddressManager.Domain.Entities;
using EmployeeAddressManager.Domain.Interfaces;
using EmployeeAddressManager.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAddressManager.Infra.Data.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly ApplicationDbContext _context;

    public EmployeeRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Employee>> GetEmployeesAsync()
    {
        return await _context.Employees.ToListAsync();
    }

    public async Task<Employee> GetEmployeeByIdAsync(int id)
    {
        return await _context.Employees.FindAsync(id);
    }

    public async Task<Employee> CreateEmployeeAsync(Employee employee)
    {
        await _context.Employees.AddAsync(employee);
        await _context.SaveChangesAsync();
        return employee;
    }

    public async Task<Employee> UpdateEmployeeAsync(Employee employee)
    {
        _context.Entry(employee).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return employee;
    }

    public async Task<Employee> DeleteEmployeeAsync(Employee id)
    {
        _context.Employees.Remove(id);
        await _context.SaveChangesAsync();
        return id;
    }
}