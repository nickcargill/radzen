using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("GoogleUsersKeywords", Schema = "dbo")]
    public partial class GoogleUsersKeyword
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        public Booking Booking { get; set; }

        public string SearchTerms { get; set; }

        public DateTime? EnteredOn { get; set; }
    }
}