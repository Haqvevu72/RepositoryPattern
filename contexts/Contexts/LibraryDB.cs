using Contexts.Configurations;
using Microsoft.EntityFrameworkCore;
using Models.Entities.Concrete;

namespace Contexts.Contexts
{
    internal class LibraryDB:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=STHQ0128-04;Database=LibraryDB;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new S_CardConfig());
            modelBuilder.ApplyConfiguration(new TeacherConfig());
            modelBuilder.ApplyConfiguration(new T_CardConfig());
            modelBuilder.ApplyConfiguration(new BookConfig());
            modelBuilder.ApplyConfiguration(new GroupConfig());
        }


        // Tables
        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<Author> Authors { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Department> Departments { get; set; }
        
        public virtual DbSet<Faculty> Faculties { get; set; }

        public virtual DbSet<Group> Groups { get; set; }

        public virtual DbSet<Lib> Libs { get; set; }
        
        public virtual DbSet<Press> Press { get; set; }
        
        public virtual DbSet<S_Card> S_Cards { get; set; }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<T_Card> T_Cards { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }

        public virtual DbSet<Theme> Themes { get; set; }












    }
}
