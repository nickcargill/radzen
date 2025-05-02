using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_getlast6MonthsTotal_PY", Schema = "dbo")]
    public partial class VwGetlast6MonthsTotalPy
    {
        [Column("PropertyID")]
        public int? PropertyId { get; set; }

        public double? Rental { get; set; }
    }
}