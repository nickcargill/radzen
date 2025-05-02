using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("VW_GetNextBookings", Schema = "dbo")]
    public partial class VwGetNextBooking
    {
        [Column("propid")]
        [Required]
        public int Propid { get; set; }

        public DateTime? NextdateFrom { get; set; }
    }
}