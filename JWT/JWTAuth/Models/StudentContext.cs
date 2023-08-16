using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JWTAuth.Models;

public partial class StudentContext : DbContext
{
    public StudentContext()
    {
    }

    public StudentContext(DbContextOptions<StudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

        

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.RollNo);

            entity.Property(e => e.RollNo)
                .ValueGeneratedNever()
                .HasColumnName("Roll_No");
            entity.Property(e => e.Address).IsRequired();
            entity.Property(e => e.StudentName)
                .IsRequired()
                .HasColumnName("Student_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
