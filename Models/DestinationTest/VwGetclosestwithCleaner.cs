using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_getclosestwithCleaner", Schema = "dbo")]
    public partial class VwGetclosestwithCleaner
    {
        [Column("propertyid")]
        public int? Propertyid { get; set; }

        [Column("cleaningcomp")]
        public bool? Cleaningcomp { get; set; }
    }
}