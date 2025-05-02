using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_getTotalInquiries_ForBookingsDashboardQuery", Schema = "dbo")]
    public partial class VwGetTotalInquiriesForBookingsDashboardQuery
    {
        public string InquiryDate { get; set; }

        public int? Total { get; set; }
    }
}