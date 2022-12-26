﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DYDN_Company.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set Idenity for primary key
            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Bill>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<BillDetail>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<CategoryProduct>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Factory>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<HistoryBill>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<WareHouse>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            // Set Unique Constraint
            modelBuilder.Entity<Account>().HasIndex(account=>account.Email).IsUnique();
            modelBuilder.Entity<Account>().HasIndex(account=>account.Code).IsUnique();
            modelBuilder.Entity<Product>().HasIndex(product=>product.Name).IsUnique();
            modelBuilder.Entity<Product>().HasIndex(product=>product.Code).IsUnique();
            modelBuilder.Entity<CategoryProduct>().HasIndex(category=>category.Name).IsUnique();
            modelBuilder.Entity<CategoryProduct>().HasIndex(category=>category.Code).IsUnique();
            modelBuilder.Entity<Employee>().HasIndex(emp=>emp.Email).IsUnique();
            modelBuilder.Entity<Employee>().HasIndex(emp=>emp.Code).IsUnique();
            modelBuilder.Entity<Department>().HasIndex(dep=>dep.Name).IsUnique();
            modelBuilder.Entity<Department>().HasIndex(dep=>dep.Code).IsUnique();
            modelBuilder.Entity<WareHouse>().HasIndex(warehouse=>warehouse.Code).IsUnique();
            modelBuilder.Entity<WareHouse>().HasIndex(warehouse=>warehouse.Name).IsUnique();
            modelBuilder.Entity<Factory>().HasIndex(factory=>factory.Name).IsUnique();
            modelBuilder.Entity<Factory>().HasIndex(factory=>factory.Code).IsUnique();
            modelBuilder.Entity<Order>().HasIndex(order=>order.Name).IsUnique();

        }

        DbSet<Account> Accounts { get; set; }
        DbSet<Bill> Bills { get; set; }
        DbSet<BillDetail> BillDetails { get; set; }
        DbSet<CategoryProduct> CategoryProducts { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Factory> Factories { get; set; }
        DbSet<HistoryBill> HistoryBills { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<WareHouse> WareHouses { get; set; }
    }
}
