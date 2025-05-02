using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("VW_FutureBookings", Schema = "dbo")]
    public partial class VwFutureBooking
    {
        [Required]
        public int Propid { get; set; }

        public DateTime? LastDateFrom { get; set; }

        public int? FutureBookings { get; set; }
    }
}