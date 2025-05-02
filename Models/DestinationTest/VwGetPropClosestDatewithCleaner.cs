using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_GetPropClosestDatewithCleaner", Schema = "dbo")]
    public partial class VwGetPropClosestDatewithCleaner
    {
        [Column("propertyid")]
        public int? Propertyid { get; set; }

        [Column("dateto")]
        public DateTime? Dateto { get; set; }

        [Column("cleaner")]
        public int? Cleaner { get; set; }
    }
}