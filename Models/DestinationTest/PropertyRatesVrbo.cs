using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Property_rates_vrbo", Schema = "dbo")]
    public partial class PropertyRatesVrbo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }

        public Property Property { get; set; }

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

        public double? NextJuly4th { get; set; }

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

        public double? DecThird { get; set; }

        public double? NovWeekend { get; set; }

        public double? NovWeekday { get; set; }

        public double? DecEarlyWeekend { get; set; }

        public double? DecEarlyWeekday { get; set; }

        public double? MayWeekend { get; set; }

        public double? MayWeekday { get; set; }

        public double? NextSummerWeekday { get; set; }

        public double? NextSummerWeekend { get; set; }

        public double? NextFallWeekday { get; set; }

        public double? NextFallWeekend { get; set; }

        public double? JuneWeekend { get; set; }

        public double? JuneWeekday { get; set; }

        public double? AprilWeekend { get; set; }

        public double? AprilWeekday { get; set; }

        public double? NextThanks { get; set; }

        public double? NextLaborDay { get; set; }

        public double? NextDecEarlyWeekday { get; set; }

        public double? NextDecEarlyWeekend { get; set; }

        public double? NextWinterWeekday { get; set; }

        public double? NextWinterWeekend { get; set; }

        public double? Christmasday { get; set; }

        public double? NewYearsday { get; set; }

        public double? Jan2 { get; set; }

        public double? Jan3 { get; set; }

        [Column("NewYEarsEve")]
        public double? NewYearsEve { get; set; }

        [Column("1223")]
        public double? _1223 { get; set; }

        [Column("1224")]
        public double? _1224 { get; set; }

        [Column("1222")]
        public double? _1222 { get; set; }
    }
}