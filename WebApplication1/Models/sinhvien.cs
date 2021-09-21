using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class sinhvien
    {
        [Key]
        public string hovaten { get; set; }
        public string school { get; set; }
    }
}
