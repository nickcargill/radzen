using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("VoiceMail", Schema = "dbo")]
    public partial class VoiceMail
    {
        public string PhoneNumber { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        [Column("StatusID")]
        public int? StatusId { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}