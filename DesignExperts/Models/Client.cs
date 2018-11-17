using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DesignExperts.Models
{
    public enum Gender
    {
        Male,
        Female
    }

    public partial class Client
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Client Name should use alphabets only")]
        public string Name { get; set; }

        [MinLength(15,ErrorMessage ="Invalid CNIC")]
        public string Cnic { get; set; }

        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }

        [MinLength(11, ErrorMessage = "Invalid Phone #")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Mobile # is Required")]
        [MinLength(12, ErrorMessage = "Invalid Mobile #")]
        public string Mobile { get; set; }

        public string Address { get; set; }

        public Gender Gender { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Documents { get; set; }
        public string Images { get; set; }
        public int? Status { get; set; }
    }
}
