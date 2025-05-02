using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("bookings_owners", Schema = "dbo")]
    public partial class BookingsOwner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("bookingid")]
        [Required]
        public int Bookingid { get; set; }

        [Column("prepped")]
        public bool? Prepped { get; set; }

        [Column("preppedm")]
        public bool? Preppedm { get; set; }
    }
}