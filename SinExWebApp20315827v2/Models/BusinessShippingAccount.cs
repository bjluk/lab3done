using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SinExWebApp20315827v2.Models
{
    public class BusinessShippingAccount : ShippingAccount
    {
        [Required]
        [StringLength(70)]
        public string ContactPerson { get; set; }
        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }
        [StringLength(30)]
        public string DepartmentName { get; set; }

    }
}