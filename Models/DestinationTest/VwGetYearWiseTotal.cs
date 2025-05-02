using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_getYearWiseTotal", Schema = "dbo")]
    public partial class VwGetYearWiseTotal
    {
        [Column("PropertyID")]
        public int? PropertyId { get; set; }

        public double? Rental { get; set; }

        public int? BookingYear { get; set; }
    }
}