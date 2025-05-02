using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Vw_GetPrpertiesHotOpen", Schema = "dbo")]
    public partial class VwGetPrpertiesHotOpen
    {
        [Column("propid")]
        public int? Propid { get; set; }
    }
}