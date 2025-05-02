using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_get_comm_max", Schema = "dbo")]
    public partial class VwGetCommMax
    {
        [Column("bookingid")]
        public int? Bookingid { get; set; }

        [Column("commdate")]
        public DateTime? Commdate { get; set; }
    }
}