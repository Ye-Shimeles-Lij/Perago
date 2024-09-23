using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class EmployeeHierarchyContext : DbContext
{
    public DbSet<EmployeePosition> EmployeePositions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Your PostgreSQL Connection String"); 
    
}

