using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_getlastyearTotal_PY", Schema = "dbo")]
    public partial class VwGetlastyearTotalPy
    {
        [Column("PropertyID")]
        public int? PropertyId { get; set; }

        public double? Rental { get; set; }
    }
}