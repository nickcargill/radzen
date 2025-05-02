using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_GetClosestBookingWithCleaningStatus", Schema = "dbo")]
    public partial class VwGetClosestBookingWithCleaningStatus
    {
        [Column("propertyid")]
        public int? Propertyid { get; set; }

        [Column("dateto")]
        public DateTime? Dateto { get; set; }

        [Column("cleaningcomp")]
        public bool? Cleaningcomp { get; set; }
    }
}