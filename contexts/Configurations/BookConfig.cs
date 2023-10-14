

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities.Concrete;

namespace Contexts.Configurations
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            // Relationships
            builder.HasOne(b => b.Author)
                   .WithMany(a => a.Books)
                   .HasForeignKey(b => b.Id_Author);

            builder.HasOne(b => b.Theme)
                   .WithMany(t => t.Books)
                   .HasForeignKey(b => b.Id_Themes);

            builder.HasOne(b => b.Press)
                   .WithMany(p => p.Books)
                   .HasForeignKey(b => b.Id_Press);

            builder.HasOne(b => b.Category)
                   .WithMany(c => c.Books)
                   .HasForeignKey(b => b.Id_Category);

        }
    }
}
