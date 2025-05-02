using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_TenantCount", Schema = "dbo")]
    public partial class VwTenantCount
    {
        [Column("TenantID")]
        public int? TenantId { get; set; }

        public int? Count { get; set; }
    }
}