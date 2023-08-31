﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProductsCfg : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(x => x.Id).HasName("Products");

        }
    }
}
