using EmployeeAddressManager.Domain.Entities;
using EmployeeAddressManager.Domain.Interfaces;
using EmployeeAddressManager.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAddressManager.Infra.Data.Repositories;

public class AddressRepository : IAddressRepository
{
    private readonly ApplicationDbContext _context;

    public AddressRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Address>> GetAddressesAsync()
    {
        return await _context.Addresses.ToListAsync();
    }

    public async Task<Address> GetAddressByIdAsync(int id)
    {
        return await _context.Addresses.FindAsync(id);
    }

    public async Task<Address> CreateAddressAsync(Address address)
    {
        await _context.Addresses.AddAsync(address);
        await _context.SaveChangesAsync();
        return address;
    }

    public async Task<Address> UpdateAddressAsync(Address address)
    {
        _context.Entry(address).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return address;
    }

    public async Task<Address> DeleteAddressAsync(int id)
    {
        var address = await _context.Addresses.FindAsync(id);
        _context.Addresses.Remove(address);
        await _context.SaveChangesAsync();
        return address;
    }
}