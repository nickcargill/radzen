using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Vw_GetTrackedUsers", Schema = "dbo")]
    public partial class VwGetTrackedUser1
    {
        [Column("BookingID")]
        public int? BookingId { get; set; }

        public DateTime? LastVisitedOn { get; set; }
    }
}