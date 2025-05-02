using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_LastBookedOn", Schema = "dbo")]
    public partial class VwLastBookedOn
    {
        [Column("propertyid")]
        public int? Propertyid { get; set; }

        public DateTime? BookedOn { get; set; }
    }
}