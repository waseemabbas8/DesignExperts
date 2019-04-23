using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignExperts
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public string AppointmentReference { get; set; }
        public int? LastReferenceCount { get; set; }
        public string ClientName { get; set; }
        public string ClientMobile { get; set; }
        public string ClientEmail { get; set; }
        public string ClientAddress { get; set; }
        public string ProjectType { get; set; }
        public string ProjecctLocation { get; set; }
        public string ProjectScope { get; set; }
        public string AppointmentVanue { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public DateTime? AppointmentTime { get; set; }
        public int? AppointmentFee { get; set; }
        public bool? IsFeeReceived { get; set; }
        public bool? IsProjectAssigned { get; set; }
        public string FeeNotReceivingReason { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? Status { get; set; }

        public Appointment IdNavigation { get; set; }
        public Appointment InverseIdNavigation { get; set; }

        [NotMapped]
        public bool IsNew {
            get
            {
                if (this.Id==0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
