﻿// <auto-generated />
using System;
using Contexts.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Contexts.Migrations
{
    [DbContext(typeof(LibraryDB))]
    partial class LibraryDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Models.Entities.Concrete.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpddatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Author")
                        .HasColumnType("int");

                    b.Property<int>("Id_Category")
                        .HasColumnType("int");

                    b.Property<int>("Id_Press")
                        .HasColumnType("int");

                    b.Property<int>("Id_Themes")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpddatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("YearPress")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Author");

                    b.HasIndex("Id_Category");

                    b.HasIndex("Id_Press");

                    b.HasIndex("Id_Themes");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpddatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpddatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpddatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Faculty")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpddatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id_Faculty");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Lib", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpddatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Libs");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Press", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpddatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Press");
                });

            modelBuilder.Entity("Models.Entities.Concrete.S_Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Book")
                        .HasColumnType("int");

                    b.Property<int>("Id_Lib")
                        .HasColumnType("int");

                    b.Property<int>("Id_Student")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpddatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id_Book");

                    b.HasIndex("Id_Lib");

                    b.HasIndex("Id_Student");

                    b.ToTable("S_Cards");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Group")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Term")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpddatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id_Group");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Models.Entities.Concrete.T_Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Book")
                        .HasColumnType("int");

                    b.Property<int>("Id_Lib")
                        .HasColumnType("int");

                    b.Property<int>("Id_Teacher")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpddatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id_Book");

                    b.HasIndex("Id_Lib");

                    b.HasIndex("Id_Teacher");

                    b.ToTable("T_Cards");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Dep")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpddatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id_Dep");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpddatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Book", b =>
                {
                    b.HasOne("Models.Entities.Concrete.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("Id_Author")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.Concrete.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("Id_Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.Concrete.Press", "Press")
                        .WithMany("Books")
                        .HasForeignKey("Id_Press")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.Concrete.Theme", "Theme")
                        .WithMany("Books")
                        .HasForeignKey("Id_Themes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("Press");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Group", b =>
                {
                    b.HasOne("Models.Entities.Concrete.Faculty", "Faculty")
                        .WithMany("Groups")
                        .HasForeignKey("Id_Faculty")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Models.Entities.Concrete.S_Card", b =>
                {
                    b.HasOne("Models.Entities.Concrete.Book", "Book")
                        .WithMany("S_Cards")
                        .HasForeignKey("Id_Book")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.Concrete.Lib", "Lib")
                        .WithMany("S_Cards")
                        .HasForeignKey("Id_Lib")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.Concrete.Student", "Student")
                        .WithMany("S_Cards")
                        .HasForeignKey("Id_Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Lib");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Student", b =>
                {
                    b.HasOne("Models.Entities.Concrete.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("Id_Group")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Models.Entities.Concrete.T_Card", b =>
                {
                    b.HasOne("Models.Entities.Concrete.Book", "Book")
                        .WithMany("T_Cards")
                        .HasForeignKey("Id_Book")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.Concrete.Lib", "Lib")
                        .WithMany("T_Cards")
                        .HasForeignKey("Id_Lib")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.Concrete.Teacher", "Teacher")
                        .WithMany("T_Cards")
                        .HasForeignKey("Id_Teacher")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Lib");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Teacher", b =>
                {
                    b.HasOne("Models.Entities.Concrete.Department", "Department")
                        .WithMany("Teachers")
                        .HasForeignKey("Id_Dep")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Book", b =>
                {
                    b.Navigation("S_Cards");

                    b.Navigation("T_Cards");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Department", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Faculty", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Lib", b =>
                {
                    b.Navigation("S_Cards");

                    b.Navigation("T_Cards");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Press", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Student", b =>
                {
                    b.Navigation("S_Cards");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Teacher", b =>
                {
                    b.Navigation("T_Cards");
                });

            modelBuilder.Entity("Models.Entities.Concrete.Theme", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
