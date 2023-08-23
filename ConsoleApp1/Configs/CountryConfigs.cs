using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configs
{
    public class CountryConfigs : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id).HasName("Country");
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.HasMany(x => x.Cities).WithOne(x => x.Country).HasForeignKey(x => x.CountryId).IsRequired();
        }
    }
}
