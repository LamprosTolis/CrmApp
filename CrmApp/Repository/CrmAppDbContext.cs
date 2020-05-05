﻿using CrmApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
  public class CrmAppDbContext : DbContext
  {

    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Basket> Baskets { get; set; }

    public DbSet<BasketProduct> BasketProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);

      optionsBuilder.UseSqlServer("Server=localhost;Database=crmapp-db;User Id=sa;Password=admin!@#123");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Customer>()
                  .ToTable("Customer");

      modelBuilder.Entity<Product>()
                  .ToTable("Product");
    }

  }
}
