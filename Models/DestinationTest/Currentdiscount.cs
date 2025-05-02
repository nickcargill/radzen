using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("currentdiscounts", Schema = "dbo")]
    public partial class Currentdiscount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("specialsid")]
        public int Specialsid { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }

        public Property Property { get; set; }

        [Column("sdate")]
        public DateTime? Sdate { get; set; }

        [Column("edate")]
        public DateTime? Edate { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("specialdesc")]
        public string Specialdesc { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("sortorder")]
        public int? Sortorder { get; set; }

        [Column("amount")]
        public double? Amount { get; set; }

        [Column("percentoff")]
        public double? Percentoff { get; set; }

        [Column("discountid")]
        public int? Discountid { get; set; }

        public bool? IsDiscount { get; set; }

        public DateTime? ChangeDate { get; set; }

        public int? RevenueGoal { get; set; }

        [Column("SkipOTA")]
        public bool? SkipOta { get; set; }

        public bool? SkipAirbnb { get; set; }
    }
}