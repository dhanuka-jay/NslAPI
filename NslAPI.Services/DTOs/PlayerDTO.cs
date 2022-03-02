using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NslAPI.Data;

namespace NslAPI.Services.DTOs
{
    public class CreatePlayerDTO
    {
        [Required]
        [StringLength(maximumLength: 10, ErrorMessage = "Jersey Name is too long!")]
        public string JerseyName { get; set; }
        [StringLength(maximumLength: 3, ErrorMessage = "Jersey Number is too long!")]
        public string JerseyNumber { get; set; }
        [Required]
        [StringLength(maximumLength: 4, ErrorMessage = "Jersey Size is too long!")]
        public string JerseySize { get; set; }
        [Required]
        public string BattingStyle { get; set; }
        [Required]
        public string BowlingStyle { get; set; }
        [Required]
        public string PlayingRole { get; set; }
        [Required]
        public int MemberId { get; set; }
    }

    public class UpdatePlayerDTO : CreatePlayerDTO
    {

    }

    public class PlayerDTO : CreatePlayerDTO
    {
        public int Id { get; set; }
        public MemberDTO Member { get; set; }
    }
}
