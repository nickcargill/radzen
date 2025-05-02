using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("DeletedGapHolderBookings", Schema = "dbo")]
    public partial class DeletedGapHolderBooking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        [Column("BookingID1")]
        public int? BookingId1 { get; set; }

        [Column("StatusID1")]
        public int? StatusId1 { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        [Column("BookingID2")]
        public int? BookingId2 { get; set; }

        [Column("StatusID2")]
        public int? StatusId2 { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? EnteredDate { get; set; }
    }
}