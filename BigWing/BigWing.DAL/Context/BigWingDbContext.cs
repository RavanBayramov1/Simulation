using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigWing.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BigWing.DAL.Context;

public class BigWingDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Department> Departments { get; set; }
    public BigWingDbContext(DbContextOptions opt) : base(opt) {}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BigWingDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
