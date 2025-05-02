using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AirbnbSendMessages", Schema = "dbo")]
    public partial class AirbnbSendMessage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("ThreadID")]
        public long? ThreadId { get; set; }

        public string TextMsg { get; set; }

        public string ImageString { get; set; }

        public string ImageContentType { get; set; }

        public bool? IsSent { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? SentOn { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        public Booking Booking { get; set; }

        [Column("TemplateID")]
        public int? TemplateId { get; set; }
    }
}