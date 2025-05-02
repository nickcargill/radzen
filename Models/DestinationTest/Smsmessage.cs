using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("SMSMessages", Schema = "dbo")]
    public partial class Smsmessage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SMSId")]
        public int Smsid { get; set; }

        public int? ResourceId { get; set; }

        public string MessageBody { get; set; }

        public string MessageSubject { get; set; }

        public int? MessageStatus { get; set; }

        public string MessageId { get; set; }

        public DateTime? MessageDate { get; set; }

        [Column("FromSMSNumber")]
        public string FromSmsnumber { get; set; }

        [Column("ToSMSNumber")]
        public string ToSmsnumber { get; set; }

        public int? UserType { get; set; }

        public bool? Priority { get; set; }

        public bool? IsArchived { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        public bool? IsRead { get; set; }
    }
}