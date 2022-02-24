using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NslAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Member>().HasData(
                new Member
                {
                    Id = 1,
                    FName = "Dhanuka",
                    MName = "Sudheera",
                    LName = "Ilandarage",
                    DOB = new DateTime(1984,10,15),
                    ProfilePicture = "",
                    Street = "7 Igera Place",
                    City = "Ngunnawal",
                    State = "ACT",
                    Postcode = 2913,
                    Mobile = "0432009680",
                    HomePhone = "",
                    Email = "dhanuka.singhe@gmail.com",
                    NextOfKin = "Ryan",
                    Relationship = "Son",
                    NOKPhone = "0432000222",
                    IsActive = 1
                },
                new Member
                {
                    Id = 2,
                    FName = "Ryan",
                    MName = "Harindu",
                    LName = "Ilandarage",
                    DOB = new DateTime(2014, 12, 09),
                    ProfilePicture = "",
                    Street = "7 Igera Place",
                    City = "Ngunnawal",
                    State = "ACT",
                    Postcode = 2913,
                    Mobile = "0432222000",
                    HomePhone = "",
                    Email = "ryan.singhe@gmail.com",
                    NextOfKin = "Pavithri",
                    Relationship = "Mom",
                    NOKPhone = "0432333999",
                    IsActive = 1
                }
            );

            builder.Entity<Player>().HasData(
                new Player
                {
                    Id = 1,
                    JerseyName = "Sudeera",
                    JerseyNumber = "23",
                    JerseySize = "M",
                    BattingStyle = "Left",
                    BowlingStyle = "Right arm Medium Pace",
                    PlayingRole = "Allrounder",
                    MemberId = 1
                }
            );

            builder.Entity<Fees>().HasData(
                new Fees
                {
                    Id = 1,
                    FeeType = "Member",
                    AmountPaid = 200,
                    DateOfPayment = DateTime.Now,
                    MemberId = 1
                },
                new Fees
                {
                    Id = 2,
                    FeeType = "Member",
                    AmountPaid = 200,
                    DateOfPayment = DateTime.Now,
                    MemberId = 2
                },
                new Fees
                {
                    Id = 3,
                    FeeType = "Jersey",
                    AmountPaid = 100,
                    DateOfPayment = DateTime.Now,
                    MemberId = 2
                }
            );
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Fees> Fees { get; set; }
    }
}
