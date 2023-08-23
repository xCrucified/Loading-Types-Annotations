using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configs
{
    internal class ShopConfigs : IEntityTypeConfiguration<Shop> 
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.HasKey(x => x.Id).HasName("Shops");
            builder.Property(x => x.Name).HasMaxLength(200);
            builder.HasOne(x => x.City).WithMany(x => x.Shops).HasForeignKey(x => x.CityId).IsRequired();
            builder.HasMany(x => x.Products).WithMany(x => x.Shops);
        }
    }
}
