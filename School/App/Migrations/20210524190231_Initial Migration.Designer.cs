// <auto-generated />
using App.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210524190231_Initial Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("App.Models.Grades", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CourseName")
                        .HasColumnType("TEXT");

                    b.Property<float>("Grade")
                        .HasColumnType("REAL");

                    b.Property<int>("StudentID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("StudentID");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CourseName = "English",
                            Grade = 80f,
                            StudentID = 1
                        },
                        new
                        {
                            ID = 2,
                            CourseName = "Math",
                            Grade = 60f,
                            StudentID = 2
                        },
                        new
                        {
                            ID = 3,
                            CourseName = "Science",
                            Grade = 75f,
                            StudentID = 3
                        },
                        new
                        {
                            ID = 4,
                            CourseName = "Government",
                            Grade = 90f,
                            StudentID = 4
                        });
                });

            modelBuilder.Entity("App.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClassYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Age = 15,
                            ClassYear = 0,
                            FirstName = "Mark",
                            LastName = "Flores"
                        },
                        new
                        {
                            ID = 2,
                            Age = 16,
                            ClassYear = 1,
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 3,
                            Age = 17,
                            ClassYear = 2,
                            FirstName = "Jessica",
                            LastName = "Robinson"
                        },
                        new
                        {
                            ID = 4,
                            Age = 18,
                            ClassYear = 3,
                            FirstName = "Rex",
                            LastName = "Brown"
                        });
                });

            modelBuilder.Entity("App.Models.Grades", b =>
                {
                    b.HasOne("App.Models.Student", null)
                        .WithMany("GradesList")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("App.Models.Student", b =>
                {
                    b.Navigation("GradesList");
                });
#pragma warning restore 612, 618
        }
    }
}
