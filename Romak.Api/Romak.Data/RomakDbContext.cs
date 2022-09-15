using Microsoft.EntityFrameworkCore;
using Romak.Core.Model;
using Romak.Data.Configuration;
using System.Collections.Generic;

namespace Romak.Data
{
    public class RomakDbContext : DbContext
    {
        public RomakDbContext(DbContextOptions<RomakDbContext> options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<Person> People { get; set; }
        //public virtual DbSet<Person1> People1 { get; set; }

        public virtual DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new AddressConfiguration().Configure(modelBuilder.Entity<Address>());
            new PersonConfiguration().Configure(modelBuilder.Entity<Person>());
            //new Person1Configuration().Configure(modelBuilder.Entity<Person1>());
            new RoleConfiguration().Configure(modelBuilder.Entity<Role>());
            new UserConfiguration().Configure(modelBuilder.Entity<User>());

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Name = "role_admin",
                }
            );


            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 2,
                    Name = "role_user",
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "admin",
                    Password = "admin",
                    RoleId = 1
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 2,
                    Name = "user",
                    Password = "user",
                    RoleId = 2
                }
            );
        }

    }
}
