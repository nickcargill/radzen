using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("v_record", Schema = "dbo")]
    public partial class VRecord
    {
        [Column("propid")]
        public int? Propid { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Required]
        public string TopProperty { get; set; }

        public int? RevenueGoal { get; set; }

        [Column("bedrooms")]
        public string Bedrooms { get; set; }

        [Column("sleeps")]
        public int? Sleeps { get; set; }

        [Required]
        public int TotalBookings { get; set; }

        [Column("nights")]
        [Required]
        public int Nights { get; set; }

        [Column("rentalamount")]
        public decimal? Rentalamount { get; set; }

        [Column("mgtfee")]
        public decimal? Mgtfee { get; set; }

        public decimal? Collected { get; set; }

        [Column("avgrentalamount")]
        public decimal? Avgrentalamount { get; set; }

        [Column("avgmgtfee")]
        public decimal? Avgmgtfee { get; set; }

        [Column("avgCollected")]
        public decimal? AvgCollected { get; set; }

        [Column("PNrentalamount")]
        public decimal? Pnrentalamount { get; set; }

        [Column("PNmgtfee")]
        public decimal? Pnmgtfee { get; set; }

        [Column("PNCollected")]
        public decimal? Pncollected { get; set; }

        public string LastBookedOn { get; set; }

        [Column("percentoff")]
        public double? Percentoff { get; set; }
    }
}