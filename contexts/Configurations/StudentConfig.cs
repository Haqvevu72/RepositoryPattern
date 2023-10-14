using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities.Concrete;

namespace Contexts.Configurations
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Relationship
            builder.HasOne(s => s.Group)
                   .WithMany(g => g.Students)
                   .HasForeignKey(s => s.Id_Group);
        }
    }
}
