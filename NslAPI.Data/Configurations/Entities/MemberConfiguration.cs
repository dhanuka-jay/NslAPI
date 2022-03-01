using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NslAPI.Data.Configurations.Entities
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasData(
                new Member
                {
                    Id = 1,
                    FName = "Dhanuka",
                    MName = "Sudheera",
                    LName = "Ilandarage",
                    DOB = new DateTime(1984, 10, 15),
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
        }
    }
}
