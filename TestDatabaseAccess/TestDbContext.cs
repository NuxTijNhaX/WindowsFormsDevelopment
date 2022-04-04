using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TestDatabaseAccess
{
    public partial class TestDbContext : DbContext
    {
        public TestDbContext()
            : base("name=TestDbContext")
        {
        }

        public virtual DbSet<Campu> Campus { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<MajorProgram> MajorPrograms { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<SubjectProgram> SubjectPrograms { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campu>()
                .HasMany(e => e.Rooms)
                .WithOptional(e => e.Campu)
                .HasForeignKey(e => e.Campus_Id);

            modelBuilder.Entity<Class>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Class)
                .HasForeignKey(e => e.Class_Id);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Lecturers)
                .WithOptional(e => e.Faculty)
                .HasForeignKey(e => e.Faculty_Id);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.MajorPrograms)
                .WithOptional(e => e.Faculty)
                .HasForeignKey(e => e.Faculty_Id);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Subjects)
                .WithOptional(e => e.Faculty)
                .HasForeignKey(e => e.Faculty_Id);

            modelBuilder.Entity<Lecturer>()
                .HasMany(e => e.Subjects)
                .WithOptional(e => e.Lecturer)
                .HasForeignKey(e => e.Lecturer_Id);

            modelBuilder.Entity<MajorProgram>()
                .HasMany(e => e.Classes)
                .WithOptional(e => e.MajorProgram)
                .HasForeignKey(e => e.MajorProgram_Id);

            modelBuilder.Entity<MajorProgram>()
                .HasMany(e => e.SubjectPrograms)
                .WithOptional(e => e.MajorProgram)
                .HasForeignKey(e => e.MajorProgram_Id);

            modelBuilder.Entity<Major>()
                .HasMany(e => e.MajorPrograms)
                .WithOptional(e => e.Major)
                .HasForeignKey(e => e.Major_Id);
        }
    }
}
