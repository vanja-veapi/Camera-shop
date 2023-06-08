﻿using CameraShop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraShop.EfDataAccess.Configurations
{
    public abstract class EntityConfiguration<T> : IEntityTypeConfiguration<T> where T : Entity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.IsActive).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.DeletedBy).IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");
            ConfigureRules(builder);
        }

        protected abstract void ConfigureRules(EntityTypeBuilder<T> builder);
    }
}
