using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("UV_GetBackToBackCheckInsPerDay", Schema = "dbo")]
    public partial class UvGetBackToBackCheckInsPerDay
    {
        [Column("dateto")]
        public DateTime? Dateto { get; set; }

        [Column("TotalBackToBackCheck_In")]
        public int? TotalBackToBackCheckIn { get; set; }
    }
}