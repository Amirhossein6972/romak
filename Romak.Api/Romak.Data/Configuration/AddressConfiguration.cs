using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Romak.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Romak.Data.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder.HasOne(x => x.Person)
                .WithMany(c => c.Addresses)
                .HasForeignKey(c=>c.PersonId);

            builder
                .ToTable("Address");
        }
    }
}
