using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AirbnbMessages", Schema = "dbo")]
    public partial class AirbnbMessage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("ThreadID")]
        public string ThreadId { get; set; }

        public DateTime? MsgDate { get; set; }

        public string ConfirmationCode { get; set; }

        public string JsonData { get; set; }

        public int? MessageType { get; set; }

        public bool? IsArchived { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }
    }
}