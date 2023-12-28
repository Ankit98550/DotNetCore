using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UserloginSessionLogoutApp.Models;

public partial class UsertblContext : DbContext
{
    public UsertblContext()
    {
    }

    public UsertblContext(DbContextOptions<UsertblContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-LI3L725\\SQLEXPRESS;TrustServerCertificate=True;Database=usertbl;user ID=DESKTOP-LI3L725\\Ankit;Integrated Security=True;MultipleActiveResultSets=true;Encrypt=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83F2DAD1E68");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Age)
                .HasMaxLength(200)
                .HasColumnName("age");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Gender).HasMaxLength(200);
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
