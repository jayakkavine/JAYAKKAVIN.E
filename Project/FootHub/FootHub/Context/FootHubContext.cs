using System;
using System.Collections.Generic;
using FootHub.Models;
using Microsoft.EntityFrameworkCore;

namespace FootHub.Context;

public partial class FootHubContext : DbContext
{
    public FootHubContext()
    {
    }

    public FootHubContext(DbContextOptions<FootHubContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BrandTable> BrandTables { get; set; }

    public virtual DbSet<CartTable> CartTables { get; set; }

    public virtual DbSet<CategoryTable> CategoryTables { get; set; }

    public virtual DbSet<OcassionTable> OcassionTables { get; set; }

    public virtual DbSet<OrderLinkTable> OrderLinkTables { get; set; }

    public virtual DbSet<OrderTable> OrderTables { get; set; }

    public virtual DbSet<ProductLinkTable> ProductLinkTables { get; set; }

    public virtual DbSet<ProductTable> ProductTables { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<UserTable> UserTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS; initial catalog = FootHub; integrated security=SSPI; \nTrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BrandTable>(entity =>
        {
            entity.HasKey(e => e.BId).HasName("brand_pri");

            entity.ToTable("BrandTable");

            entity.HasIndex(e => new { e.BId, e.BName }, "brand_unique").IsUnique();

            entity.Property(e => e.BId)
                .ValueGeneratedNever()
                .HasColumnName("b_id");
            entity.Property(e => e.BName)
                .HasMaxLength(1)
                .HasColumnName("b_name");
        });

        modelBuilder.Entity<CartTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CartTable");

            entity.HasIndex(e => new { e.PId, e.UId }, "cart_unique").IsUnique();

            entity.Property(e => e.PId).HasColumnName("p_id");
            entity.Property(e => e.UId).HasColumnName("u_id");

            entity.HasOne(d => d.PIdNavigation).WithMany()
                .HasForeignKey(d => d.PId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_for2");

            entity.HasOne(d => d.UIdNavigation).WithMany()
                .HasForeignKey(d => d.UId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_for1");
        });

        modelBuilder.Entity<CategoryTable>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("category_pri");

            entity.ToTable("CategoryTable");

            entity.HasIndex(e => new { e.CId, e.CName }, "category_unique").IsUnique();

            entity.Property(e => e.CId)
                .ValueGeneratedNever()
                .HasColumnName("c_id");
            entity.Property(e => e.CName)
                .HasMaxLength(1)
                .HasColumnName("c_name");
        });

        modelBuilder.Entity<OcassionTable>(entity =>
        {
            entity.HasKey(e => e.OId).HasName("ocassion_pri");

            entity.ToTable("OcassionTable");

            entity.HasIndex(e => new { e.OId, e.OName }, "ocassion_unique").IsUnique();

            entity.Property(e => e.OId)
                .ValueGeneratedNever()
                .HasColumnName("o_id");
            entity.Property(e => e.OName)
                .HasMaxLength(1)
                .HasColumnName("o_name");
        });

        modelBuilder.Entity<OrderLinkTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OrderLinkTable");

            entity.HasIndex(e => new { e.PId, e.UId, e.OrderId }, "orderLink_unique").IsUnique();

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.PId).HasColumnName("p_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.UId).HasColumnName("u_id");

            entity.HasOne(d => d.Order).WithMany()
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_fore0");

            entity.HasOne(d => d.PIdNavigation).WithMany()
                .HasForeignKey(d => d.PId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_fore2");

            entity.HasOne(d => d.UIdNavigation).WithMany()
                .HasForeignKey(d => d.UId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_fore1");
        });

        modelBuilder.Entity<OrderTable>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("order_pri");

            entity.ToTable("OrderTable");

            entity.HasIndex(e => new { e.UId, e.OrderId }, "order_unique").IsUnique();

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("order_id");
            entity.Property(e => e.OrderDate)
                .HasMaxLength(1)
                .HasColumnName("order_date");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.UAddress)
                .HasMaxLength(1)
                .HasColumnName("u_address");
            entity.Property(e => e.UId).HasColumnName("u_id");
            entity.Property(e => e.UName)
                .HasMaxLength(1)
                .HasColumnName("u_name");

            entity.HasOne(d => d.UIdNavigation).WithMany(p => p.OrderTables)
                .HasForeignKey(d => d.UId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_for");
        });

        modelBuilder.Entity<ProductLinkTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProductLinkTable");

            entity.HasIndex(e => new { e.PId, e.OId, e.TId, e.BId, e.CId }, "productLink_unique").IsUnique();

            entity.Property(e => e.BId).HasColumnName("b_id");
            entity.Property(e => e.CId).HasColumnName("c_id");
            entity.Property(e => e.OId).HasColumnName("o_id");
            entity.Property(e => e.PId).HasColumnName("p_id");
            entity.Property(e => e.TId).HasColumnName("t_id");

            entity.HasOne(d => d.BIdNavigation).WithMany()
                .HasForeignKey(d => d.BId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("brand_fore");

            entity.HasOne(d => d.CIdNavigation).WithMany()
                .HasForeignKey(d => d.CId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("category_fore");

            entity.HasOne(d => d.OIdNavigation).WithMany()
                .HasForeignKey(d => d.OId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ocassion_fore");

            entity.HasOne(d => d.PIdNavigation).WithMany()
                .HasForeignKey(d => d.PId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("product_fore");

            entity.HasOne(d => d.TIdNavigation).WithMany()
                .HasForeignKey(d => d.TId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("type_fore");
        });

        modelBuilder.Entity<ProductTable>(entity =>
        {
            entity.HasKey(e => e.PId).HasName("product_pri");

            entity.ToTable("ProductTable");

            entity.HasIndex(e => new { e.PId, e.PName, e.Size }, "product_unique").IsUnique();

            entity.Property(e => e.PId)
                .ValueGeneratedNever()
                .HasColumnName("p_id");
            entity.Property(e => e.PDisc)
                .HasMaxLength(1)
                .HasColumnName("p_disc");
            entity.Property(e => e.PImage)
                .HasMaxLength(1)
                .HasColumnName("p_image");
            entity.Property(e => e.PName)
                .HasMaxLength(1)
                .HasColumnName("p_name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.TotalStock).HasColumnName("total_stock");
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.HasKey(e => e.TId).HasName("type_pri");

            entity.ToTable("ProductType");

            entity.HasIndex(e => new { e.TId, e.TName }, "productType_unique").IsUnique();

            entity.Property(e => e.TId)
                .ValueGeneratedNever()
                .HasColumnName("t_id");
            entity.Property(e => e.TName)
                .HasMaxLength(1)
                .HasColumnName("t_name");
        });

        modelBuilder.Entity<UserTable>(entity =>
        {
            entity.HasKey(e => e.UId).HasName("user_pri");

            entity.ToTable("UserTable");

            entity.HasIndex(e => new { e.UId, e.UEmail, e.UPhone }, "user_unique").IsUnique();

            entity.Property(e => e.UId)
                .ValueGeneratedNever()
                .HasColumnName("u_id");
            entity.Property(e => e.UEmail)
                .HasMaxLength(1)
                .HasColumnName("u_email");
            entity.Property(e => e.UName)
                .HasMaxLength(1)
                .HasColumnName("u_name");
            entity.Property(e => e.UPassword)
                .HasMaxLength(1)
                .HasColumnName("u_password");
            entity.Property(e => e.UPhone)
                .HasMaxLength(1)
                .HasColumnName("u_phone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
