using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("SendAirbnbCheckOutReplies", Schema = "dbo")]
    public partial class SendAirbnbCheckOutReply
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        public DateTime? InsertedAt { get; set; }

        public bool? IsSent { get; set; }

        public DateTime? SentAt { get; set; }
    }
}