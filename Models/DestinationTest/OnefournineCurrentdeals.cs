using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("currentdeals", Schema = "onefournine")]
    public partial class OnefournineCurrentdeals
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("specialsid")]
        public int Specialsid { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }

        [Column("startdate")]
        public DateTime? Startdate { get; set; }

        [Column("enddate")]
        public DateTime? Enddate { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("specialdesc")]
        public string Specialdesc { get; set; }

        [Column("sdate")]
        public DateTime? Sdate { get; set; }

        [Column("edate")]
        public DateTime? Edate { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("showorder")]
        public int? Showorder { get; set; }

        [Column("amount")]
        public double? Amount { get; set; }
    }
}