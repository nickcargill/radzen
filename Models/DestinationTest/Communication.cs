using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Communication", Schema = "dbo")]
    public partial class Communication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Commid { get; set; }

        [Column("type")]
        public string Type { get; set; }

        [Column("commdate")]
        public DateTime? Commdate { get; set; }

        [Column("commcode")]
        public string Commcode { get; set; }

        [Column("communication")]
        public string Communication1 { get; set; }

        [Column("bookingid")]
        public int? Bookingid { get; set; }

        [Column("propexid")]
        public int? Propexid { get; set; }

        [Column("budget")]
        public double? Budget { get; set; }

        [Column("agent")]
        public int? Agent { get; set; }

        [Column("comcode")]
        public int? Comcode { get; set; }

        [Column("amount")]
        public double? Amount { get; set; }

        public string Receipt { get; set; }

        [Column("actionrequired")]
        public bool? Actionrequired { get; set; }

        [Column("assigned")]
        public int? Assigned { get; set; }

        [Column("strCustomMsg")]
        public string StrCustomMsg { get; set; }

        [Column("intPaymentid")]
        public int? IntPaymentid { get; set; }

        public string Emailtemplate { get; set; }

        public bool? IsRespond { get; set; }

        public string AirbnbReplyLink { get; set; }

        public bool? IsRcvdThruAirbnb { get; set; }

        [Column("ThreadID")]
        public long? ThreadId { get; set; }

        public string ConfirmationCode { get; set; }

        public bool? IsEmailSentForDepositHold { get; set; }

        public bool? SpokeTo { get; set; }

        public bool? VoiceMail { get; set; }
    }
}