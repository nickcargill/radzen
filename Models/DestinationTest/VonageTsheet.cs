using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("VonageTSheet", Schema = "dbo")]
    public partial class VonageTsheet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal? ScheduledHours { get; set; }

        public decimal? WorkedHours { get; set; }

        public decimal? HoursDiff { get; set; }

        public int? TotalCalls { get; set; }

        public string TotalTalkTime { get; set; }

        public int? InboundCalls { get; set; }

        public int? OutboundCalls { get; set; }

        public int? TotalTouches { get; set; }

        public decimal? AvgHourlyTouches { get; set; }

        public DateTime? EnteredOn { get; set; }
    }
}