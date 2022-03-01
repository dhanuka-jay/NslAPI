using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NslAPI.Data.Configurations.Entities;

namespace NslAPI.Data
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new MemberConfiguration());
            builder.ApplyConfiguration(new PlayerConfiguration());
            builder.ApplyConfiguration(new FeesConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());            
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Fees> Fees { get; set; }
    }
}
