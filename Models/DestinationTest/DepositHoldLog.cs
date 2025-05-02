using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("DepositHoldLog", Schema = "dbo")]
    public partial class DepositHoldLog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public string Notes { get; set; }

        public string Status { get; set; }

        [Column("HONeedsContacting")]
        public bool? HoneedsContacting { get; set; }

        [Column("HOContacted")]
        public bool? Hocontacted { get; set; }
    }
}