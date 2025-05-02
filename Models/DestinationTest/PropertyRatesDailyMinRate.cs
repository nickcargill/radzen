using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("PropertyRatesDaily_MinRate", Schema = "dbo")]
    public partial class PropertyRatesDailyMinRate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }

        public decimal? MinWeekdayRate { get; set; }

        public decimal? MinWeekendRate { get; set; }
    }
}