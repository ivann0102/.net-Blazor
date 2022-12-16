using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentRatingBlazor.Models;

public partial class StudentRatingContext : DbContext
{
    public StudentRatingContext()
    {
    }

    public StudentRatingContext(DbContextOptions<StudentRatingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<DateMonth> DateMonths { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

}
