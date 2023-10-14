using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities.Concrete;

namespace Contexts.Configurations
{
    public class T_CardConfig : IEntityTypeConfiguration<T_Card>
    {
        public void Configure(EntityTypeBuilder<T_Card> builder)
        {
            // Relationship
            builder.HasOne(sc => sc.Teacher)
                   .WithMany(s => s.T_Cards)
                   .HasForeignKey(sc => sc.Id_Teacher);

            builder.HasOne(sc => sc.Book)
                   .WithMany(b => b.T_Cards)
                   .HasForeignKey(sc => sc.Id_Book);

            builder.HasOne(sc => sc.Lib)
                   .WithMany(l => l.T_Cards)
                   .HasForeignKey(sc => sc.Id_Lib);
        }
    }
}
