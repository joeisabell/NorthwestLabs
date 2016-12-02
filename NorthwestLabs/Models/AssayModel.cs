using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Assay")]
    public class AssayModel
    {
        [Key]
        [Required]
        public int AssayID { get; set; }
        public string AssayName { get; set; }
        public string AssayAcronym { get; set; }
        public double AssayMaterialsCost { get; set; }
        public double AssayEstimatedCost { get; set; }

    }
}