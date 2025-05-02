using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("GuestCodeCalls", Schema = "dbo")]
    public partial class GuestCodeCall
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        public string CodeType { get; set; }

        public string Detail { get; set; }

        public string Status { get; set; }

        public string Notes { get; set; }

        [Column("SMSID")]
        public int? Smsid { get; set; }
    }
}