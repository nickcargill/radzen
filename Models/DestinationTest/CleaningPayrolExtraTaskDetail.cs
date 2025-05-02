using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("CleaningPayrol_ExtraTaskDetail", Schema = "dbo")]
    public partial class CleaningPayrolExtraTaskDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("CleanerID")]
        public int? CleanerId { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        [Column("TaskID")]
        public int? TaskId { get; set; }

        public decimal? Amount { get; set; }

        public string Notes { get; set; }

        public DateTime? EnteredOn { get; set; }

        public bool? IsMatched { get; set; }

        public DateTime? MatchedOn { get; set; }

        public DateTime? PaidDate { get; set; }

        public string MatchedHistory { get; set; }

        public string PaidHistory { get; set; }
    }
}