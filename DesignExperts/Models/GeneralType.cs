﻿using System;
using System.Collections.Generic;

namespace DesignExperts
{
    public partial class GeneralType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
