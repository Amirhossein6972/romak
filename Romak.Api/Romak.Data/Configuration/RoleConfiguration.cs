using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Romak.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Romak.Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .ToTable("Role");
        }
    }
}
