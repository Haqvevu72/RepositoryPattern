using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities.Concrete;

namespace Contexts.Configurations
{
    public class S_CardConfig : IEntityTypeConfiguration<S_Card>
    {
        public void Configure(EntityTypeBuilder<S_Card> builder)
        {
            // Relationships
            builder.HasOne(sc => sc.Student)
                   .WithMany(s => s.S_Cards)
                   .HasForeignKey(sc => sc.Id_Student);

            builder.HasOne(sc => sc.Book)
                   .WithMany(b => b.S_Cards)
                   .HasForeignKey(sc => sc.Id_Book);

            builder.HasOne(sc => sc.Lib)
                   .WithMany(l => l.S_Cards)
                   .HasForeignKey(sc => sc.Id_Lib);
        }
    }
}
