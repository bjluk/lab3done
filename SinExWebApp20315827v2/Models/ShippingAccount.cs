using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SinExWebApp20315827v2.Models
{
    [Table("ShippingAccount")]
    public abstract class ShippingAccount
    {
        public virtual int ShippingAccountId { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string BuildingInformation { get; set; }
        [Required]
        [StringLength(35)]
        public virtual string StreetInformation { get; set; }
        [Required]
        [StringLength(25)]
        public virtual string City { get; set; }
        [Required]
        [StringLength(2, MinimumLength =2)]
        [RegularExpression(@"^[A-Z]", ErrorMessage ="Two characters only, bitch")]
        public virtual string ProvinceCode { get; set; }
        [StringLength(6, MinimumLength = 5)]
        [RegularExpression(@"[0-9]", ErrorMessage ="numbers only bitch")]
        public virtual string PostalCode { get; set; }
        [Required]
        [StringLength(14, MinimumLength = 8)]
        [RegularExpression(@"[0-9]", ErrorMessage = "numbers only bitch")]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(30)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage ="gimmie a real email")]
        public string Email { get; set; }

    }
}