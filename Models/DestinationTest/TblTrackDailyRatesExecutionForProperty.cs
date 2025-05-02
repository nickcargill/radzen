using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tblTrackDailyRatesExecutionForProperty", Schema = "dbo")]
    public partial class TblTrackDailyRatesExecutionForProperty
    {
        [Column("PropID")]
        public int? PropId { get; set; }

        public DateTime? ExecTime { get; set; }

        public bool? IsProcessed { get; set; }

        public string ProcessedAction { get; set; }
    }
}