using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Compound")]
    public class CompoundModel
    {
        [Key]
        [Required]
        public int LTCode { get; set; }
        public int CompoundSequence { get; set; }
        public int ClientID { get; set; }
        public string CompoundName { get; set; }
        public string CompoundQty { get; set; }
        public DateTime DateArrived { get; set; }
        public string RecievedBy { get; set; }
        public DateTime DateDue { get; set; }
        public string CompoundAppearance { get; set; }
        public string WeightIndicated { get; set; }
        public string MolecularMass { get; set; }
        public string ActualWeight { get; set; }
        public string MaximumToleratedDose { get; set; }

    }
}