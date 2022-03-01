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
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasData(
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
        }
    }
}
