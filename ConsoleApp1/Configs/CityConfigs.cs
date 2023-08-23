using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configs
{
    public class CityConfigs : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.Id).HasName("Cities");
            builder.Property(x => x.Name).HasMaxLength(256);
            builder.HasOne(x => x.Country).WithMany(x => x.Cities).HasForeignKey(x => x.CountryId).IsRequired();
        }

        
    }
}
