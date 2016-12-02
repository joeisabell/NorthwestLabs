using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Payment")]
    public class PaymentModel
    {
        [Key]
        [Required]
        public int InvoiceID { get; set; }
        public string PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }
        public float PaymentAmount { get; set; }

    }
}