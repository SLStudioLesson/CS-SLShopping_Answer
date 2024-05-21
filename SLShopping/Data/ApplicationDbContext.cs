﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SLShopping.Models;
using System.Reflection.Emit;

namespace SLShopping.Data;

public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // TODO: 中間テーブルのIDを排除
        modelBuilder.Entity<UserRole>().HasNoKey();

        // 論理削除フィルター
        //modelBuilder.Entity<User>()
        //    .HasQueryFilter(u => !u.IsDeleted);
        //modelBuilder.Entity<Brand>()
        //    .HasQueryFilter(b => !b.IsDeleted);
    }
}
