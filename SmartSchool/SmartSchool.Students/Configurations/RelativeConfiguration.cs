using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartSchool.Students.Domain.Models;

namespace SmartSchool.Students.Configurations
{
    public class RelativeConfiguration : IEntityTypeConfiguration<Relative>
    {
        public void Configure(EntityTypeBuilder<Relative> builder)
        {
            builder.Property(relative => relative.FirstName)
                .IsRequired()
                .HasMaxLength(70);
            builder.Property(relative => relative.LastName)
                .IsRequired()
                .HasMaxLength(70);
        }
    }
}
