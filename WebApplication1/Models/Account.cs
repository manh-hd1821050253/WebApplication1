﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTB1.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
