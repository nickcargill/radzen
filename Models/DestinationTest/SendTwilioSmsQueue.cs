using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("SendTwilioSMS_Queue", Schema = "dbo")]
    public partial class SendTwilioSmsQueue
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SMSId")]
        public long Smsid { get; set; }

        [Column("SMSNumber")]
        public string Smsnumber { get; set; }

        public string Subject { get; set; }

        [Column("SMSBody")]
        public string Smsbody { get; set; }

        [Column("SMSStatus")]
        public int? Smsstatus { get; set; }

        public int? BookingId { get; set; }

        [Column("PropExpID")]
        public int? PropExpId { get; set; }

        [Column("TemplateID")]
        public int? TemplateId { get; set; }

        public bool? IsPicked { get; set; }

        [Column("AgentID")]
        public int? AgentId { get; set; }

        public string CommCode { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}