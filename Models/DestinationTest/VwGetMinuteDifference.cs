using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_get_minuteDifference", Schema = "dbo")]
    public partial class VwGetMinuteDifference
    {
        [Column("BookingID")]
        public int? BookingId { get; set; }

        public int? DiffInMin { get; set; }

        [Column("lastvisitedOn")]
        public DateTime? LastvisitedOn { get; set; }
    }
}