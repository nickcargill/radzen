using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_get_tracked_users", Schema = "dbo")]
    public partial class VwGetTrackedUser
    {
        [Column("BookingID")]
        public int? BookingId { get; set; }

        public DateTime? LastVisitedOn { get; set; }
    }
}