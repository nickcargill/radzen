using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Channel_bu", Schema = "dbo")]
    public partial class ChannelBu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("propid")]
        [Required]
        public int Propid { get; set; }

        [Column("airbnb")]
        public string Airbnb { get; set; }

        [Column("vrbo")]
        public string Vrbo { get; set; }

        [Column("flipkey")]
        public string Flipkey { get; set; }

        [Column("pushtoairbnb")]
        public bool? Pushtoairbnb { get; set; }

        public bool? Instant { get; set; }

        [Column("cancellation")]
        public string Cancellation { get; set; }

        public string Checkin { get; set; }

        public string CheckOut { get; set; }

        public bool? Children { get; set; }

        public bool? EventsAllowed { get; set; }

        [Column("airbnbadjustment")]
        public double? Airbnbadjustment { get; set; }

        [Column("bookingadjustment")]
        public double? Bookingadjustment { get; set; }

        public string Booking { get; set; }

        public string BigBear { get; set; }

        [Column("bookingcom")]
        public string Bookingcom { get; set; }

        [Column("AirbnbAPI")]
        public long? AirbnbApi { get; set; }

        public string PermitNumber { get; set; }

        public DateTime? PermitExpiry { get; set; }
    }
}