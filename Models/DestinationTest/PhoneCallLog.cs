using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("PhoneCallLogs", Schema = "dbo")]
    public partial class PhoneCallLog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public int? InboundCalls { get; set; }

        public string InboundTalktime { get; set; }

        public int? OutboundCalls { get; set; }

        public string OutboundTalktime { get; set; }

        public string TotalHoursWorked { get; set; }

        [Column("UserID")]
        public int? UserId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string Notes { get; set; }

        public DateTime? DateOfCall { get; set; }

        public int? MissedCalls { get; set; }
    }
}