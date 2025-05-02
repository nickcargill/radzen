using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AppliedPromoCodes", Schema = "dbo")]
    public partial class AppliedPromoCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        public Booking Booking { get; set; }

        public string PromoCode { get; set; }

        public DateTime DateApplied { get; set; }
    }
}