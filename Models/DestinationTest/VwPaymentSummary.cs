using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_PaymentSummary", Schema = "dbo")]
    public partial class VwPaymentSummary
    {
        [Column("intBookingId")]
        public int? IntBookingId { get; set; }

        public double? Total { get; set; }
    }
}