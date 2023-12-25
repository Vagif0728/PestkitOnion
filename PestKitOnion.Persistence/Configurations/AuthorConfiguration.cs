﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Persistence.Configurations
{
    internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(a=>a.Name).IsRequired().HasMaxLength(50);
            builder.HasIndex(a => a.Name).IsUnique();
        }
    }
}
