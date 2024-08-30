﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProductDBFirst.Models;

public partial class CoforgeDbContext : DbContext
{
    public CoforgeDbContext()
    {
    }

    public CoforgeDbContext(DbContextOptions<CoforgeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=TRD-417\\MSSQLSERVER2;Initial Catalog=CoforgeDB;integrated security=true;multipleactiveresultsets=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("products");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
