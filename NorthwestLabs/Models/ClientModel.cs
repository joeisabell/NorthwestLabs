using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Client")]
    public class ClientModel
    {
        [Key]
        [Required]
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string CreditRating { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string PrimaryContactFullName { get; set; }
        public string PrimaryContactPhone { get; set; }

    }
}