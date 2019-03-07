﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignExperts.Models
{
    public partial class GeneralType
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        public int Category { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [StringLength(100)]
        public string ModifiedBy { get; set; }
    }
}
