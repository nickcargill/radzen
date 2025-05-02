using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_CurrentlyOccupied", Schema = "dbo")]
    public partial class VwCurrentlyOccupied
    {
        [Column("propertyid")]
        public int? Propertyid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingId { get; set; }
    }
}