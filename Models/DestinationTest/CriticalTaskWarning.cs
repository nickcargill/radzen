using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("CriticalTaskWarning", Schema = "dbo")]
    public partial class CriticalTaskWarning
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("TaskID")]
        public int? TaskId { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        public bool? IsContacted { get; set; }

        public string Status { get; set; }

        public string Notes { get; set; }
    }
}