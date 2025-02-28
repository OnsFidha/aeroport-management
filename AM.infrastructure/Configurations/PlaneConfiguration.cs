using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.applicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.infrastructure.Configurations
{
    public class PlaneConfiguration: IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.HasKey(p => p.PlaneId);//primary key annotation
            builder.ToTable("myPlanes");//rename a table 
            builder.Property(p => p.Capacity).HasColumnName("PlaneCapacity");

        }
    }
}
