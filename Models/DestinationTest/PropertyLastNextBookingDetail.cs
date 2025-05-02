using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Property_Last_Next_BookingDetails", Schema = "dbo")]
    public partial class PropertyLastNextBookingDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        [Column("LastBookingID")]
        public int? LastBookingId { get; set; }

        public int? LastBookingStatus { get; set; }

        public DateTime? LastDateFrom { get; set; }

        public DateTime? LastDateTo { get; set; }

        public bool? LastCleaned { get; set; }

        public DateTime? LastCleanDate { get; set; }

        [Column("NextBookingID")]
        public int? NextBookingId { get; set; }

        public int? NextBookingStatus { get; set; }

        public DateTime? NextDateFrom { get; set; }

        public DateTime? NextDateTo { get; set; }

        public string LastCleaner { get; set; }

        public int? NextCheckInStatus { get; set; }
    }
}