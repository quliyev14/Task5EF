using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task5_Linq.Domain.Entities.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(c => c.Id);


            builder.Property(m => m.Car)
                   .HasDefaultValue("No Car")
                   .HasMaxLength(50)
                   .IsRequired(true)
                   .IsUnicode(true);

            builder.Property(m => m.Email)
                   .HasDefaultValue("No Email")
                   .HasMaxLength(50)
                   .IsRequired(true)
                   .IsUnicode(true);

            builder.Property(m => m.FullName)
                   .HasDefaultValue("No FullName");

            builder.Property(m => m.Phone)
                   .HasDefaultValue("No Phone")
                   .HasMaxLength(50)
                   .IsRequired(true)
                   .IsUnicode(true);

            builder.Property(m => m.Car).HasColumnName("Car");
            builder.Property(m => m.Email).HasColumnName("Email");
            builder.Property(m => m.FullName).HasColumnName("FullName");
            builder.Property(m => m.Phone).HasColumnName("Phone");

            builder.HasMany(c => c.Car)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.Id)
                .IsRequired(true);
        }
    }
}