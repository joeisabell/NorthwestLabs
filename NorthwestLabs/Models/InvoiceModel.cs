using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Invoice")]
    public class InvoiceModel
    {
        [Key]
        [Required]
        public int InvoiceID { get; set; }
        public int WorkOrderID { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime EarlyPaymentDate { get; set; }
        public int Discount { get; set; }

    }
}