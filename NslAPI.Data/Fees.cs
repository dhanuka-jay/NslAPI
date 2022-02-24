using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NslAPI.Data
{
    public class Fees
    {
        public int Id { get; set; }
        public string FeeType { get; set; }
        public int AmountPaid { get; set; }
        public DateTime DateOfPayment { get; set; }

        [ForeignKey(nameof(Member))]
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
