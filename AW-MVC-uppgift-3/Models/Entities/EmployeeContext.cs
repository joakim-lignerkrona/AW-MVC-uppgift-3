using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AW_MVC_uppgift_3.Models.Entities;

public partial class EmployeeContext : DbContext
{
    public EmployeeContext(DbContextOptions<EmployeeContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
