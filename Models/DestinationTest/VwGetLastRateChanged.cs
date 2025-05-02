using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_GetLastRateChanged", Schema = "dbo")]
    public partial class VwGetLastRateChanged
    {
        [Column("propid")]
        public int? Propid { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}