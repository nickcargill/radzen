using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_GetLastCleaner", Schema = "dbo")]
    public partial class VwGetLastCleaner
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("BookingID")]
        public int BookingId { get; set; }

        [Column("CleanerID")]
        public int? CleanerId { get; set; }
    }
}