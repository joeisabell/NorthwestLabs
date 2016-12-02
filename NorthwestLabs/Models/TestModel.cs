using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Test")]
    public class TestModel
    {
        [Key]
        [Required]
        public int TestID { get; set; }
        public int LTCode { get; set; }
        public int CompoundSequence { get; set; }
        public int AssayID { get; set; }
        public int WorkOrderID { get; set; }
        public DateTime DateScheduled { get; set; }
        public DateTime TimeScheduled { get; set; }
        public DateTime DateCompleted { get; set; }
        public DateTime DateRerun { get; set; }
        public string AddRecommendedTests { get; set; }

    }
}