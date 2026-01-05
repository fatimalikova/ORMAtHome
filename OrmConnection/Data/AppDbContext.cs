using Microsoft.EntityFrameworkCore;
using OrmConnection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmConnection.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=OrmConnectionDb;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<SubjectStudent> SubjectStudents { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<StudentDetails> StudentDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).IsRequired().HasMaxLength(250);
            });
            modelBuilder.Entity<SubjectStudent>()
                .HasKey(ss => new { ss.StudentId, ss.SubjectId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
