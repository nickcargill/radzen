using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_getTotalExpenses", Schema = "dbo")]
    public partial class VwGetTotalExpense
    {
        [Column("propid")]
        public int? Propid { get; set; }

        [Column("Opened in 90 days")]
        public int? OpenedIn90Days { get; set; }

        [Column("Last 90 days")]
        public double? Last90Days { get; set; }

        [Column("Opened in 120 days")]
        public int? OpenedIn120Days { get; set; }

        [Column("Last 120 days")]
        public double? Last120Days { get; set; }

        [Column("Opened in 180 days")]
        public int? OpenedIn180Days { get; set; }

        [Column("Last 180 days")]
        public double? Last180Days { get; set; }

        [Column("Opened in 12 months")]
        public int? OpenedIn12Months { get; set; }

        [Column("last 12 Months")]
        public double? Last12Months { get; set; }
    }
}