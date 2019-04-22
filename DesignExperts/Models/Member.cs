using System;
using System.Collections.Generic;

namespace DesignExperts
{
    public partial class Member
    {
        public int Id { get; set; }
        public int? MachieneId { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cnic { get; set; }
        public DateTime? Dob { get; set; }
        public int? Gender { get; set; }
        public string Image { get; set; }
        public int? MartialStatus { get; set; }
        public string Reference { get; set; }
        public int? Cast { get; set; }
        public int? Religion { get; set; }
        public int? BloodGroup { get; set; }
        public string Qualification { get; set; }
        public string MobileP { get; set; }
        public string MobileS { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int? Type { get; set; }
        public string Designation { get; set; }
        public int? Department { get; set; }
        public DateTime? JoinDate { get; set; }
        public DateTime? TerDate { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? Status { get; set; }
    }
}
