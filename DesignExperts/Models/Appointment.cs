using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DesignExperts.Models
{
    public partial class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please select a client")]
        public int? ClientId { get; set; }

        [Required(ErrorMessage = "Please pick an appointment date")]
        public DateTime? AppointmentDate { get; set; }

        [Required(ErrorMessage = "Please pick appointment start time")]
        public DateTime? StartTime { get; set; }

        [Required(ErrorMessage = "Please pick appointment end time")]
        public DateTime? EndTime { get; set; }

        [Required(ErrorMessage = "Please select an appointee")]
        public string Appointee { get; set; }

        [Required(ErrorMessage = "Please enter appointment fee")]
        public int? AppointmentFee { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? Status { get; set; }

        public Appointment IdNavigation { get; set; }
        public Appointment InverseIdNavigation { get; set; }
    }
}
