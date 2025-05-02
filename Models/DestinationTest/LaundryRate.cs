using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("LaundryRates", Schema = "dbo")]
    public partial class LaundryRate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public int? Home { get; set; }

        public int? Cleaner { get; set; }

        public double? WinterRateWithLaundry { get; set; }

        public double? WinterRateWithoutLaundry { get; set; }

        public double? NonWinterRateWithLaundry { get; set; }

        public double? NonWinterRateWithoutLaundry { get; set; }

        public double? DeepClean { get; set; }
    }
}