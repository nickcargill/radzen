using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_getPropertyStatus", Schema = "dbo")]
    public partial class VwGetPropertyStatus
    {
        [Column("propid")]
        public int? Propid { get; set; }

        [Column("Open Count")]
        public int? OpenCount { get; set; }
    }
}