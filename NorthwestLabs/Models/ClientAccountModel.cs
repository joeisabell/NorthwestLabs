using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Client_Account")]
    public class ClientAccountModel
    {
            [Key]
            [Required]
            public string Email { get; set; }
            public int ClientID { get; set; }
            public string Password { get; set; }

    }
}