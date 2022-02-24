using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NslAPI.Data
{
    public class Member
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public DateTime DOB { get; set; }
        public string ProfilePicture { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Postcode { get; set; }
        public string Mobile { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }
        public string NextOfKin { get; set; }
        public string Relationship { get; set; }
        public string NOKPhone { get; set; }
        public int IsActive { get; set; }
        public virtual IList<Fees> Fees { get; set; }
    }
}
