using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plumberz.Core.Entities;

namespace Plumberz.DAL.Configurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder
            .Property(x => x.Name)
            .HasMaxLength(64);
        builder
            .HasMany(x => x.Tecnicians)
            .WithOne(x => x.Department);
    }
}
