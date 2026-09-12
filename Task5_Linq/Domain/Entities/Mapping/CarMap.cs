using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task5_Linq.Domain.Entities.Mapping
{
    public class CarMap : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");
            builder.HasKey(x => x.Id);

            builder.Property(c => c.Marka)
                .HasDefaultValue("No Marka")
                .HasMaxLength(50)
                .IsRequired(true)
                .IsUnicode(true);

            builder.Property(c => c.Model)
               .HasDefaultValue("No Model")
               .HasMaxLength(50)
               .IsRequired(true)
               .IsUnicode(true);

            //builder.Property(c => c.Price)
            //   .HasDefaultValue("No Price");

            //builder.Property(c => c.Color)
            //   .HasDefaultValue("No Color")
            //   .HasMaxLength(50)
            //   .IsRequired(true)
            //   .IsUnicode(true);

            //builder.Property(c => c.Year)
            //   .HasDefaultValue("No Year")
            //   .HasMaxLength(5);

            //builder.Property(c => c.Customer)
            //.HasDefaultValue("No Customer")
            //.HasMaxLength(30)
            //.IsRequired(true)
            //.IsUnicode(true);



            builder.Property(c => c.Marka).HasColumnName("Marka");
            builder.Property(c => c.Model).HasColumnName("Model");
            builder.Property(c => c.Price).HasColumnName("Price");
            builder.Property(c => c.Year).HasColumnName("Year");
            builder.Property(c => c.IsNew).HasColumnName("IsNew");
            builder.Property(c => c.Color).HasColumnName("Color");
            //builder.Property(c => c.Customer).HasColumnName("Customer");

        }
    }
}

