using System;
using System.Collections.Generic;

namespace DesignExperts
{
    public partial class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
