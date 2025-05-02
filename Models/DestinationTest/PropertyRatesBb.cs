using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("property_rates_bb", Schema = "dbo")]
    public partial class PropertyRatesBb
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }

        public double? PreThank { get; set; }

        public double? Thanks { get; set; }

        public double? WinterWeekend { get; set; }

        public double? WinterWeekday { get; set; }

        public double? SkiWeek { get; set; }

        public double? Christmas { get; set; }

        public double? NewYears { get; set; }

        public double? PostNewYears { get; set; }

        [Column("MLK114")]
        public double? Mlk114 { get; set; }

        public double? PresidentsDay { get; set; }

        public double? Patricks { get; set; }

        public double? Easter { get; set; }

        public double? MemorialDay { get; set; }

        public double? July4th { get; set; }

        public double? LaborDay { get; set; }

        public double? Jan23 { get; set; }

        public double? SpringWeekend { get; set; }

        public double? SpringWeekday { get; set; }

        public double? SummerWeekend { get; set; }

        public double? SummerWeekday { get; set; }

        public double? FallWeekend { get; set; }

        public double? FallWeekday { get; set; }

        [Column("prechristmas")]
        public double? Prechristmas { get; set; }

        public double? MarchWeekend { get; set; }

        public double? MarchWeekday { get; set; }

        public int? UserId { get; set; }

        public double? NovWeekend { get; set; }

        public double? NovWeekday { get; set; }

        public double? DecEarlyWeekend { get; set; }

        public double? DecEarlyWeekday { get; set; }

        public double? MayJuneWeekend { get; set; }

        public double? MayJuneWeekday { get; set; }
    }
}