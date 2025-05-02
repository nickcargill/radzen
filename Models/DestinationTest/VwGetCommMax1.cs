using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Vw_GetCommMax", Schema = "dbo")]
    public partial class VwGetCommMax1
    {
        [Column("BookingID")]
        public int? BookingId { get; set; }

        [Column("commdate")]
        public DateTime? Commdate { get; set; }
    }
}