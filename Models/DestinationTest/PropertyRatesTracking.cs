using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("property_rates_tracking", Schema = "dbo")]
    public partial class PropertyRatesTracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PropertyRatesTrackingId { get; set; }

        public int? PropId { get; set; }

        public string FieldName { get; set; }

        public double? DataBeforeChange { get; set; }

        public double? DataAfterChange { get; set; }

        public DateTime? DateChanged { get; set; }

        public int? ChangedById { get; set; }
    }
}