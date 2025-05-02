using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("BookingAddOwnerReport", Schema = "dbo")]
    public partial class BookingAddOwnerReport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        [Column("bookingid")]
        public int? Bookingid { get; set; }

        public bool? Openbit { get; set; }

        public bool? Closebit { get; set; }

        public bool? Cleanbit { get; set; }

        [Column("dateentered")]
        public DateTime? Dateentered { get; set; }
    }
}