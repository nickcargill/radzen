using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_CleanedStatus_CheckOutToday", Schema = "dbo")]
    public partial class VwCleanedStatusCheckOutToday
    {
        [Column("propertyid")]
        public int? Propertyid { get; set; }

        [Column("status")]
        public string Status { get; set; }
    }
}