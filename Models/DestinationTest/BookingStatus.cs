using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Booking_Status", Schema = "dbo")]
    public partial class BookingStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("color")]
        public string Color { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        public ICollection<FilterDataForBulkSmsMail> FilterDataForBulkSmsMails { get; set; }
    }
}