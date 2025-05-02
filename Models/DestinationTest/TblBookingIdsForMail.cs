using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tblBookingIDsForMail", Schema = "dbo")]
    public partial class TblBookingIdsForMail
    {
        [Column("BookingID")]
        public int? BookingId { get; set; }
    }
}