using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("WorkOrder")]
    public class WorkOrderModel
    {
            [Key]
            [Required]
            public int WorkOrderID { get; set; }
            public int ClientID { get; set; }
            public DateTime DateRequested { get; set; }
            public string WorkDescription { get; set; }

    }
}