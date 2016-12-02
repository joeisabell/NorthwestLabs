using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Employee_Test_Details")]
    public class EmployeeTestModel
    {
        [Key]
        [Required]
        public int TestID { get; set; }
        public int EmployeeModelID { get; set; }
        public double HoursSpent { get; set; }
        public string TaskDescription { get; set; }

    }
}