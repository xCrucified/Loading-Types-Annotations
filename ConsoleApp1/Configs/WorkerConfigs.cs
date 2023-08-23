using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configs
{
    internal class WorkerConfigs : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder.HasKey(x => x.Id).HasName("Workers");
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.HasOne(x => x.Shop).WithMany(x => x.Workers).HasForeignKey(x => x.ShopId).IsRequired();
            builder.HasOne(x => x.Position).WithMany(x => x.Workers).HasForeignKey(x =>x.PositionId).IsRequired();`
        }
    }
}
