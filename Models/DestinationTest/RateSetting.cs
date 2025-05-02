using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("RateSettings", Schema = "dbo")]
    public partial class RateSetting
    {
        [Key]
        [Required]
        public double TaxRate { get; set; }

        public double? DamageWaiver { get; set; }

        public double? ResortFee { get; set; }
    }
}