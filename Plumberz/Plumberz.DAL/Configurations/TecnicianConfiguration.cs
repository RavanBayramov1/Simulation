using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plumberz.Core.Entities;

namespace Plumberz.DAL.Configurations;

public class TecnicianConfiguration : IEntityTypeConfiguration<Tecnician>
{
    public void Configure(EntityTypeBuilder<Tecnician> builder)
    {
        builder
            .Property(x => x.Name)
            .HasMaxLength(16);
        builder
            .Property(x=>x.Surname)
            .HasMaxLength(20);
        builder
            .Property(x=>x.Image)
            .HasMaxLength(256);
        builder
            .HasOne(x => x.Department)
            .WithMany(x => x.Tecnicians)
            .HasForeignKey(x => x.DepartmentId);
    }
}
