using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignExperts.Models
{
    public partial class Member
    {
        [Key]
        public int Id { get; set; }

        public int? MachieneId { get; set; }
        [StringLength(7)]
        public string Code { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [Required]
        [Column("CNIC")]
        [StringLength(15)]
        public string Cnic { get; set; }
        [Column("DOB", TypeName = "date")]
        public DateTime? Dob { get; set; }
        public int? Gender { get; set; }
        [StringLength(100)]
        public string Image { get; set; }
        public int? MartialStatus { get; set; }
        [StringLength(100)]
        public string Reference { get; set; }
        public int? Cast { get; set; }
        public int? Religion { get; set; }
        public int? BloodGroup { get; set; }
        [StringLength(10)]
        public string Qualification { get; set; }
        [Required]
        [StringLength(12)]
        public string MobileP { get; set; }
        [StringLength(12)]
        public string MobileS { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(10)]
        public string PostCode { get; set; }
        [StringLength(100)]
        public string State { get; set; }
        [StringLength(100)]
        public string Country { get; set; }
        public int? Type { get; set; }
        [StringLength(100)]
        public string Designation { get; set; }
        public int? Department { get; set; }
        [Column(TypeName = "date")]
        public DateTime? JoinDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? TerDate { get; set; }
        [Column(TypeName = "decimal(10, 0)")]
        public decimal? Salary { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [StringLength(100)]
        public string ModifiedBy { get; set; }
        public int? Status { get; set; }
    }
}
