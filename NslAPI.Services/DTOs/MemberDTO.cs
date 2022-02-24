using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NslAPI.Data;

namespace NslAPI.Services.DTOs
{
    public class CreateMemberDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Name is too long!")]
        public string FName { get; set; }
        public string MName { get; set; }
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Name is too long!")]
        public string LName { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        public string ProfilePicture { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int Postcode { get; set; }
        [Required]
        [StringLength(maximumLength: 10, ErrorMessage = "Phone Number is too long!")]
        public string Mobile { get; set; }
        [StringLength(maximumLength: 10, ErrorMessage = "Phone Number is too long!")]
        public string HomePhone { get; set; }
        [Required]
        [StringLength(maximumLength: 100, ErrorMessage = "Email is too long!")]
        public string Email { get; set; }
        [Required]
        public string NextOfKin { get; set; }
        [Required]
        public string Relationship { get; set; }
        [Required]
        [StringLength(maximumLength: 10, ErrorMessage = "Phone Number is too long!")]
        public string NOKPhone { get; set; }
        [Required]
        public int IsActive { get; set; }

    }
    public class MemberDTO : CreateMemberDTO
    {
        public int Id { get; set; }
        public IList<FeesDTO> Fees { get; set; }
    }
}
