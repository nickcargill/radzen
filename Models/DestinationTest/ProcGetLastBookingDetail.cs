using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("proc_GetLastBookingDetails", Schema = "dbo")]
    public partial class ProcGetLastBookingDetail
    {
        [Column("BookingID")]
        [Required]
        public int BookingId { get; set; }

        [Column("datefrom")]
        public DateTime? Datefrom { get; set; }

        [Column("dateto")]
        public DateTime? Dateto { get; set; }

        [Column("statusid")]
        public int? Statusid { get; set; }

        public int? Inspectedby { get; set; }

        [Column("Inspect_Date")]
        public DateTime? InspectDate { get; set; }

        public string CleanerName { get; set; }

        [Required]
        public string IsCleaned { get; set; }

        [Column("Clean_Date")]
        public DateTime? CleanDate { get; set; }
    }
}