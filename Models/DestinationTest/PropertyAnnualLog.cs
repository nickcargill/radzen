using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("PropertyAnnualLog", Schema = "dbo")]
    public partial class PropertyAnnualLog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("AnnualTypeID")]
        public int? AnnualTypeId { get; set; }

        public string Notes { get; set; }

        public DateTime? LastUpdated { get; set; }

        [Column("TaskID")]
        public int? TaskId { get; set; }

        public bool? OpenClosedStatus { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }
    }
}