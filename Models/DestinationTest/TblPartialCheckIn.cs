using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tblPartialCheckIn", Schema = "dbo")]
    public partial class TblPartialCheckIn
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        public bool? IsChecked { get; set; }

        public DateTime? DateTimeStamp { get; set; }
    }
}