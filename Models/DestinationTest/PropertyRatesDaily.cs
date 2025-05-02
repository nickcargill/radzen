using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("PropertyRates_Daily", Schema = "dbo")]
    public partial class PropertyRatesDaily
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? PropId { get; set; }

        public Property Property { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }

        public decimal? Rate { get; set; }

        public int? Nights { get; set; }

        [Column("inspection")]
        public string Inspection { get; set; }

        public int? MinNight { get; set; }

        public int? MaxNight { get; set; }
    }
}