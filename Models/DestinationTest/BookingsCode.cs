using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("bookingsCodes", Schema = "dbo")]
    public partial class BookingsCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        public string LockCode { get; set; }

        public DateTime? GeneratedDate { get; set; }

        [Column("intStatus")]
        public int? IntStatus { get; set; }

        [Column("messageResponse")]
        public string MessageResponse { get; set; }

        [Column("Res_DateTime")]
        public DateTime? ResDateTime { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }
    }
}