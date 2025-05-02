using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_getTotalBkngs_ForBookingsDashboardQuery", Schema = "dbo")]
    public partial class VwGetTotalBkngsForBookingsDashboardQuery
    {
        public string InquiryDate { get; set; }

        public int? Total { get; set; }
    }
}