using EmployeeAddressManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeAddressManager.Infra.Data.EntitiesConfiguration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> employee)
    {
        employee.HasKey(e => e.Id);
        employee.Property(e => e.Name).HasMaxLength(100).IsRequired();
        employee.Property(e => e.Role).HasMaxLength(100).IsRequired();
        employee.Property(e => e.DateOfHiring).HasColumnType("date").IsRequired();
    }
}