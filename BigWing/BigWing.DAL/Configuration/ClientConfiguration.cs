using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigWing.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BigWing.DAL.Configuration;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder
            .Property(x => x.FullName)
            .HasMaxLength(64);
        builder.Property(x=>x.Image)
            .HasMaxLength(256);
        builder
            .Property(x=>x.Comment)
            .HasMaxLength(512);
        builder
            .HasOne(x => x.Department)
            .WithMany(x => x.Clients)
            .HasForeignKey(x => x.DepartmentId);
    }
}
