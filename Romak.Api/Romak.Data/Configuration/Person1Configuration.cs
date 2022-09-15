using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Romak.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romak.Data.Configuration
{
    public class Person1Configuration : IEntityTypeConfiguration<Person1>
    {
        public void Configure(EntityTypeBuilder<Person1> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder.OwnsMany(
                p => p.Addresses, a =>
                {
                    a.WithOwner().HasForeignKey("OwnerId");
                    a.Property<int>("Id");
                    a.HasKey("Id");
                });

            builder
                .ToTable("People1");
        }
    }
}
