using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NslAPI.Data
{
    public class Player
    {
        public int Id { get; set; }
        public string JerseyName { get; set; }
        public string JerseyNumber { get; set; }
        public string JerseySize { get; set; }
        public string BattingStyle { get; set; }
        public string BowlingStyle { get; set; }
        public string PlayingRole { get; set; }

        [ForeignKey(nameof(Member))]
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
