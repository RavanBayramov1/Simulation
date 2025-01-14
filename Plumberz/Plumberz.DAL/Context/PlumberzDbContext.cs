using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Plumberz.Core.Entities;

namespace Plumberz.DAL.Context;

public class PlumberzDbContext : DbContext
{
    public DbSet<Department> Departments { get; set; }
    public DbSet<Tecnician> Tecnicians { get; set; }
    public PlumberzDbContext(DbContextOptions opt) : base(opt) {}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PlumberzDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
