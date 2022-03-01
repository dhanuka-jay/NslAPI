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
    public class FeesConfiguration : IEntityTypeConfiguration<Fees>
    {
        public void Configure(EntityTypeBuilder<Fees> builder)
        {
            builder.HasData(
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
    }
}
