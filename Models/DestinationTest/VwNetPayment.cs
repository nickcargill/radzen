using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_NetPayments", Schema = "dbo")]
    public partial class VwNetPayment
    {
        [Column("intBookingId")]
        public int? IntBookingId { get; set; }

        public double? NetPayments { get; set; }
    }
}