using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tblBookingInterest", Schema = "dbo")]
    public partial class TblBookingInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        [Column("InterestID")]
        public int? InterestId { get; set; }

        public DateTime? LoggedDate { get; set; }
    }
}