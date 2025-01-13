using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.DAL.Configurations;

public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.
            Property(x => x.Name)
            .HasMaxLength(16);
        builder
            .Property(x => x.Surname)
            .HasMaxLength(32);
        builder.
            HasOne(x => x.Department)
            .WithMany(x => x.Doctors)
            .HasForeignKey(x=>x.DepartmentId);

    }
}
