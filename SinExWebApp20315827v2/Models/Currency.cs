using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SinExWebApp20315827v2.Models
{
    [Table("Currencies")]
    public class Currency
    {
        public string CurrencyCode { get; set; }
        public float ExchangeRate { get; set; }
    }
}