using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities.Concrete;

namespace Contexts.Configurations
{
    public class GroupConfig : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            // Relationships
            builder.HasOne(g => g.Faculty)
                   .WithMany(f => f.Groups)
                   .HasForeignKey(g => g.Id_Faculty);
        }
    }
}
