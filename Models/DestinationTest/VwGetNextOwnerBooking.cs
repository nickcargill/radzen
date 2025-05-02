using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("VW_GetNextOwnerBookings", Schema = "dbo")]
    public partial class VwGetNextOwnerBooking
    {
        [Column("propid")]
        [Required]
        public int Propid { get; set; }

        public DateTime? NextdateFrom { get; set; }

        public int? NextBookingId { get; set; }
    }
}