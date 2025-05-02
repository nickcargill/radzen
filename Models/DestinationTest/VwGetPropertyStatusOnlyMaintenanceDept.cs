using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_getPropertyStatus_OnlyMaintenanceDept", Schema = "dbo")]
    public partial class VwGetPropertyStatusOnlyMaintenanceDept
    {
        [Column("propid")]
        public int? Propid { get; set; }

        [Column("Open Count")]
        public int? OpenCount { get; set; }
    }
}