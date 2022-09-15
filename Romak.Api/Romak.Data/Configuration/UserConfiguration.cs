using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Romak.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Romak.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder.HasOne(x => x.Role)
                .WithMany(c => c.Users)
                .HasForeignKey(c=>c.RoleId);

            builder
                .ToTable("User");
        }
    }
}
