using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Romak.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Romak.Data.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .ToTable("People");
        }
    }
}
