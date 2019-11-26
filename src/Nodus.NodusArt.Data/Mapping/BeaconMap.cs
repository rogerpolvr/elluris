﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nodus.NodusArt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nodus.NodusArt.Data.Mapping
{
    public class BeaconMap : IEntityTypeConfiguration<Beacon>
    {
        public void Configure(EntityTypeBuilder<Beacon> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(b => b.BeaconCode).HasColumnName("BeaconCode").HasColumnType("varchar(50)");
        }
    }
}
