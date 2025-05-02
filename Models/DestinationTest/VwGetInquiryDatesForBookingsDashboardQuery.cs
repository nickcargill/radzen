using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_getInquiryDates_ForBookingsDashboardQuery", Schema = "dbo")]
    public partial class VwGetInquiryDatesForBookingsDashboardQuery
    {
        public string InquiryDate { get; set; }
    }
}