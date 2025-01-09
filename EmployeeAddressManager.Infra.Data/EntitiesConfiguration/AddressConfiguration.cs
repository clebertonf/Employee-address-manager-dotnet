using EmployeeAddressManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeAddressManager.Infra.Data.EntitiesConfiguration;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> address)
    {
        address.HasKey(a => a.Id);
        address.Property(a => a.Street).HasMaxLength(50).IsRequired();
        address.Property(a => a.City).HasMaxLength(50).IsRequired();
        address.Property(a => a.State).HasMaxLength(50).IsRequired();
        address.HasOne<Employee>()
            .WithOne()
            .HasForeignKey<Address>(a => a.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}