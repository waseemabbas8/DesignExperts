using System;
using System.Collections.Generic;

namespace DesignExperts.Models
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Appointee { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? AppointmentFee { get; set; }
        public int? Status { get; set; }

        public Appointment IdNavigation { get; set; }
        public Appointment InverseIdNavigation { get; set; }
    }
}
