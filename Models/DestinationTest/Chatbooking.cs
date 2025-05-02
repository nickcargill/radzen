using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("chatbookings", Schema = "dbo")]
    public partial class Chatbooking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("chatid")]
        public int Chatid { get; set; }

        [Column("bookingid")]
        public int? Bookingid { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }
    }
}