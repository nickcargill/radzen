using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AffiliateBookings", Schema = "dbo")]
    public partial class AffiliateBooking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AffiliateBookingID")]
        public int AffiliateBookingId { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        public Booking Booking { get; set; }

        public decimal? CommissionPercentage { get; set; }

        public decimal? Commission { get; set; }

        public string Website { get; set; }

        public decimal? CommissionPaid { get; set; }

        public string PromoCode { get; set; }

        public DateTime CreateDate { get; set; }

        [Column("AffiliateID")]
        public int? AffiliateId { get; set; }

        public Affiliate Affiliate { get; set; }
    }
}