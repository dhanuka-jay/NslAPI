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
    public class CreateFeesDTO
    {
        [Required]
        public string FeeType { get; set; }
        [Required]
        public int AmountPaid { get; set; }
        [Required]
        public DateTime DateOfPayment { get; set; }
        [Required]
        public int MemberId { get; set; }
    }

    public class FeesDTO : CreateFeesDTO
    {
        public int Id { get; set; }
        public MemberDTO Member { get; set; }
    }
}
