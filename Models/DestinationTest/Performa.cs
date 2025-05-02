using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Performa", Schema = "dbo")]
    public partial class Performa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PerformaId { get; set; }

        [Column("propId")]
        public int? PropId { get; set; }

        public Property Property { get; set; }

        public double? PeakSummerValue { get; set; }

        public int? PeakSummerWeeks { get; set; }

        public int? SummerOccupancy { get; set; }

        public double? SummerRate { get; set; }

        public double? AnnualWinterValue { get; set; }

        public int? WinterWeeks { get; set; }

        public int? WinterOccupancy { get; set; }

        public double? WinterRate { get; set; }

        public double? RemainingSeasonValue { get; set; }

        public int? RemainingWeeks { get; set; }

        public int? RemainingOccupancy { get; set; }

        public double? RemainingRate { get; set; }

        public double? ProfessionalMgmtFees { get; set; }

        public double? Maintenance { get; set; }

        public double? Utilities { get; set; }

        public double? LandscapingValue { get; set; }

        public double? Marketing { get; set; }

        public double? Photography { get; set; }

        public double? HomeAutomationSubscription { get; set; }

        public double? PropaneRefills { get; set; }

        public double? HotTubService { get; set; }

        public double? GuestAmenityPacks { get; set; }

        public double? PestControl { get; set; }

        public double? PropertyInsurance { get; set; }

        public double? PropertyTaxes { get; set; }

        [Column("HOADues")]
        public double? Hoadues { get; set; }

        public string Messsage { get; set; }

        public string FromYear { get; set; }

        public string ToYear { get; set; }

        public DateTime? CreatedDate { get; set; }

        [Column("live")]
        public bool? Live { get; set; }

        public double? SnowRemoval { get; set; }

        public double? WindowClean { get; set; }

        public string Pros { get; set; }

        public string Cons { get; set; }

        [Column("squarefoot")]
        public double? Squarefoot { get; set; }

        public double? AnnualNewYearAmount { get; set; }

        public double? NewYearAvgRate { get; set; }

        public double? AnnualChristmasAmount { get; set; }

        public double? ChristmasAvgRate { get; set; }

        [Column("pdfpath")]
        public string Pdfpath { get; set; }

        public string SummerWeekday { get; set; }

        public string SummerWeekend { get; set; }

        public string FallWeekday { get; set; }

        public string FallWeekend { get; set; }

        public string WinterWeekend { get; set; }

        public string WinterWeekday { get; set; }

        public string SpringWeekend { get; set; }

        public string SpringWeekday { get; set; }

        public string SummerPeak { get; set; }

        public string WinterPeak { get; set; }

        public string AnnualGross { get; set; }

        public string Intro { get; set; }

        public string Summary { get; set; }

        public string LivingSpace { get; set; }

        [Column("listedby")]
        public string Listedby { get; set; }
    }
}