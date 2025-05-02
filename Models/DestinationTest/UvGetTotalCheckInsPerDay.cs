using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("UV_GetTotalCheckInsPerDay", Schema = "dbo")]
    public partial class UvGetTotalCheckInsPerDay
    {
        [Column("datefrom")]
        public DateTime? Datefrom { get; set; }

        [Column("TotalCheck_In")]
        public int? TotalCheckIn { get; set; }
    }
}