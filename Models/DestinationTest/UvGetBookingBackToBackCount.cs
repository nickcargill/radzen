using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("UV_GetBookingBackToBackCount", Schema = "dbo")]
    public partial class UvGetBookingBackToBackCount
    {
        public DateTime? DateFrom { get; set; }

        public int? CheckIn { get; set; }

        public int? BackToBack { get; set; }
    }
}